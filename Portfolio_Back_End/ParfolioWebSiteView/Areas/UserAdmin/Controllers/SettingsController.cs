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
    public class SettingsController : Controller
    {

        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;


        public SettingsController(PorfolioDbContext _dbContext, UserManager<User> _userManager)
        {
            dbContext = _dbContext;
            userManager = _userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            return View(user);
        }

        // Change Password GET
        [HttpGet]
        public IActionResult ChangePassword()
        {
            ChangePasswordVM changePassword = new ChangePasswordVM();
            return View(changePassword);
        }

        // Change Password POST
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordVM changePassword)
        {
            if(!ModelState.IsValid) return View(changePassword);

            var user = await userManager.FindByNameAsync(User.Identity.Name);
            // Check Password IsValid
            var passwordValidator = new PasswordValidator<User>();
            var result = await passwordValidator.ValidateAsync(userManager, null, changePassword.NewPassword);

            if (result.Succeeded)
            {
                var resault = await userManager.ChangePasswordAsync(user, changePassword.CurrentPassword, changePassword.NewPassword);
                if (resault.Succeeded)
                    return Redirect("/UserAdmin/Settings/Index");

                ModelState.AddModelError("CurrentPassword", resault.Errors.First().Description);
            }
            else
            {
                ModelState.AddModelError("NewPassword", result.Errors.First().Description);
            }

            
            return View(changePassword);
        }

    }
}
