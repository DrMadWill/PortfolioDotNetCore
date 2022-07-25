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
    public class SettingsController : Controller
    {
        private readonly IWebHostEnvironment env;
        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;


        public SettingsController(PorfolioDbContext _dbContext, UserManager<User> _userManager, IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            userManager = _userManager;
            env = _env;
        }

        // Index GET
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            return View(user);
        }

        // Index POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(User user)
        {
            if (!ModelState.IsValid) return View(user);
            var userDb = await userManager.FindByNameAsync(User.Identity.Name);

            //  Error Time Image Null Reference
            string imf = userDb.Image;
            user.Image = imf;

            bool IsChangeEmailOrUserName = false;

            // Email Change
            if (userDb.Email != user.Email)
            {
                if (userManager.FindByEmailAsync(user.Email).Result == null)
                {
                    userDb.Email = user.Email;
                    IsChangeEmailOrUserName = true;
                }
                else
                {
                    ModelState.AddModelError("Email", "This Email Already Using");
                    return View(user);
                }
            }

            // UserName Change
            if (userDb.UserName != user.UserName)
            {
                if (userManager.FindByNameAsync(user.UserName).Result == null)
                {
                    userDb.UserName = user.UserName;
                    IsChangeEmailOrUserName = true;
                }
                else
                {
                    ModelState.AddModelError("UserName", "This UserName Already Using");
                    return View(user);
                }
            }

            // Potho Change
            if (user.Photo != null)
            {
                string folder = @"img\Profile";
                // Check Image Format
                if (!user.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Img forma not valid ");
                    return View(user);
                }

                // Default Image Don't Delete 
                if (userDb.Image == "profil.png")
                    userDb.Image = await user.Photo.PhotoSaveAsync(env.WebRootPath, folder);
                else
                {
                    string pothoName = await user.Photo.PhotoSaveAsync(env.WebRootPath, folder);
                    FileExtension.Delete(env.WebRootPath, folder, userDb.Image);
                    userDb.Image = pothoName;
                }
            }

            userDb.FirstName = user.FirstName;
            userDb.LastName = user.LastName;
            userDb.Gender = user.Gender;

            var resault = await userManager.UpdateAsync(userDb);
            if (!resault.Succeeded)
            {
                ModelState.AddModelError("UserName", resault.Errors.First().Description);
                return View(user);
            }
            await dbContext.SaveChangesAsync();

            ModelState.Clear();
            TempData["SettingAlert"] = userDb.UserName + " Changed";

            if (IsChangeEmailOrUserName)
                return Redirect("/Signin/LogOut");


            var userDbChanged = await userManager.FindByIdAsync(userDb.Id);
            return View(userDbChanged);
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
                {
                    TempData["SettingAlert"] = user.UserName + " Changed Password.";
                    return Redirect("/UserAdmin/Settings/Index");

                }

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
