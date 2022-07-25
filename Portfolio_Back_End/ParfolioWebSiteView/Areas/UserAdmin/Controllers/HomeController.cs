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
using ParfolioWebSiteView.Extensions;
using Microsoft.AspNetCore.Hosting;

namespace ParfolioWebSiteView.Areas.UserAdmin.Controllers
{
    [Authorize(Roles = "User")]
    [Area("UserAdmin")]
    public class HomeController : Controller
    {
        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;
        private readonly IWebHostEnvironment env;
        public HomeController(PorfolioDbContext _dbContext, UserManager<User> _userManager,IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            userManager = _userManager;
            env = _env;
        }

       [HttpGet]
        public async Task<IActionResult> Update()
        {
            var home = await dbContext.Homes.FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name);
            if(home == null) return Redirect("/System/Error404");

            return View(home);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Home home)
        {
            if (!ModelState.IsValid) return View(home);

            var homeDb = await dbContext.Homes.FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name);
            homeDb.HomeSlogan = home.HomeSlogan;
            homeDb.Skills = home.Skills;

            // image Check
            if(home.Potho != null)
            {
                if (!home.Potho.IsImage())
                {
                    ModelState.AddModelError("Potho", "Img forma not valid ");
                    return View(home);
                }
                string folder = @"img\Home";

                // Default Image Don't Delete 
                if (homeDb.Image == "image.jpg")
                    homeDb.Image = await home.Potho.PhotoSaveAsync(env.WebRootPath, folder);
                else
                {
                    string pothoName = await home.Potho.PhotoSaveAsync(env.WebRootPath, folder);
                    FileExtension.Delete(env.WebRootPath, folder, homeDb.Image);
                    homeDb.Image = pothoName;
                }
            }



            dbContext.Update(homeDb);
            await dbContext.SaveChangesAsync();

            return Redirect("/UserAdmin/UserAccount/Account");
        }


    }
}
