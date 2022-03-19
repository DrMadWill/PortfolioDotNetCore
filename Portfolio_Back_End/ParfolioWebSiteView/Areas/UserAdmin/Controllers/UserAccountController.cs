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
    public class UserAccountController : Controller
    {

        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;


        public UserAccountController(PorfolioDbContext _dbContext, UserManager<User> _userManager)
        {
            dbContext = _dbContext;
            userManager = _userManager;
        }

        public async Task<IActionResult> Account()
        {
            if (!User.Identity.IsAuthenticated) return Redirect("/");
            var user = await userManager.FindByNameAsync(User.Identity.Name);

            AccountVM acc = new AccountVM
            {
                Home = await dbContext.Homes.FirstOrDefaultAsync(dr => dr.Id == user.Id),
                About = await dbContext
                .Abouts.Include(x=>x.SkillCodes)
                .Include(x=>x.Skills)
                .FirstOrDefaultAsync(dr => dr.Id == user.Id),
                Contact = await dbContext.Contacts
                .Include(x=>x.ContactOnlines)
                .FirstOrDefaultAsync(dr => dr.Id == user.Id)
            };
            return View(acc);
        }

        public async Task<JsonResult> ContactOnlineCreate (string connectId,string icon,string url,string name)
        {



            return Json(new { 
                status=200
            });
        }


    }
}
