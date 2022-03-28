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
                .FirstOrDefaultAsync(   dr => dr.Id == user.Id),
                Contact = await dbContext.Contacts
                .Include(x=>x.ContactOnlines)
                .FirstOrDefaultAsync(dr => dr.Id == user.Id)
            };
            return View(acc);
        }


        // ========================= Contact Section ================= 

        [HttpGet]
        public async Task<IActionResult> ContactCreate() 
        {

            var user = await userManager.FindByNameAsync(User.Identity.Name);
            // One To One => User To Contact
            var contactDbTest = await dbContext.Contacts.FirstOrDefaultAsync(dr => dr.Id == user.Id);
            //Check Contact
            if(contactDbTest != null) return Redirect("/System/Error404");

            // Create Model
            ViewBag.IsCreate = true;
            Contact contact = new Contact();
            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ContactCreate(Contact contact)
        {
            // Create Model
            ViewBag.IsCreate = true;

            if (!ModelState.IsValid) return View(contact);
            // Find User
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            
            var contactDbTest = await dbContext.Contacts.FirstOrDefaultAsync(dr => dr.Id == user.Id);
            //Check Contact
            if (contactDbTest != null) return Redirect("/System/Error404");

            // One To One
            contact.Id = user.Id;
            await dbContext.Contacts.AddAsync(contact);
            await dbContext.SaveChangesAsync();

            // Messange
            TempData["AccountAlert"] = "Contact Created";

            return Redirect("/UserAdmin/UserAccount/Account");
        }

        [HttpGet]
        public async Task<IActionResult> ContactUpdate()
        {
            // Update Model
            ViewBag.IsCreate = false;

            var user = await userManager.FindByNameAsync(User.Identity.Name);
            // One To One => User To Contact
            var contactDbTest = await dbContext.Contacts.FirstOrDefaultAsync(dr => dr.Id == user.Id);
            if(contactDbTest==null) return Redirect("/System/Error404");

            return View("ContactCreate", contactDbTest);
            
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ContactUpdate(Contact contact)
        {
            // Update Model
            ViewBag.IsCreate = false;

            if (!ModelState.IsValid) return View(contact);
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            // One To One => User To Contact
            var contactDb = await dbContext.Contacts.FirstOrDefaultAsync(dr => dr.Id == user.Id);
            if (contactDb == null) return Redirect("/System/Error404");

            contactDb.Email = contact.Email;
            contactDb.Description = contact.Description;
            contactDb.Location = contact.Location;
            contactDb.PhoneNumber = contact.PhoneNumber;

            await dbContext.SaveChangesAsync();
            // Messange
            TempData["AccountAlert"] = "Contact Update";

            return Redirect("/UserAdmin/UserAccount/Account");
        }
    }
}
