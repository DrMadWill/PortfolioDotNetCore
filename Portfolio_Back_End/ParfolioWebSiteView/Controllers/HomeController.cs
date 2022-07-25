using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ParfolioWebSiteView.Models;
using ParfolioWebSiteView.ViewModels;
using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using System.Threading.Tasks;

namespace ParfolioWebSiteView.Controllers
{
    public class HomeController : Controller
    {

        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;

        public HomeController(PorfolioDbContext _dbContext, UserManager<User> _userManager)
        {
            dbContext = _dbContext;
            userManager = _userManager;
        }
        public async Task<IActionResult> Index(string id)
        {
            string username = id;
            User user = null;
            if (string.IsNullOrEmpty(username))
                user = await userManager.FindByNameAsync("DrMadWill");
            else
            {
                user = await userManager.FindByNameAsync(username);
                if (user == null) return NotFound();
            }

            IndexVM index = new IndexVM
            {
                User = await dbContext.User
                .Include(h => h.Home)
                .Include(a => a.About).Include(x => x.About.SkillCodes)
                .Include(ac => ac.Achievements)
                .Include(c => c.Contact).Include(c => c.Contact.ContactOnlines)
                .Include(s => s.Services)
                .Include(r => r.Referances)
                .FirstOrDefaultAsync(dr => dr.Id == user.Id),
                Blogs = await dbContext.Blogs
                .Where(dr => dr.UserId == user.Id)
                .Include(x => x.BlogCategory)
                .Take(9)
                .OrderByDescending(x => x.Id)
                .ToListAsync(),
                Portfolios = await dbContext.Portfolios
                .Where(dr => dr.UserId == user.Id)
                .Include(x => x.PortfolioCategory)
                .Take(9)
                .OrderByDescending(x => x.Id)
                .ToListAsync()
            };

            return View(index);
        }


        public async Task<IActionResult> SinglePage(int? id)
        {
            if (id == null) return NotFound();

            var blog = await dbContext.Blogs
                .Include(x => x.BlogDetails)
                .Include(x => x.BlogCategory)
                .Include(y => y.User)
                .FirstOrDefaultAsync(dr => dr.Id == id);

            BlogVM blogVM = new BlogVM
            {
                Blog = blog,
                // Comment Section
                CommentCount = await dbContext.Commets
                    .Where(dr => dr.BlogDetailsId == id
                    && dr.IsBlocked == false).CountAsync(),
                Commets = await dbContext.Commets
                    .Include(x => x.User)
                    .Where(dr => dr.BlogDetailsId == id 
                            && dr.IsBlocked == false 
                            && dr.ParentId == null)
                    .Take(5).ToListAsync(),

                Tags = await dbContext.BlogToTags
                .Where(dr => dr.BlogId == blog.Id)
                .Select(x => x.Tag)
                .ToListAsync(),
            };

            return View(blogVM);
        }

        public async Task<IActionResult> PortfolioSinglePage(int? id)
        {
            if (id == null) return NotFound();
            var portfolio = await dbContext.Portfolios
                .Include(x => x.PortfolioCategory)
                .Include(s => s.User)
                .Include(x => x.PortfolioDetail)
                .ThenInclude(x => x.DetailImages)
                .FirstOrDefaultAsync(dr => dr.Id == id);
            if (portfolio == null) NotFound();
            return View(portfolio);
        }

        public IActionResult Policies()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
