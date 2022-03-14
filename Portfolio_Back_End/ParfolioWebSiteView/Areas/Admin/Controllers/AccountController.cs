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

namespace ParfolioWebSiteView.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<User> signInManager;
        private readonly IWebHostEnvironment env;

        public AccountController(PorfolioDbContext _dbContext, UserManager<User> _userManager,
            RoleManager<IdentityRole> _roleManager, SignInManager<User> _signInManager, IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            userManager = _userManager;
            roleManager = _roleManager;
            signInManager = _signInManager;
            env = _env;
        }

        public async Task<IActionResult> List(int? id)
        {
            var users = await dbContext.UserRoles.ToListAsync();

            UserListVM userList = new UserListVM
            {
                Users = (await userManager.Users.ToListAsync()).ToPagedList(id ?? 1, 10),
                CurrentPage = id ?? 1,
                Roles = await roleManager.Roles.ToListAsync(),
                UserRoles = await dbContext.UserRoles.ToListAsync()
            };
            userList.PagedCount(userList.Users.TotalItemCount, 10);
            return View(userList);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            User_CU_VM user_CU = new User_CU_VM
            {
                Roles = await dbContext.Roles.ToListAsync()
            };

            return View(user_CU);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User_CU_VM user_CU)
        {
            if (!ModelState.IsValid)
            {
                user_CU.Roles = await dbContext.Roles.ToListAsync();
                return View(user_CU);
            }

            // Password  IsNullOrEmpty
            if (string.IsNullOrEmpty(user_CU.Password))
            {
                user_CU.Roles = await dbContext.Roles.ToListAsync();
                ModelState.AddModelError("User", "Password is required.");
                return View(user_CU);
            }

            // ConfirmPassword  IsNullOrEmpty
            if (string.IsNullOrEmpty(user_CU.ConfirmPassword))
            {
                user_CU.Roles = await dbContext.Roles.ToListAsync();
                ModelState.AddModelError("User", "ConfirmPassword is required.");
                return View(user_CU);
            }

            // Check User Name Unique 
            var userTest = await userManager.FindByNameAsync(user_CU.UserName);
            if (userTest != null)
            {
                user_CU.Roles = await dbContext.Roles.ToListAsync();
                ModelState.AddModelError("User", "User Name Already Used.");
                return View(user_CU);
            }

            // Check Email Unique And Anouther Opertion
            if (userManager.FindByEmailAsync(user_CU.Email).Result == null)
            {
                User user = new User();

                // Image Upload
                string folder = @"img\Profile";
                bool isDelete = true;
                if (user_CU.Photo != null)
                {
                    if (!user_CU.Photo.IsImage())
                    {
                        user_CU.Roles = await dbContext.Roles.ToListAsync();
                        ModelState.AddModelError("Photo", "Img forma bot valid ");
                        return View(user_CU);
                    }
                    user.Image = await user_CU.Photo.PhotoSaveAsync(env.WebRootPath, folder);
                }
                else
                {
                    user.Image = "profil.png";
                    isDelete = false;
                }
                    

                user.Email = user_CU.Email;
                user.FirstName = user_CU.FirstName;
                user.LastName = user_CU.LastName;
                user.UserName = user_CU.UserName;
                user.Gender = user_CU.Gender;

                IdentityResult resault = await userManager.CreateAsync(user, user_CU.Password);
                if (resault.Succeeded)
                {
                    foreach (var item in user_CU.RolIds)
                    {
                        var roles = await roleManager.FindByIdAsync(item);
                        await userManager.AddToRoleAsync(user, roles.Name);
                    }

                    await dbContext.SaveChangesAsync();
                    await signInManager.SignInAsync(user, true);
                    // Messenge List
                    TempData["UserAlert"] = user.UserName + " User Create";
                    return Redirect("/Admin/Account/List");
                }
                if (isDelete)
                    FileExtension.Delete(env.WebRootPath, folder, user.Image);
                foreach (var item in resault.Errors)
                    ModelState.AddModelError("Photo", item.Description);

                
            }
            else
                ModelState.AddModelError("Photo", "This Email Already Using");

            user_CU.Roles = await dbContext.Roles.ToListAsync();
            return View(user_CU);
        }

        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            if(string.IsNullOrEmpty(id)) return Redirect("/System/Error404");

            var user = await userManager.FindByIdAsync(id);
            if(user == null) return Redirect("/System/Error404");

            User_CU_VM user_CU = new User_CU_VM
            {
                Id = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Image = user.Image,
                Gender = user.Gender,
                Email = user.Email,
                Roles = await roleManager.Roles.ToListAsync(),
                RolIds = await dbContext.UserRoles.Where(dr=>dr.UserId==user.Id).Select(x => x.RoleId).ToListAsync()
            };
            return View(user_CU);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(User_CU_VM user_CU)
        {
            if (string.IsNullOrEmpty(user_CU.Id)) return Redirect("/System/Error404");

            if (!ModelState.IsValid)
            {
                user_CU.Roles = await roleManager.Roles.ToListAsync();
                return View(user_CU);
            }
            // Find User
            var userDb = await userManager.FindByIdAsync(user_CU.Id);
            if (userDb == null)
            {
                ModelState.AddModelError("User", "User Name Already Used.");
                user_CU.Roles = await roleManager.Roles.ToListAsync();
                return View(user_CU);
            }

            // Email Change
            if (userDb.Email != user_CU.Email)
            {
                if (userManager.FindByEmailAsync(user_CU.Email).Result == null)
                    userDb.Email = user_CU.Email;
                else
                {
                    ModelState.AddModelError("Photo", "This Email Already Using");
                    user_CU.Roles = await dbContext.Roles.ToListAsync();
                    return View(user_CU);
                }
            }

            // UserName Change
            if (userDb.UserName != user_CU.UserName)
            {
                if (userManager.FindByNameAsync(user_CU.UserName).Result == null)
                    userDb.UserName = user_CU.UserName;
                else
                {
                    ModelState.AddModelError("Photo", "This UserName Already Using");
                    user_CU.Roles = await dbContext.Roles.ToListAsync();
                    return View(user_CU);
                }
            }

            //Password Change
            if (!string.IsNullOrEmpty(user_CU.Password))
            {

                // ConfirmPassword  IsNullOrEmpty
                if (string.IsNullOrEmpty(user_CU.ConfirmPassword))
                {
                    user_CU.Roles = await dbContext.Roles.ToListAsync();
                    ModelState.AddModelError("User", "ConfirmPassword is required.");
                    return View(user_CU);
                }

                var passwordValidator = new PasswordValidator<User>();
                var result = await passwordValidator.ValidateAsync(userManager, null, user_CU.Password);

                if (result.Succeeded)
                {
                    // Remove Password 
                    await userManager.RemovePasswordAsync(userDb);

                    // Add New Password
                    await userManager.AddPasswordAsync(userDb,user_CU.Password);
                }
                else
                {
                    foreach (var item in result.Errors)
                        ModelState.AddModelError("User", item.Description);

                    user_CU.Roles = await dbContext.Roles.ToListAsync();
                    return View(user_CU);
                }

            }
            
            // Potho Change
            if (user_CU.Photo != null)
            {
                string folder = @"img\Profile";
                // Check Image Format
                if (!user_CU.Photo.IsImage())
                {
                    user_CU.Roles = await dbContext.Roles.ToListAsync();
                    ModelState.AddModelError("Photo", "Img forma bot valid ");
                    return View(user_CU);
                }

                // Default Image Don't Delete 
                if (userDb.Image == "profil.png")
                    userDb.Image = await user_CU.Photo.PhotoSaveAsync(env.WebRootPath, folder);
                else
                {
                    string pothoName = await user_CU.Photo.PhotoSaveAsync(env.WebRootPath, folder);
                    FileExtension.Delete(env.WebRootPath, folder, userDb.Image);
                    userDb.Image = pothoName;
                }

                
            }

            userDb.FirstName = user_CU.FirstName;
            userDb.LastName = user_CU.LastName;
            userDb.Gender = user_CU.Gender;
            var userToRoles = await dbContext.UserRoles
                .Where(dr => dr.UserId == userDb.Id).Select(d => d.RoleId).ToListAsync();

            // Role Change
            if(userToRoles != user_CU.RolIds)
            {
                foreach (var item in userToRoles)
                {
                    var roleName = (await roleManager.FindByIdAsync(item)).Name;
                    await userManager.RemoveFromRoleAsync(userDb, roleName);

                }

                foreach (var item in user_CU.RolIds)
                {
                    var roles = await roleManager.FindByIdAsync(item);
                    await userManager.AddToRoleAsync(userDb, roles.Name);
                }
            }

            
            var resault = await userManager.UpdateAsync(userDb);
            if (!resault.Succeeded)
            {
                user_CU.Roles = await dbContext.Roles.ToListAsync();
                foreach (var item in resault.Errors)
                {
                    ModelState.AddModelError("Error", item.Description);
                }
                return View(user_CU);
            }
            await dbContext.SaveChangesAsync();
            // Messenge List
            TempData["UserAlert"] = userDb.UserName + " User Update";
            return Redirect("/Admin/Account/List");

        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
            if(string.IsNullOrEmpty(id))  return Redirect("/System/Error404");
            // Find User
            var user = await userManager.FindByIdAsync(id);
            if(user ==null) return Redirect("/System/Error404");
            
            // All Role Delete
            var userToRole = await dbContext.UserRoles.Where(dr => dr.UserId == user.Id).Select(x=>x.RoleId).ToListAsync();
            foreach (var item in userToRole)
            {
                var roleName = (await roleManager.FindByIdAsync(item)).Name;
                await userManager.RemoveFromRoleAsync(user, roleName);
            }
            // User Delete
            var resault = await userManager.DeleteAsync(user);
            if (!resault.Succeeded)
            {
                TempData["UserAlert"] ="User Not Deleted.Becouse :" + resault.Errors.First().Description;
                return Redirect("/Admin/Account/List");
            }
            // Messenge List
            TempData["UserAlert"] = user.UserName + " User Deleted.";
            return Redirect("/Admin/Account/List");
        }
    }
}
