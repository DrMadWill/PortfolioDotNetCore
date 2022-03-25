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
    public class ReferanceController : Controller
    {
        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;
        private readonly IWebHostEnvironment env;
        public ReferanceController(PorfolioDbContext _dbContext, UserManager<User> _userManager, IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            userManager = _userManager;
            env = _env;
        }

        // List GET
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var refreance = await dbContext.Referances.Where(dr=>dr.User.UserName ==User.Identity.Name).ToListAsync();

            return View(refreance);
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.IsCreate = true;
            Referance referance = new Referance 
            { 
                UserId = (await userManager.FindByNameAsync(User.Identity.Name)).Id
            };
            return View(referance);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Referance referance)
        {
            ViewBag.IsCreate = true;
            if (!ModelState.IsValid) return View(referance);

            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if(user ==null ) return Redirect("/System/Error404");

            referance.UserId = user.Id;
            // User Referance Count Check
            var referanceCount = (await dbContext.Referances.Where(dr => dr.User.UserName == user.UserName).ToListAsync()).Count;
            if (referanceCount > 10)
            {
                TempData["ReferanceAlert"] = "Your Limit Referance 10";
                return Redirect("/UserAdmin/Portfolio/List");
            } 

            // Image Save
            if (referance.Photo != null)
            {
                string folder = @"img\Refreance";
                if (!referance.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Img forma bot valid ");
                    return View(referance);
                }
                referance.Image = await referance.Photo.PhotoSaveAsync(env.WebRootPath, folder);
            }
            else
            {
                ModelState.AddModelError("Photo", "Img is Required");
                return View(referance);
            }

            await dbContext.Referances.AddAsync(referance);
            await dbContext.SaveChangesAsync();

            TempData["ReferanceAlert"] = referance.Name + " Referance Created";
            return Redirect("/UserAdmin/Referance/List");
        }

    }
}
