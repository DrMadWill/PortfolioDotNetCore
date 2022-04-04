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
    public class CommentController : Controller
    {

        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;

        public CommentController(PorfolioDbContext _dbContext, UserManager<User> _userManager)
        {
            dbContext = _dbContext;
            userManager = _userManager;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Create(Commet commentu)
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return Json(new
            {
                status = 404
            });

            commentu.UserId = user.Id;

            // Model Validation
            if (!ModelState.IsValid) return Json(new
            {
                status = 404
            });

            // Leave Comment
            if (commentu.ParentId == null)
            {
                var blog = await dbContext.Blogs.FirstOrDefaultAsync(dr => dr.Id.Equals(commentu.BlogDetailsId));
                if (blog == null) return Json(new
                {
                    status = 404
                });
                commentu.BlogDetailsId = blog.Id;
                commentu.Date = DateTime.Now;
                commentu.IsBlocked = false;

                await dbContext.Commets.AddAsync(commentu);
                await dbContext.SaveChangesAsync();
                return Json(new
                {
                    status = 201
                });
            }
            else
            {
                var commentData = await dbContext.Commets
                    .Select(x => new { x.Id, x.BlogDetailsId })
                    .FirstOrDefaultAsync(dr => dr.Id == commentu.ParentId);
                if (commentData == null) return Json(new
                {
                    status = 404
                });

                commentu.BlogDetailsId = commentData.BlogDetailsId;
                commentu.Date = DateTime.Now;
                commentu.IsBlocked = false;
                commentu.ParentId = commentData.Id;

                await dbContext.Commets.AddAsync(commentu);
                await dbContext.SaveChangesAsync();
                return Json(new
                {
                    status = 201
                });
            }
        }

        [HttpGet]
        public async Task<JsonResult> Update(int? id)
        {
            // Data Check
            if (id == null) return Json(new { status = 404 });

            // Comment Check
            var comment = await dbContext.Commets.FirstOrDefaultAsync(dr => dr.Id == id && dr.IsBlocked == false);
            if(comment == null) return Json(new { status = 404 });
            return Json(comment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Update(Commet commentu)
        {
            // Data Check
            if (!ModelState.IsValid) return Json(new { status = 404 });

            // User Check
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if(user == null) return Json(new { status = 404 });

            // Comment Check
            var commentDb = await dbContext.Commets
                .FirstOrDefaultAsync(dr =>dr.User == user 
                && dr.Id == commentu.Id && dr.IsBlocked == false);
            if (commentDb == null) return Json(new { status = 404 });

            commentDb.Comment = commentu.Comment;
            await dbContext.SaveChangesAsync();
            return Json(new { status= 201});
        }


        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Delete(int? id)
        {
            // Data Check
            if (id == null) return Json(new { status = 404 });

            // User Check
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return Json(new { status = 404 });

            // Comment Check
            var commentDb = await dbContext.Commets
                .FirstOrDefaultAsync(dr => dr.User == user
                && dr.Id == id && dr.IsBlocked == false);
            if (commentDb == null) return Json(new { status = 404 });

            var childComment = await dbContext.Commets.Where(dr => dr.ParentId == commentDb.Id).ToListAsync();
            childComment.Add(commentDb);
            dbContext.Commets.RemoveRange(childComment);
            await dbContext.SaveChangesAsync();
            return Json(new { status = 201 });
        }


    }
}
