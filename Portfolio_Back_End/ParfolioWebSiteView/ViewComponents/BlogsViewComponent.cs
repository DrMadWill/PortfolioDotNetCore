using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParfolioWebSiteView.Models;
using ParfolioWebSiteView.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.ViewComponents
{
    public class BlogsViewComponent : ViewComponent
    {


        private readonly PorfolioDbContext _dbContext;

        public BlogsViewComponent(PorfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var blog = await _dbContext.Blogs.Include(x=>x.User).FirstOrDefaultAsync(dr => dr.Id == id);
            BlogVCM blogs = new BlogVCM
            {
                Blog = blog,
                Blogs = await _dbContext.Blogs.Where(dr => dr.UserId == blog.UserId).ToListAsync()
            };

            return View(blogs);
        }
    }
}
