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
using ParfolioWebSiteView.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ParfolioWebSiteView.Areas.UserAdmin.Controllers
{
    [Authorize(Roles = "User")]
    [Area("UserAdmin")]
    public class DetailimageController : Controller
    {
        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;
        private readonly IWebHostEnvironment env;
        public DetailimageController(PorfolioDbContext _dbContext, UserManager<User> _userManager, IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            userManager = _userManager;
            env = _env;
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<JsonResult> Add(IFormFile file,int? id)
        {
            if (file == null || id ==null) return Json(new {
                Status = 404
            });

            if(!file.IsImage()) return Json(new
            {
                Status = 404
            });

            var portfolio = await dbContext.Portfolios.Include(x=>x.PortfolioDetail.DetailImages)
                .FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name &&
                dr.Id == id);

            if(portfolio.PortfolioDetail.DetailImages.Count > 5) return Json(new
            {
                Status = 400
            });

            if (portfolio == null) return Json(new
            {
                Status = 404
            });

            DetailImage detailImage = new DetailImage
            {
                Image = await file.PhotoSaveAsync(env.WebRootPath, @"img\PorfolioDetails"),
                PortfolioDetailId=portfolio.Id
            };

            await dbContext.DetailImages.AddAsync(detailImage);
            await dbContext.SaveChangesAsync();

            return Json(new
            {
                Status = 201
            });
        }

        public async Task<JsonResult> Delete( int? id)
        {
            if(id==null) return Json(new
            {
                Status = 404
            });

            var image = await dbContext.DetailImages
                .FirstOrDefaultAsync(dr => dr.PortfolioDetail.Portfolio.User.UserName == User.Identity.Name &&
                dr.Id ==id);
            if(image ==null) return Json(new
            {
                Status = 404
            });
            FileExtension.Delete(env.WebRootPath, @"img\PorfolioDetails", image.Image);
            dbContext.DetailImages.Remove(image);
            await dbContext.SaveChangesAsync();
            return Json(new
            {
                Status = 201
            });
        }

    }
}
