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
        public async Task<JsonResult> Comment(Commet commentu)
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return Json(new
            {
                status = 404
            });

            commentu.UserId = user.Id;

            // Model Validation
            if (!ModelState.IsValid) return Json(new
            {
                status = 404
            });

            // Leave Comment
            if (commentu.ParentId == null)
            {
                var blog = await dbContext.Blogs.FirstOrDefaultAsync(dr => dr.Id.Equals(commentu.BlogDetailsId));
                if (blog == null) return Json(new
                {
                    status = 404
                });
                commentu.BlogDetailsId = blog.Id;
                commentu.Date = DateTime.Now;
                commentu.IsBlocked = false;

                await dbContext.Commets.AddAsync(commentu);
                await dbContext.SaveChangesAsync();
                return Json(new
                {
                    status = 201
                });
            }
            else
            {
                var commentData = await dbContext.Commets
                    .Select(x => new { x.Id, x.BlogDetailsId })
                    .FirstOrDefaultAsync(dr => dr.Id == commentu.ParentId);
                if (commentData == null) return Json(new
                {
                    status = 404
                });

                commentu.BlogDetailsId = commentData.BlogDetailsId;
                commentu.Date = DateTime.Now;
                commentu.IsBlocked = false;
                commentu.ParentId = commentData.Id;

                await dbContext.Commets.AddAsync(commentu);
                await dbContext.SaveChangesAsync();
                return Json(new
                {
                    status = 201
                });
            }
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
                searchInfo.Users = await dbContext.User.Include(x => x.Blogs).Where(dr => dr.NormalizedUserName.Contains(info.ToUpper()))
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
            if (id == null) return RedirectToAction("Search");
            var blog = (await dbContext.Blogs.Include(x => x.User).FirstOrDefaultAsync(dr => dr.Id == id));
            if (blog == null) return RedirectToAction("Search");

            SearchVM searchInfo = new SearchVM
            {
                Popliar = await dbContext.Blogs
                .Include(x => x.User)
                .OrderByDescending(dr => dr.Id)
                .Take(5).ToListAsync(),
                User = blog.User,
                Blogs = await dbContext.Blogs
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> MessangeSend(MessengeUser messenge)
        {
            if (!ModelState.IsValid) return Json(new
            {
                status = 404
            });

            var user = await userManager.FindByIdAsync(messenge.UserId);
            if (user == null) return Json(new
            {
                status = 404
            });
            messenge.Date = DateTime.Now;
            messenge.IsRead = false;
            await dbContext.MessengeUsers.AddAsync(messenge);
            await dbContext.SaveChangesAsync();

            return Json(new
            {
                status = 201
            });
        }



    }
}
