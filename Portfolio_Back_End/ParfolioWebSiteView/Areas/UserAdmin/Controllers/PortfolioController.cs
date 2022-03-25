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

namespace ParfolioWebSiteView.Areas.UserAdmin.Controllers
{
    [Authorize(Roles = "User")]
    [Area("UserAdmin")]
    public class PortfolioController : Controller
    {

        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;
        private readonly IWebHostEnvironment env;
        public PortfolioController(PorfolioDbContext _dbContext, UserManager<User> _userManager, IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            userManager = _userManager;
            env = _env;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var portfolio = await dbContext.Portfolios.Include(x => x.PortfolioCategory).Include(x => x.PortfolioDetail)
                .Where(dr => dr.User.UserName == User.Identity.Name).ToListAsync();
            return View(portfolio);
        }


        // Create GET
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.IsCreate = true;
            Portfolio portfolio = new Portfolio
            {
                UserId = (await userManager.FindByNameAsync(User.Identity.Name)).Id,
                PortfolioCategoriesVM = await dbContext.PortfolioCategories.ToListAsync(),
                PortfolioDetail = new PortfolioDetail()
            };
            return View(portfolio);
        }

        // Create POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Portfolio portfolio)
        {
            ViewBag.IsCreate = true;
            if (!ModelState.IsValid)
            {
                portfolio.PortfolioCategoriesVM = await dbContext.PortfolioCategories.ToListAsync();
                return View(portfolio);
            }

            var user = await userManager.FindByNameAsync(User.Identity.Name);
            portfolio.UserId = user.Id;
            // Detail Images Check
            foreach (var item in portfolio.PortfolioDetail.Photos.Take(5))
            {
                if (!item.IsImage())
                {
                    portfolio.PortfolioCategoriesVM = await dbContext.PortfolioCategories.ToListAsync();
                    ModelState.AddModelError("PortfolioDetail.Photos", "Img forma not valid ");
                    return View(portfolio);
                }
            }

            // Image Save
            if (portfolio.Photo != null)
            {
                string folder = @"img\Porfolio";
                if (!portfolio.Photo.IsImage())
                {
                    portfolio.PortfolioCategoriesVM = await dbContext.PortfolioCategories.ToListAsync();
                    ModelState.AddModelError("Photo", "Img forma bot valid ");
                    return View(portfolio);
                }
                portfolio.Image = await portfolio.Photo.PhotoSaveAsync(env.WebRootPath, folder);
            }
            else
            {
                portfolio.PortfolioCategoriesVM = await dbContext.PortfolioCategories.ToListAsync();
                ModelState.AddModelError("Photo", "Img is Required");
                return View(portfolio);
            }
            await dbContext.Portfolios.AddAsync(portfolio);
            await dbContext.SaveChangesAsync();
            // Detail Image Save
            foreach (var item in portfolio.PortfolioDetail.Photos.Take(5))
            {
                await dbContext.DetailImages.AddAsync(
                        new DetailImage { PortfolioDetail=portfolio.PortfolioDetail,Image= await item.PhotoSaveAsync(env.WebRootPath, @"img\PorfolioDetails") }
                    );
            }
            await dbContext.SaveChangesAsync();
            TempData["PortfolioAlert"] = portfolio.Title + " Portfolio Created";
            return Redirect("/UserAdmin/Portfolio/List");
        }

        // Update GET
        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            ViewBag.IsCreate = false;
            var portfolio = await dbContext.Portfolios
               .Include(x => x.PortfolioCategory)
               .Include(x => x.PortfolioDetail)
               .FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name
                && dr.Id == id);
            if (portfolio == null) return Redirect("/System/Error404");
            portfolio.PortfolioCategoriesVM = await dbContext.PortfolioCategories.ToListAsync(); 
            return View("Create", portfolio);
        }

        // Update POST
        [HttpPost]
        public async Task<IActionResult> Update(Portfolio portfolio)
        {
            ViewBag.IsCreate = false;
            if (!ModelState.IsValid)
            {
                portfolio.PortfolioCategoriesVM = await dbContext.PortfolioCategories.ToListAsync();
                return View("Create", portfolio);
            }
            // Check Portfolio
            var portfolioDb = await dbContext.Portfolios
               .Include(x => x.PortfolioCategory)
               .Include(x => x.PortfolioDetail).ThenInclude(x => x.DetailImages)
               .FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name
                && dr.Id == portfolio.Id);
            if (portfolio == null) return Redirect("/System/Error404");

            // Check Image
            if (portfolio.Photo != null)
            {
                string folder = @"img\Porfolio";
                if (!portfolio.Photo.IsImage())
                {
                    portfolio.PortfolioCategoriesVM = await dbContext.PortfolioCategories.ToListAsync();
                    ModelState.AddModelError("Photo", "Img forma bot valid ");
                    return View(portfolio);
                }

                string newImageName = await portfolio.Photo.PhotoSaveAsync(env.WebRootPath, folder);
                // Old Image Delete
                FileExtension.Delete(env.WebRootPath, @"img\Porfolio", portfolioDb.Image);
                portfolioDb.Image = newImageName;
            }

            if(portfolioDb.PortfolioDetail.DetailImages.Count < 5)
            {
                int imageCount = 5- portfolioDb.PortfolioDetail.DetailImages.Count;
                // Detail Images Format Check
                foreach (var item in portfolio.PortfolioDetail.Photos.Take(imageCount))
                {
                    if (!item.IsImage())
                    {
                        portfolio.PortfolioCategoriesVM = await dbContext.PortfolioCategories.ToListAsync();
                        ModelState.AddModelError("PortfolioDetail.Photos", "Img forma not valid ");
                        return View(portfolio);
                    }
                }
                // Save
                foreach (var item in portfolio.PortfolioDetail.Photos.Take(imageCount))
                {
                    await dbContext.DetailImages.AddAsync(
                            new DetailImage { PortfolioDetailId = portfolioDb.Id, Image = await item.PhotoSaveAsync(env.WebRootPath, @"img\PorfolioDetails") }
                        );
                }
                await dbContext.SaveChangesAsync();
            }

            portfolioDb.Title = portfolio.Title;
            portfolioDb.PortfolioCategoryId = portfolio.PortfolioCategoryId;
            portfolioDb.PortfolioDetail.LocatoionURL = portfolio.PortfolioDetail.LocatoionURL;
            portfolioDb.PortfolioDetail.Client = portfolio.PortfolioDetail.Client;
            portfolioDb.PortfolioDetail.Descriptoion = portfolio.PortfolioDetail.Descriptoion;

            dbContext.Update(portfolioDb);
            await dbContext.SaveChangesAsync();
            TempData["PortfolioAlert"] = portfolioDb.Title + " Portfolio Updated";
            return Redirect("/UserAdmin/Portfolio/List");
        }

        // Show GET
        [HttpGet]
        public async Task<IActionResult> Show(int? id)
        {
            var portfolio = await dbContext.Portfolios
                .Include(x => x.PortfolioCategory)
                .Include(x => x.PortfolioDetail).ThenInclude(x => x.DetailImages)
                .FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name
            && dr.Id == id);
            if (portfolio == null) return Redirect("/System/Error404");
            return View(portfolio);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            var portfolio = await dbContext.Portfolios.Include(x => x.PortfolioDetail).ThenInclude(dr=>dr.DetailImages)
                .FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name && dr.Id == id);
            if (portfolio == null) return Redirect("/System/Error404");
            string folder = @"img\Porfolio";
            FileExtension.Delete(env.WebRootPath, folder, portfolio.Image);

            foreach (var item in portfolio.PortfolioDetail.DetailImages)
            {
                FileExtension.Delete(env.WebRootPath, @"img\PorfolioDetails", item.Image);
            }

            dbContext.Portfolios.Remove(portfolio);
            await dbContext.SaveChangesAsync();
            TempData["PortfolioAlert"] = portfolio.Title + " Portfolio Deleted";
            return Redirect("/UserAdmin/Portfolio/List");
        }

    }
}
