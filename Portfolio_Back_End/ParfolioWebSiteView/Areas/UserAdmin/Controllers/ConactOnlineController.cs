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
    public class ConactOnlineController : Controller
    {
        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;


        public ConactOnlineController(PorfolioDbContext _dbContext, UserManager<User> _userManager)
        {
            dbContext = _dbContext;
            userManager = _userManager;
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Create(ContactOnline online)
        {
            if (!ModelState.IsValid)
                return Json(new
                {
                    status = 404
                });

            var user = await userManager.FindByNameAsync(User.Identity.Name);
            var contactDb = await dbContext.Contacts.Include(x => x.ContactOnlines).FirstOrDefaultAsync(dr => dr.Id == user.Id);

            // Check Contact 
            if (contactDb == null) return Json(new
            {
                status = 404
            });

            // Limit
            if (contactDb.ContactOnlines.Count >= 11) return Json(new
            {
                status = 400
            });

            online.ContactId = user.Id;
            
            await dbContext.ContactOnlines.AddAsync(online);
            await dbContext.SaveChangesAsync();

            return Json(new
            {
                status = 201
            });
        }

        // Update Get 
        [HttpGet]
        public async Task<JsonResult> Update(int? id)
        {
            if(id==null) return Json(new
            {
                status = 404
            });

            var contact = await dbContext.ContactOnlines.FirstOrDefaultAsync(dr => dr.Id == id);
            if(contact == null) return Json(new
            {
                status = 404
            });

            return Json(contact);
        }

        // Update POST 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Update(ContactOnline contactOnline)
        {
            if (!ModelState.IsValid)
                return Json(new
                {
                    status = 404
                });

            var contactonlineDb = await dbContext.ContactOnlines.FirstOrDefaultAsync(dr => dr.Id == contactOnline.Id);
            if (contactonlineDb == null) return Json(new
            {
                status = 404
            });

            contactonlineDb.Name = contactOnline.Name;
            contactonlineDb.Icon = contactOnline.Icon;
            contactonlineDb.Url = contactOnline.Url;

            await dbContext.SaveChangesAsync();
            return Json(new
            {
                status = 201
            });
        }

        public async Task<JsonResult> Delete(int? id)
        {
            if (id == null) return Json(new
            {
                status = 404
            });
            var contact = await dbContext.ContactOnlines.FirstOrDefaultAsync(dr => dr.Id == id);
            if (contact == null) return Json(new
            {
                status = 404
            });
            dbContext.ContactOnlines.Remove(contact);
            await dbContext.SaveChangesAsync();

            return Json(new
            {
                status = 201
            });
        }

    }
}
