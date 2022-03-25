using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParfolioWebSiteView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList;
using PagedList.Mvc;
using ParfolioWebSiteView.Areas.Admin.ViewModes;
using Microsoft.AspNetCore.Authorization;
using ParfolioWebSiteView.Areas.UserAdmin.ViewModels;
using ParfolioWebSiteView.Extensions;
using Microsoft.AspNetCore.Hosting;


namespace ParfolioWebSiteView.Areas.UserAdmin.Controllers
{
    [Authorize(Roles = "User")]
    [Area("UserAdmin")]
    public class BlogController : Controller
    {
        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;
        private readonly IWebHostEnvironment env;
        public BlogController(PorfolioDbContext _dbContext, UserManager<User> _userManager, IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            userManager = _userManager;
            env = _env;
        }

        public async Task<IActionResult> List()
        {
            var blog = await dbContext.Blogs.Where(dr => dr.User.UserName == User.Identity.Name)
                .Include(x => x.BlogDetails)
                .Include(x => x.BlogCategory)
                .Include(y => y.User)
                .ToListAsync();
            return View(blog);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.IsCreate = true;
            BlogVM blog = new BlogVM
            {
                CategoriesVM = await dbContext.BlogCategories.ToListAsync(),
                Tags = await dbContext.Tags.ToListAsync(),
                Blog = new Blog(),

            };
            blog.Blog.BlogDetails = new BlogDetails();
            return View(blog);
        }



    }
}
