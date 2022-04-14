
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParfolioWebSiteView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.ViewComponents
{
    public class TopBlogViewComponent : ViewComponent
    {
        private readonly PorfolioDbContext _dbContext;

        public TopBlogViewComponent(PorfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string defaultUserName = "DrMadWill";
            defaultUserName = defaultUserName.ToUpper();
            var blogs = await _dbContext.Blogs.Where(dr => dr.User.NormalizedUserName == defaultUserName).OrderByDescending(s=>s.Date).Take(5).ToListAsync();
            return View(blogs);
        }
    }
}
