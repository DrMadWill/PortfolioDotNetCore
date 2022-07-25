﻿using Microsoft.AspNetCore.Identity;
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
    public class BlogCategoryController : Controller
    {

        private readonly PorfolioDbContext dbContext;

        public BlogCategoryController(PorfolioDbContext _dbContext)
        {
            dbContext = _dbContext;
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Create(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Length == 1) return Json(new
            {
                status = 404
            });

            var category = await dbContext.BlogCategories.FirstOrDefaultAsync(dr => dr.Name == name);
            if (category != null) return Json(new
            {
                status = 400
            });

            await dbContext.BlogCategories.AddAsync(new BlogCategory { Name = name });
            await dbContext.SaveChangesAsync();

            return Json(new
            {
                status = 201
            });
        }

    }
}
