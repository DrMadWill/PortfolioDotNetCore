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
            var contact = await dbContext.Contacts.FirstOrDefaultAsync(dr => dr.IsShow);
            var about = await dbContext.Abouts.FirstOrDefaultAsync(dr => dr.IsShow);
            IndexVM index = new IndexVM
            {
                Home = await dbContext.Homes.FirstOrDefaultAsync(dr => dr.IsShow),
                Achievement = await dbContext.Achievements.FirstAsync(),
                About = about,
                SkillCode = await dbContext.SkillCodes.Where(dr=>dr.AboutId== about.Id).ToListAsync(),
                Skills = await dbContext.Skills.Where(dr => dr.AboutId == about.Id).ToListAsync(),
                Blogs = await dbContext.Blogs.ToListAsync(),
                Portfolios = await dbContext.Portfolios.ToListAsync(),
                Contact = contact,
                ContactOnlines = await dbContext.ContactOnlines.Where(dr=>dr.ContactId == contact.Id).ToListAsync(),
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
