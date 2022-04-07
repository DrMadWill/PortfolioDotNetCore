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
using Microsoft.AspNetCore.Authorization;
using ParfolioWebSiteView.Areas.UserAdmin.ViewModels;

namespace ParfolioWebSiteView.Areas.UserAdmin.Controllers
{
    [Authorize(Roles = "User")]
    [Area("UserAdmin")]
    public class PortfolioCategoryController : Controller
    {

        private readonly PorfolioDbContext dbContext;

        public PortfolioCategoryController(PorfolioDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [HttpGet]
        public async Task<JsonResult> IsAdded(string id)
        {
            string name = id;
            if (string.IsNullOrEmpty(name) || name.Length == 1) return Json(new
            {
                status=404
            });
            bool isAdded = false;
            var category = await dbContext.PortfolioCategories.FirstOrDefaultAsync(dr => dr.Name == name);
            if (category != null) isAdded = true;
            return Json(isAdded);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Create(string name)
        {
            if(string.IsNullOrEmpty(name) || name.Length == 1) return Json(new
            {
                status = 404
            });

            var category = await dbContext.PortfolioCategories.FirstOrDefaultAsync(dr => dr.Name == name);
            if(category!=null) return Json(new
            {
                status = 404
            });

            await dbContext.PortfolioCategories.AddAsync(new PortfolioCategory { Name = name });
            await dbContext.SaveChangesAsync();

            return Json(new
            {
                status = 201
            });
        }

    }
}
