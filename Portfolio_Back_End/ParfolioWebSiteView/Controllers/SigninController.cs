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

        public async Task<IActionResult> Login()
        {


            return View();
        }



    }
}
