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
using ParfolioWebSiteView.Areas.UserAdmin.Data;

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
            var messange = await dbContext.MessengeUsers.FirstOrDefaultAsync(dr => dr.Id == id && dr.User.UserName==User.Identity.Name);
            if(messange ==null) return Redirect("/System/Error404");
            if(messange.IsRead == false){
                messange.IsRead = true;
                await dbContext.SaveChangesAsync();
            }
            return View(messange);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return Redirect("/System/Error404");

            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return Redirect("/System/Error404");

            var messange = await dbContext.MessengeUsers.FirstOrDefaultAsync(dr => dr.Id == id);
            if (messange == null) return Redirect("/System/Error404");

            dbContext.MessengeUsers.Remove(messange);
            await dbContext.SaveChangesAsync();
            return Redirect("/UserAdmin/Messange/List");
        }

    }
}
