using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParfolioWebSiteView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<User> signInManager;


        public AccountController(PorfolioDbContext _dbContext, UserManager<User> _userManager,
            RoleManager<IdentityRole> _roleManager, SignInManager<User> _signInManager)
        {
            dbContext = _dbContext;
            userManager = _userManager;
            roleManager = _roleManager;
            signInManager = _signInManager;
        }

        public async Task<IActionResult> List()
        {
            var users = await userManager.Users.ToListAsync();

            return View(users);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Updare()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        //{
        //    if (!await roleManager.RoleExistsAsync(roleName: RoleName.Admin.ToString()))
        //    {
        //        await roleManager.CreateAsync(new IdentityRole(roleName: RoleName.Admin.ToString()));
        //    }
        //}


        //public async Task SeedUser()
        //{
        //    if (userManager.FindByEmailAsync("uguradvert@gmail.com").Result == null)
        //    {
        //        IdentityUser identity = new IdentityUser()
        //        {
        //            UserName = "UgurMG",
        //            Email = "uguradvert@gmail.com"
        //        };
        //        IdentityResult resault = await userManager.CreateAsync(identity, "2017ae2019elayA");
        //        if (resault.Succeeded)
        //        {
        //            await userManager.AddToRoleAsync(identity, RoleName.Admin.ToString());
        //            await dbContext.SaveChangesAsync();
        //            await signInManager.SignInAsync(identity, true);
        //        }
        //    }
        //}

    }
}
