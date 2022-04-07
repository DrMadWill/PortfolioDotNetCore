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
using ParfolioWebSiteView.Extensions;
using Microsoft.AspNetCore.Hosting;


namespace ParfolioWebSiteView.Areas.UserAdmin.Controllers
{
    [Authorize(Roles = "User")]
    [Area("UserAdmin")]
    public class BlogController : Controller
    {
        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;
        private readonly IWebHostEnvironment env;
        public BlogController(PorfolioDbContext _dbContext, UserManager<User> _userManager, IWebHostEnvironment _env)
        {
            dbContext = _dbContext;
            userManager = _userManager;
            env = _env;
        }

        public async Task<IActionResult> List()
        {
            var blog = await dbContext.Blogs.Where(dr => dr.User.UserName == User.Identity.Name)
                .Include(x => x.BlogDetails)
                .Include(x => x.BlogCategory)
                .Include(y => y.User)
                .ToListAsync();
            return View(blog);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.IsCreate = true;
            BlogVM blog = new BlogVM
            {
                CategoriesVM = await dbContext.BlogCategories.ToListAsync(),
                Tags = await dbContext.Tags.ToListAsync(),
                Blog = new Blog(),
                TagIds = new List<int>()

            };
            blog.Blog.BlogDetails = new BlogDetails();
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogVM blogVM)
        {
            ViewBag.IsCreate = true;
            if (!ModelState.IsValid)
            {
                blogVM.CategoriesVM = await dbContext.BlogCategories.ToListAsync();
                blogVM.Tags = await dbContext.Tags.ToListAsync();
                return View(blogVM);
            }
            // Limit Check 
            var blogCount = (await dbContext.Blogs
                .Where(dr => dr.User.UserName == User.Identity.Name)
                .ToListAsync()).Count;
            if(blogCount > 20)
            {
                TempData["BlogAlert"] = "Not Create Blog. Your Blog Limit 20! ";
                return Redirect("/UserAdmin/Blog/List");
            }

            // Image Save
            if (blogVM.Photo != null)
            {
                string folder = @"img\Blog";
                if (!blogVM.Photo.IsImage())
                {
                    blogVM.CategoriesVM = await dbContext.BlogCategories.ToListAsync();
                    blogVM.Tags = await dbContext.Tags.ToListAsync();
                    ModelState.AddModelError("Photo", "Img forma not valid ");
                    return View(blogVM);
                }
                blogVM.Blog.Image = await blogVM.Photo.PhotoSaveAsync(env.WebRootPath, folder);
            }
            else
            {
                blogVM.CategoriesVM = await dbContext.BlogCategories.ToListAsync();
                blogVM.Tags = await dbContext.Tags.ToListAsync();
                ModelState.AddModelError("Photo", "Img is Required");
                return View(blogVM);
            }

            blogVM.Blog.UserId = (await userManager.FindByNameAsync(User.Identity.Name)).Id;
            await dbContext.AddAsync(blogVM.Blog);
            await dbContext.SaveChangesAsync();

            foreach (var item in blogVM.TagIds)
            {
                await dbContext.BlogToTags.AddAsync(
                        new BlogToTag
                        {
                            Blog = blogVM.Blog,
                            TagId = item
                        }
                    );
            }

            await dbContext.SaveChangesAsync();

            TempData["BlogAlert"] = blogVM.Blog.Title + " Blog Created";

            return Redirect("/UserAdmin/Blog/List");
        }


        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            ViewBag.IsCreate = false;
            var blogd= await dbContext.Blogs
                 .Include(x => x.BlogDetails)
                 .FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name &&
                 dr.Id == id);
            if(blogd == null) return Redirect("/System/Error404");
            BlogVM blogVM = new BlogVM
            {
                Id =blogd.Id,
                Blog = blogd,
                CategoriesVM = await dbContext.BlogCategories.ToListAsync(),
                Tags = await dbContext.Tags.ToListAsync(),
                TagIds = await dbContext.BlogToTags.Where(dr => dr.BlogId == id).Select(x => x.TagId).ToListAsync()
            };

            return View("Create", blogVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(BlogVM blogVM)
        {
            ViewBag.IsCreate = false;
            if (!ModelState.IsValid)
            {
                blogVM.CategoriesVM = await dbContext.BlogCategories.ToListAsync();
                blogVM.Tags = await dbContext.Tags.ToListAsync();
                return View("Create", blogVM);
            }

            var blogDb = await dbContext.Blogs
                .Include(x=>x.BlogDetails)
                .Include(x=>x.BlogToTags)
                .FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name
                && dr.Id == blogVM.Id);
            if(blogDb==null) return Redirect("/System/Error404");

            // Image Save
            if (blogVM.Photo != null)
            {
                string folder = @"img\Blog";
                if (!blogVM.Photo.IsImage())
                {
                    blogVM.CategoriesVM = await dbContext.BlogCategories.ToListAsync();
                    blogVM.Tags = await dbContext.Tags.ToListAsync();
                    ModelState.AddModelError("Photo", "Img forma not valid ");
                    return View(blogVM);
                }
                FileExtension.Delete(env.WebRootPath, folder, blogDb.Image);
                blogDb.Image = await blogVM.Photo.PhotoSaveAsync(env.WebRootPath, folder);
            }

            blogDb.Title = blogVM.Blog.Title;
            blogDb.Description = blogVM.Blog.Description;
            blogDb.BlogDetails.Description = blogVM.Blog.BlogDetails.Description;
            blogDb.BlogCategoryId = blogVM.Blog.BlogCategoryId;

            await dbContext.SaveChangesAsync();
            // Delete Older Tags
            dbContext.BlogToTags.RemoveRange(blogDb.BlogToTags);
            await dbContext.SaveChangesAsync();

            foreach (var item in blogVM.TagIds)
            {
                await dbContext.BlogToTags.AddAsync(
                        new BlogToTag
                        {
                            BlogId = blogDb.Id,
                            TagId = item
                        }
                    );
            }

            await dbContext.SaveChangesAsync();
            TempData["BlogAlert"] = blogVM.Blog.Title + " Blog Changed";
            return Redirect("/UserAdmin/Blog/List");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var blog = await dbContext.Blogs
                .Include(x => x.BlogDetails).ThenInclude(x=>x.Commets)
                .Include(x => x.BlogToTags)
                .FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name
                && dr.Id == id);
            if (blog == null) return Redirect("/System/Error404");
            string folder = @"img\Blog";
            FileExtension.Delete(env.WebRootPath, folder, blog.Image);
            dbContext.Blogs.Remove(blog);
            await dbContext.SaveChangesAsync();

            TempData["BlogAlert"] = blog.Title + " Blog Deleted";
            return Redirect("/UserAdmin/Blog/List");
        }
    }
}
