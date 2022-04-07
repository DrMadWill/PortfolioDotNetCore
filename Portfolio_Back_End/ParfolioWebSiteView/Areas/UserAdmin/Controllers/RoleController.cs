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
using ParfolioWebSiteView.Areas.UserAdmin.ViewModes;
using Microsoft.AspNetCore.Authorization;
namespace ParfolioWebSiteView.Areas.UserAdmin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class RoleController : Controller
    {
        private readonly PorfolioDbContext dbContext;
        private readonly RoleManager<IdentityRole> roleManager;


        public RoleController(PorfolioDbContext _dbContext, RoleManager<IdentityRole> _roleManager)
        {
            dbContext = _dbContext;
            roleManager = _roleManager;
        }

        public async Task<IActionResult> List(int? id)
        {
            RoleListVM role = new RoleListVM
            {
                Roles = (await roleManager.Roles.ToListAsync()).ToPagedList(id ?? 1, 10),
                CurrentPage = id ?? 1
            };
            role.PagedCount(role.Roles.TotalItemCount, 10);
            return View(role);
        }

        [HttpGet]
        public IActionResult Create()
        {
            IdentityRole role = new IdentityRole();
            return View(role);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IdentityRole role)
        {

            if (string.IsNullOrEmpty(role.Name))
            {
                ModelState.AddModelError(string.Empty, "This Role Name required.");
                return View(role);
            }

            if (await roleManager.RoleExistsAsync(role.Name))
            {
                ModelState.AddModelError(string.Empty, "This Role Already Added.");
                return View(role);
            }
            await roleManager.CreateAsync(role);
            await dbContext.SaveChangesAsync();
            TempData["RoleAlert"] = role.Name + " .Role Created.";
            return Redirect("/Admin/Role/List");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string Id)
        {

            if (Id == null) return Redirect("/System/Error404");
            var role = await roleManager.FindByIdAsync(Id);
            if (role == null) return Redirect("/System/Error404");
            return View(role);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(IdentityRole role)
        {
            // Empty
            if (string.IsNullOrEmpty(role.Name))
            {
                ModelState.AddModelError(string.Empty, "This Role Name required.");
                return View(role);
            }

            // NotFound Id
            var roleDb = await roleManager.FindByIdAsync(role.Id);
            if (roleDb == null) return Redirect("/System/Error404");


            // Already Added
            var rol = await roleManager.Roles
                .FirstOrDefaultAsync(dr => dr.Id != role.Id && dr.Name == role.Name);
            if (rol != null)
            {
                ModelState.AddModelError(string.Empty, "This Role Already Added.");
                return View(role);
            }

            roleDb.Name = role.Name;

            var result = await roleManager.UpdateAsync(roleDb);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", result.Errors.First().ToString());
                return View();
            }

            TempData["RoleAlert"] = roleDb.Name + " .Role Update.";

            return Redirect("/Admin/Role/List");
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
            // Empty 
            if (id == null) return Redirect("/System/Error404");

            // Check Role
            var role = await roleManager.FindByIdAsync(id);
            if (role == null) return Redirect("/System/Error404");

            // Check Role To Users
            var roletoUser = await dbContext.UserRoles.FirstOrDefaultAsync(dr => dr.RoleId == role.Id);
            if (roletoUser != null) return Redirect("/System/Error404");
            // Delete
            var resault = await roleManager.DeleteAsync(role);
            if (!resault.Succeeded) return Redirect("/System/Error404");
            TempData["RoleAlert"] = role.Name + " .Role Deleted.";
            return Redirect("/Admin/Role/List");
        }


    }
}
