﻿using Microsoft.AspNetCore.Mvc;
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

        public HomeController(PorfolioDbContext _dbContext,UserManager<User> _userManager)
        {
            dbContext = _dbContext;
            userManager = _userManager;
        }

        public async Task<IActionResult> Index(string id)
        {
            string username = id;
            User user = null;
            if (string.IsNullOrEmpty(username))
            {
                user = await userManager.FindByNameAsync("DrMadWill");
            }
            else
            {
                user = await userManager.FindByNameAsync(username);
                if (user == null) return NotFound();
            }

            var data = await dbContext.User
                .Include(h => h.Home)
                .Include(a => a.About).Include(sk => sk.About.Skills).Include(x => x.About.SkillCodes)
                .Include(ac => ac.Achievements)
                .Include(c=>c.Contact).Include(c => c.Contact.ContactOnlines)
                .Include(s=>s.Services)
                .Include(r=>r.Referances)
                .FirstOrDefaultAsync(dr=>dr.Id== user.Id);

            data.BlogsVM = await dbContext.Blogs
                .Where(dr => dr.UserId == user.Id).Include(x => x.BlogCategory).ToListAsync();
            data.PortfoliosVM = await dbContext.Portfolios
                .Where(dr => dr.UserId == user.Id).Include(x => x.PortfolioCategory).ToListAsync();
            return View(data);
        }

        public async Task<IActionResult> SinglePage(int? id)
        {
            if (id == null) return NotFound();
            var blog = await dbContext.Blogs.FirstOrDefaultAsync(dr => dr.Id == id);
            


            return View();
        }

        public async Task<IActionResult> PortfolioSinglePage(int? id)
        {
            if (id == null) return NotFound();
            var portfolio = await dbContext.Portfolios
                .Include(x => x.PortfolioCategory)
                .Include(s=>s.User)
                .Include(x => x.PortfolioDetail)
                .ThenInclude(x => x.DetailImages)
                .FirstOrDefaultAsync(dr => dr.Id == id);
            if (portfolio == null) NotFound();
            return View(portfolio);
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
