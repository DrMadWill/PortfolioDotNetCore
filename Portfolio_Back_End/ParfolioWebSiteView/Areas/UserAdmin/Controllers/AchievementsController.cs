using Microsoft.AspNetCore.Mvc;
using ParfolioWebSiteView.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace ParfolioWebSiteView.Areas.UserAdmin.Controllers
{
    [Authorize(Roles = "User")]
    [Area("UserAdmin")]
    public class AchievementsController : Controller
    {
        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;
        public AchievementsController(PorfolioDbContext _dbContext, UserManager<User> _userManager)
        {
            dbContext = _dbContext;
            userManager = _userManager;
        }
        public async Task<IActionResult> List()
        {
            var achievements = await dbContext.Achievements
                .Where(dr => dr.User.UserName == User.Identity.Name)
                .ToListAsync();
            return View(achievements);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.IsCreate = true;
            Achievements achievements = new Achievements
            {
                UserId = (await userManager.FindByNameAsync(User.Identity.Name)).Id
            };
            return View(achievements);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Achievements achievements)
        {
            ViewBag.IsCreate = true;
            if (!ModelState.IsValid) return View(achievements);
            // Check serviece added
            var achievementsTesting = await dbContext.Achievements
                .FirstOrDefaultAsync(dr => dr.Name == achievements.Name
                && dr.User.UserName == User.Identity.Name);
            if (achievementsTesting != null)
            {
                ModelState.AddModelError("Name", "This Name Already Add");
                return View(achievements);
            }
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return Redirect("/Singin/Login");
            achievements.UserId = user.Id;

            var acivmentCount = (await dbContext.Achievements
                .Where(dr => dr.UserId == user.Id).ToListAsync()).Count;

            if(acivmentCount > 6)
            {
                TempData["AchievementsAlert"] = "Not Added Achievement. Your Achievement Limit 9";
                return Redirect("/UserAdmin/Achievements/List");
            }

            await dbContext.Achievements.AddAsync(achievements);
            await dbContext.SaveChangesAsync();
            TempData["AchievementsAlert"] = achievements.Name + " Achievement Created";
            return Redirect("/UserAdmin/Achievements/List");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            ViewBag.IsCreate = false;
            var achievements = await dbContext.Achievements.FirstOrDefaultAsync(dr => dr.Id == id &&
            dr.User.UserName == User.Identity.Name);
            return View("Create", achievements);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Achievements achievements)
        {
            ViewBag.IsCreate = false;

            if (!ModelState.IsValid) return View("Create", achievements);

            var user = await userManager.FindByNameAsync(User.Identity.Name);

            // Check serviece added
            var achievementsTesting = await dbContext.Achievements
                .FirstOrDefaultAsync(dr => dr.Name == achievements.Name
                && dr.UserId == user.Id && dr.Id != achievements.Id);

            if (achievementsTesting != null)
            {
                ModelState.AddModelError("Name", "This Name Already Add");
                return View(achievements);
            }

            var achievementsDb = await dbContext.Achievements.FirstOrDefaultAsync(dr => dr.Id == achievements.Id
            && achievements.UserId == user.Id);
            if (achievementsDb == null) return Redirect("/System/Error404");

            achievementsDb.Name = achievements.Name;
            achievementsDb.Icon = achievements.Icon;
            achievementsDb.Count = achievements.Count;
            await dbContext.SaveChangesAsync();
            TempData["AchievementsAlert"] = achievementsDb.Name + " Achievements Updated";
            return Redirect("/UserAdmin/Achievements/List");
        }


        public async Task<IActionResult> Delete(int? id)
        {
            var achievements = await dbContext.Achievements.FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name &&
           dr.Id == id);
            if (achievements == null) return Redirect("/System/Error404");
            dbContext.Achievements.Remove(achievements);
            await dbContext.SaveChangesAsync();
            TempData["AchievementsAlert"] = achievements.Name + " Achievements Deleted";
            return Redirect("/UserAdmin/Achievements/List");
        }

    }
}
