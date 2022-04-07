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
using Microsoft.AspNetCore.Authorization;
using ParfolioWebSiteView.Areas.UserAdmin.ViewModels;

namespace ParfolioWebSiteView.Areas.UserAdmin.Controllers
{
    [Authorize(Roles = "User")]
    [Area("UserAdmin")]
    public class AboutController : Controller
    {
        private readonly PorfolioDbContext dbContext;

        public AboutController(PorfolioDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Update()
        {
            var about = await dbContext.Abouts.FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name);
            if(about == null) return Redirect("/System/Error404");
           
            return View(about);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(About about)
        {
            if (!ModelState.IsValid) return Redirect("/System/Error404");
            // Find About
            var aboutDB = await dbContext.Abouts.FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name);
            if(aboutDB==null) return Redirect("/System/Error404");
            aboutDB.MainSkill = about.MainSkill;
            aboutDB.Descriptoion = about.Descriptoion;
            await dbContext.SaveChangesAsync();


            return Redirect("/UserAdmin/UserAccount/Account");
        }
    }
}
