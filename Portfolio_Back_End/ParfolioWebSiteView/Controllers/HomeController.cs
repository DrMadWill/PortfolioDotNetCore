using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ParfolioWebSiteView.Models;
using ParfolioWebSiteView.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using System.Threading.Tasks;

namespace ParfolioWebSiteView.Controllers
{
    public class HomeController : Controller
    {

        private readonly PorfolioDbContext dbContext;

        public HomeController(PorfolioDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IActionResult> Index()
        {
            
            IndexVM index = new IndexVM
            {
                Home = await dbContext.Homes.FirstOrDefaultAsync(dr => dr.IsShow),
                Achievements = await dbContext.Achievements.ToListAsync(),
                About = await dbContext.Abouts.Include(x=>x.Skills).Include(x=>x.SkillCodes).FirstOrDefaultAsync(dr => dr.IsShow),
                Blogs = await dbContext.Blogs.Include(x=>x.BlogCategory).ToListAsync(),
                Portfolios = await dbContext.Portfolios.Include(x=>x.PortfolioCategory).ToListAsync(),
                Contact = await dbContext.Contacts.Include(c=>c.ContactOnlines).FirstOrDefaultAsync(dr => dr.IsShow),
                Services = await dbContext.Services.ToListAsync(),
                Referances = await dbContext.Referances.ToListAsync()
            };

            

            ViewBag.ImageData = PartfolioImages.AllImage();
            ViewBag.WorkImage = PartfolioImages.WorkImage();
            ViewBag.Testimonials = PartfolioImages.Testimonials();
            ViewBag.PartfolioServices = PartfolioImages.PartfolioServices();
            return View(index);
        }

        public IActionResult SinglePage()
        {
            return View();
        }

        public IActionResult PortfolioSinglePage()
        {
            return View();
        }

        public IActionResult PortfolioDetails()
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
