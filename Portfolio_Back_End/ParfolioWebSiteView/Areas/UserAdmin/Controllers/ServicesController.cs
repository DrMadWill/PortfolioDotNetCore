using Microsoft.AspNetCore.Mvc;
using ParfolioWebSiteView.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace ParfolioWebSiteView.Areas.UserAdmin.Controllers
{
    [Authorize(Roles = "User")]
    [Area("UserAdmin")]
    public class ServicesController : Controller
    {

        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;
        public ServicesController(PorfolioDbContext _dbContext, UserManager<User> _userManager)
        {
            dbContext = _dbContext;
            userManager = _userManager;
        }

        public async Task<IActionResult> List()
        {

            var services = await dbContext.Services
                .Where(dr => dr.User.UserName == User.Identity.Name)
                .ToListAsync();

            return View(services);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.IsCreate = true;
            Service service = new Service
            {
                UserId = (await userManager.FindByNameAsync(User.Identity.Name)).Id
            };
            return View(service);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Service service)
        {
            ViewBag.IsCreate = true;
            if (!ModelState.IsValid) return View(service);
            // Check serviece added
            var serviceTesting = await dbContext.Services
                .FirstOrDefaultAsync(dr => dr.Name == service.Name
                && dr.User.UserName == User.Identity.Name);
            if (serviceTesting != null)
            {
                ModelState.AddModelError("Name", "This Name Already Add");
                return View(service);
            }

            var servicesCount = (await dbContext.Services
                .Where(dr => dr.User.UserName == User.Identity.Name).ToListAsync()).Count;

            if(servicesCount > 12)
            {
                TempData["ServicesAlert"] = "Not Added Service. Becouse Your Service Limit 12";
                return Redirect("/UserAdmin/Services/List");
            }

            await dbContext.Services.AddAsync(service);
            await dbContext.SaveChangesAsync();
            TempData["ServicesAlert"] = service.Name + " Service Created";
            return Redirect("/UserAdmin/Services/List");
        }


        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            ViewBag.IsCreate = false;
            var service = await dbContext.Services.FirstOrDefaultAsync(dr => dr.Id == id &&
            dr.User.UserName == User.Identity.Name);
            return View("Create", service);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Service service)
        {
            ViewBag.IsCreate = false;

            if (!ModelState.IsValid) return View("Create", service);

            var user = await userManager.FindByNameAsync(User.Identity.Name);

            // Check serviece added
            var serviceTesting = await dbContext.Services
                .FirstOrDefaultAsync(dr => dr.Name == service.Name
                && dr.UserId == user.Id && dr.Id != service.Id);

            if (serviceTesting != null)
            {
                ModelState.AddModelError("Name", "This Name Already Add");
                return View(service);
            }

            var serviceDb = await dbContext.Services.FirstOrDefaultAsync(dr => dr.Id == service.Id
            && service.UserId == user.Id);
            if (serviceDb == null) return Redirect("/System/Error404");

            serviceDb.Name = service.Name;
            serviceDb.Icon = service.Icon;
            serviceDb.Descriptoion = service.Descriptoion;
            await dbContext.SaveChangesAsync();
            TempData["ServicesAlert"] = service.Name + " Service Updated";
            return Redirect("/UserAdmin/Services/List");
        }


        public async Task<IActionResult> Delete(int? id)
        {
            var service = await dbContext.Services.FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name &&
           dr.Id == id);
            if (service == null) return Redirect("/System/Error404");
            dbContext.Services.Remove(service);
            await dbContext.SaveChangesAsync();
            TempData["ServicesAlert"] = service.Name + " Service Deleted";
            return Redirect("/UserAdmin/Services/List");
        }
    }
}
