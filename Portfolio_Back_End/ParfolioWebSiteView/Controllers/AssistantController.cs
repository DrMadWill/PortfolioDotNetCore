using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ParfolioWebSiteView.Models;
using ParfolioWebSiteView.ViewModels;
using ParfolioWebSiteView.Extensions;
using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Controllers
{
    public class AssistantController : Controller
    {

        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;

        public AssistantController(PorfolioDbContext _dbContext, UserManager<User> _userManager)
        {
            dbContext = _dbContext;
            userManager = _userManager;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Comment(string message, string userId, int? commetId, int? blogId)
        {
            if (string.IsNullOrEmpty(message) || string.IsNullOrEmpty(userId)) return NotFound();

            var user = await userManager.FindByIdAsync(userId);
            if (user == null) return NotFound();

            // Leave Comment
            if (commetId == null)
            {
                var blog = await dbContext.Blogs.FirstOrDefaultAsync(dr => dr.Id.Equals(blogId));
                if (blog == null) return NotFound();

                Commet comment = new Commet
                {
                    BlogDetailsId = blog.Id,
                    Comment = message,
                    Date = DateTime.Now,
                    IsBlocked = false,
                    UserId = user.Id

                };

                await dbContext.Commets.AddAsync(comment);
                await dbContext.SaveChangesAsync();
                return Redirect($"/Home/SinglePage/{blog.Id}");
            }

            // Replay
            if (blogId == null)
            {
                var commentData = await dbContext.Commets
                    .Select(x => new { x.Id, x.BlogDetailsId })
                    .FirstOrDefaultAsync(dr => dr.Id == commetId);
                if (commentData == null) return NotFound();

                Commet comment = new Commet
                {
                    BlogDetailsId = commentData.BlogDetailsId,
                    Comment = message,
                    Date = DateTime.Now,
                    IsBlocked = false,
                    UserId = user.Id,
                    ParentId = commentData.Id

                };

                await dbContext.Commets.AddAsync(comment);
                await dbContext.SaveChangesAsync();
                return Redirect($"/Home/SinglePage/{commentData.BlogDetailsId}");
            }
            return Redirect("/");
        }


        //==================== Search ========================
        [HttpGet]
        public async Task<IActionResult> Search()
        {

            SearchVM searchInfo = new SearchVM
            {
                Popliar = await dbContext.Blogs
                .Include(x => x.User)
                .OrderByDescending(dr => dr.Id)
                .Take(5).ToListAsync(),
                Type = "Search",
                Tags = await dbContext.Tags.ToListAsync()
            };

            return View(searchInfo);
        }

        [HttpPost]
        public async Task<IActionResult> Search(string info, bool isAll, string userName)
        {
            SearchVM searchInfo = new SearchVM
            {
                Popliar = await dbContext.Blogs
                .Include(x => x.User)
                .OrderByDescending(dr => dr.Id)
                .Take(5).ToListAsync(),

            };

            if (string.IsNullOrEmpty(info)) return View(searchInfo);

            if (isAll)
            {
                searchInfo.Blogs = await dbContext.Blogs
                    .Where(dr => dr.Title.ToUpper().Contains(info.ToUpper()))
                    .Include(x => x.BlogCategory)
                    .ToListAsync();
                searchInfo.Users = await dbContext.User.Where(dr => dr.NormalizedUserName.Contains(info.ToUpper()))
                    .ToListAsync();
                searchInfo.Type = info;
            }
            else
            {
                var user = await userManager.FindByNameAsync(userName);
                if (user == null) return View(searchInfo);

                searchInfo.Blogs = await dbContext.Blogs
                    .Include(x => x.BlogCategory)
                    .Where(dr => dr.UserId == user.Id && dr.Title.ToUpper().Contains(info.ToUpper()))
                    .ToListAsync();
                searchInfo.User = user;
                searchInfo.Users = new List<User>();
                searchInfo.Type = "Blogs / " + info;
            }
            return View(searchInfo);
        }


        // ============================ SeeArchives ==========================
        public async Task<IActionResult> SeeArchives(int? id)
        {
            if (id == null ) return RedirectToAction("Search");
            var blog = (await dbContext.Blogs.Include(x=>x.User).FirstOrDefaultAsync(dr=>dr.Id==id));
            if (blog == null) return RedirectToAction("Search");

            SearchVM searchInfo = new SearchVM
            {
                Popliar = await dbContext.Blogs
                .Include(x => x.User)
                .OrderByDescending(dr => dr.Id)
                .Take(5).ToListAsync(),
                User = blog.User,
                Blogs= await dbContext.Blogs
                    .Include(x => x.BlogCategory)
                    .Where(dr => dr.UserId == blog.UserId)
                    .ToListAsync(),
                Users = new List<User>(),
                Type = "All / Blogs "
            };

            return View("Search", searchInfo);
        }


        // ============================ TagBlogs ==========================
        public async Task<IActionResult> TagBlogs(int? id)
        {
            if (id == null) RedirectToAction("Search"); ;
            var tag = await dbContext.Tags.FirstOrDefaultAsync(dr => dr.Id == id);
            if (tag == null) return NotFound();
            SearchVM searchInfo = new SearchVM
            {
                Popliar = await dbContext.Blogs
                .Include(x => x.User)
                .OrderByDescending(dr => dr.Id)
                .Take(5).ToListAsync(),
                Users = new List<User>(),
                Blogs = await dbContext.BlogToTags
                .Where(dr => dr.TagId == id)
                .Include(x => x.Blog.BlogCategory)
                .Select(x => x.Blog)
                .ToListAsync(),
                Type = "Tags / " + tag.Name
                
            };

            return View("Search", searchInfo);
        }

    }
}
