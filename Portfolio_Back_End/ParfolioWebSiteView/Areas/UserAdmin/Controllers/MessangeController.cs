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

namespace ParfolioWebSiteView.Areas.UserAdmin.Controllers
{
    [Authorize(Roles = "User")]
    [Area("UserAdmin")]
    public class MessangeController : Controller
    {
        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;


        public MessangeController(PorfolioDbContext _dbContext, UserManager<User> _userManager)
        {
            dbContext = _dbContext;
            userManager = _userManager;
        }

        public async Task<IActionResult> List()
        {
            var messanges = await dbContext.MessengeUsers
                .Where(dr => dr.User.UserName == User.Identity.Name)
                .ToListAsync();

            return View(messanges);
        }

        public async Task<IActionResult> Show(int? id)
        {
            if (id == null) return Redirect("/System/Error404");
            var messange = await dbContext.MessengeUsers.FirstOrDefaultAsync(dr => dr.Id == id);
            if(messange ==null) return Redirect("/System/Error404");
            messange.IsRead = true;
            await dbContext.SaveChangesAsync();
            return View(messange);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return Redirect("/System/Error404");
            var messange = await dbContext.MessengeUsers.FirstOrDefaultAsync(dr => dr.Id == id);
            if (messange == null) return Redirect("/System/Error404");

            dbContext.MessengeUsers.Remove(messange);
            await dbContext.SaveChangesAsync();
            return Redirect("/UserAdmin/Messange/List");
        }

    }
}
