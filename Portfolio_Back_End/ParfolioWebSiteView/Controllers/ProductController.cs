using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ParfolioWebSiteView.Models;
using ParfolioWebSiteView.ViewModels;
using ParfolioWebSiteView.Extensions;
using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace ParfolioWebSiteView.Controllers
{
    public class ProductController : Controller
    {

        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;

        public ProductController(PorfolioDbContext _dbContext, UserManager<User> _userManager)
        {
            dbContext = _dbContext;
            userManager = _userManager;
        }

        public async Task<IActionResult> Index()
        {
            var data = await dbContext.Prodacts.ToListAsync();
            return View(data);
        }

        public IActionResult List()
        {
            return View();
        }

        public async Task<JsonResult> Seal(int? id,int? count)
        {
            if(id == null || count == null) return Json(new { status = 404 });

            var prodact = await dbContext.Prodacts.FirstOrDefaultAsync(dr => dr.Id == id);
            if(prodact == null) return Json(new { status = 404 });

            if(prodact.Count <count) return Json(new { status = 400 });

            var user = await userManager.FindByNameAsync(User.Identity.Name);

            Seal seal = new Seal
            {
                ProdactId = prodact.Id,
                UserId = user.Id,
                Count = count ?? 0,
                Price = (float)(prodact.Price * count),
            };

            prodact.Count  = prodact.Count - count??0;

            await dbContext.Seals.AddAsync(seal);
            await dbContext.SaveChangesAsync();


            return Json(new { status = 201 });
        }

        public async Task<IActionResult> SealList()
        {
            var data = await dbContext.Seals.Include(x=>x.Prodact).Include(x=>x.User).ToListAsync();
            return View(data);
        }





    }
}
