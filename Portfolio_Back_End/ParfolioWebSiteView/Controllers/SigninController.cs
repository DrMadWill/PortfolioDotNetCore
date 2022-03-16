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
using System.IO;

namespace ParfolioWebSiteView.Controllers
{
    public class SigninController : Controller
    {
        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<User> signInManager;
        private readonly IEmailService emailService;
        public SigninController(PorfolioDbContext _dbContext, UserManager<User> _userManager,
                                RoleManager<IdentityRole> _roleManager,
                                SignInManager<User> _signInManager,IEmailService _emailService)
        {
            dbContext = _dbContext;
            userManager = _userManager;
            roleManager = _roleManager;
            signInManager = _signInManager;
            emailService = _emailService;
        }


        // ======================= Login ============
        // Login Get
        [HttpGet]
        public IActionResult Login()
        {
            SignInVM signIn = new SignInVM();

            return View(signIn);
        }

        // Login Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(SignInVM signIn)
        {
            
            if (!ModelState.IsValid) return View(signIn);
            // Check User 
            var user = await userManager.FindByEmailAsync(signIn.Email);
            if(user==null)
            {
                ModelState.AddModelError("Email", "Email is Wrong!");
                return View(signIn);
            }
            // Check Pass 
            var resault = await signInManager.PasswordSignInAsync(user, signIn.Password, signIn.RememberMe, false);
            if (resault.Succeeded)
                return Redirect("/Admin/Account/List");

            ViewBag.IsShowing = true;
            ModelState.AddModelError("Password", "Password Wrong!");
            return View(signIn);
        }

        // ======================= Register ============
        // Register GET
        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.IsShowing = false;
            SignUpVM sign = new SignUpVM();
            return View(sign);
        }

        // Register Post
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

        // ======================== Logout ======================
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return Redirect("/");
        }

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            ForgetPasswordVM forgetPassword = new ForgetPasswordVM();
            return View(forgetPassword);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordVM forgetPassword)
        {
            if (!ModelState.IsValid) return View(forgetPassword);

            var user = await userManager.FindByEmailAsync(forgetPassword.Email);
            if(user == null)
            {
                ModelState.AddModelError("Email", "Don't Find This Email.");
                return View(forgetPassword);
            }

            string token = await userManager.GeneratePasswordResetTokenAsync(user);
            string url = Url.Action("ResetPassword", "Signin", new { token,email=user.Email },Request.Scheme);

            string body = string.Empty;
            using (StreamReader reader = new StreamReader("wwwroot/templates/forgetpasswod.html"))
                body = reader.ReadToEnd();

            body = body.Replace("{{url}}", url);

            emailService.Send(user.Email, "Reset Password", body);

            return Redirect("/");

            //ModelState.AddModelError("Email", "Don't Find This Email");
            //return View(forgetPassword);
        }

        [HttpGet]
        public IActionResult ResetPassword(string token,string email)
        {
            if(string.IsNullOrEmpty(token) || string.IsNullOrEmpty(email)) return Redirect("/System/Error404");
            ResetPasswordVM resetPassword = new ResetPasswordVM
            {
                Token = token,
                Email = email
            };
            return View(resetPassword);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPassword)
        {
            if (!ModelState.IsValid) return View(resetPassword);

            // Check User 
            var user = await userManager.FindByEmailAsync(resetPassword.Email);
            if (user == null) return Redirect("/System/Error404"); 

            // Ckeck Password Usable
            var passwordValidator = new PasswordValidator<User>();
            var result = await passwordValidator.ValidateAsync(userManager, null, resetPassword.Password);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("Password", result.Errors.First().Description);
                return View(resetPassword);
            }

            var resault = await userManager.ResetPasswordAsync(user, resetPassword.Token, resetPassword.Password);

            if (resault.Succeeded)
            {
                return Redirect("/");
            }
            ModelState.AddModelError("Password", "We Have Some Problem");
            return View(resetPassword);
        }
    }
}
