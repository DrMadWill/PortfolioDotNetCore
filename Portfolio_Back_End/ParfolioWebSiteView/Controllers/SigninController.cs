using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParfolioWebSiteView.Areas.Admin.ViewModes;
using ParfolioWebSiteView.Models;
using ParfolioWebSiteView.Extensions;
using System;
using PagedList;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using ParfolioWebSiteView.ViewModels;

namespace ParfolioWebSiteView.Controllers
{
    public class SigninController : Controller
    {
        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<User> signInManager;

        public SigninController(PorfolioDbContext _dbContext, UserManager<User> _userManager,
                                RoleManager<IdentityRole> _roleManager,
                                SignInManager<User> _signInManager)
        {
            dbContext = _dbContext;
            userManager = _userManager;
            roleManager = _roleManager;
            signInManager = _signInManager;
        }



        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.IsShowing = false;
            SignInVM signIn = new SignInVM();

            return View(signIn);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(SignInVM signIn)
        {
            ViewBag.IsShowing = false;
            if (!ModelState.IsValid) return View(signIn);

            var user = await userManager.FindByEmailAsync(signIn.Email);
            if(user==null)
            {
                ViewBag.IsShowing = true;
                ModelState.AddModelError("Email", "Email is Wrong!");
                return View(signIn);
            }

            var resault = await signInManager.PasswordSignInAsync(user, signIn.Password, signIn.RememberMe, false);
            if (resault.Succeeded)
                return Redirect("/Admin/Account/List");

            ViewBag.IsShowing = true;
            ModelState.AddModelError("Password", "Password Wrong!");
            return View(signIn);
        }

        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.IsShowing = false;
            SignUpVM sign = new SignUpVM();
            return View(sign);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(SignUpVM sign)
        {

            ViewBag.IsShowing = false;
            if (!ModelState.IsValid) return View(sign);

            // Check User Name Unique 
            var userTest = await userManager.FindByNameAsync(sign.UserName);
            if (userTest != null)
            {
                ViewBag.IsShowing = true;
                ModelState.AddModelError("User", "User Name Already Used.");
                return View(sign);
            }


            // Ckeck Password Usable
            var passwordValidator = new PasswordValidator<User>();
            var result = await passwordValidator.ValidateAsync(userManager, null, sign.Password);
            if (!result.Succeeded)
            {
                ViewBag.IsShowing = true;
                foreach (var item in result.Errors)
                    ModelState.AddModelError("User", item.Description);
                return View(sign);
            }


            // Check Email Unique And Anouther Opertion
            if (userManager.FindByEmailAsync(sign.Email).Result == null)
            {
                User user = new User
                {
                    Image = "profil.png",
                    Email = sign.Email,
                    FirstName = sign.FirstName,
                    LastName = sign.LastName,
                    UserName = sign.UserName,
                    Gender = sign.Gender
                };
                IdentityResult resault = await userManager.CreateAsync(user, sign.Password);
                if (resault.Succeeded)
                {
                    await userManager.AddToRoleAsync(user,role:"User");
                    await dbContext.SaveChangesAsync();
                    await signInManager.SignInAsync(user, true);
                    return Redirect("/Admin/Account/List");
                }
            }
            else
            {
                ViewBag.IsShowing = true;
                ModelState.AddModelError("Email Error", "This Email Already Using");
                return View(sign);

            }
            ViewBag.IsShowing = true;
            ModelState.AddModelError("Error", "Sorry. Account Not Created.");
            return View(sign);
        }


        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return Redirect("/Admin/Account/Login");
        }
    }
}
