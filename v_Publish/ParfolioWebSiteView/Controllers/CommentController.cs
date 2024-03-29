﻿using Microsoft.AspNetCore.Mvc;
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
                var commentParent = await dbContext.Commets
                    .FirstOrDefaultAsync(dr => dr.Id == commentu.ParentId);
                if (commentParent == null) return Json(new
                {
                    status = 404
                });

                //Is Chaild True
                commentParent.IsChild = true;


                commentu.ParentId = commentParent.Id;
                commentu.BlogDetailsId = commentParent.BlogDetailsId;
                commentu.Date = DateTime.Now;
                commentu.IsBlocked = false;
                commentu.UserId = user.Id;

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
            if (comment == null) return Json(new { status = 404 });
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
            if (user == null) return Json(new { status = 404 });

            // Comment Check
            var commentDb = await dbContext.Commets
                .FirstOrDefaultAsync(dr => dr.User == user
                && dr.Id == commentu.Id && dr.IsBlocked == false);

            if (commentDb == null) return Json(new { status = 404 });
            
            commentDb.Comment = commentu.Comment;
            await dbContext.SaveChangesAsync();
            return Json(new { status = 201 });
        }


        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Delete(int? id)
        {
            // Data Check
            if (id == null) return Json(new { status = 422 });

            // User Check
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return Json(new { status = 403 });

            // Comment Check
            var commentDb = await dbContext.Commets
                .FirstOrDefaultAsync(dr => dr.User == user
                && dr.Id == id && dr.IsBlocked == false);
            if (commentDb == null) return Json(new { status = 404 });

            // Parent Check
            if (commentDb.ParentId != null)
            {
                var count = await dbContext.Commets.Where(dr => dr.ParentId == commentDb.ParentId).CountAsync();
                if(count < 2)
                {
                    var commentParent = await dbContext.Commets.FindAsync(commentDb.ParentId);
                    commentParent.IsChild = false;
                }
            }

            // Child Comment
             var CommentChildren = await dbContext.Commets.AsNoTracking().AsQueryable().ComentChildernAsync(commentDb.Id);

            CommentChildren.Add(commentDb);

            dbContext.Commets.RemoveRange(CommentChildren);
            await dbContext.SaveChangesAsync();
            return Json(new { status = 202 });
        }


        [HttpGet]
        public async Task<JsonResult> GetMoreComment(int? blogId, int? commentSectionIndex)
        {

            if (blogId == null) return Json(new { status = 404 });

            var blog = await dbContext.Blogs.FirstOrDefaultAsync(dr => dr.Id == blogId);
            if (blog == null) return Json(new { status = 404 });

            // DataBase Count 
            int count = await dbContext.Commets.CountAsync();
            // CommentSize
            int commentSize = 5;

            int maxSize = (int)Math.Ceiling(count / (double)commentSize);
            if (commentSectionIndex > maxSize) return Json(new { status = 404 });

            // Defaul Number
            if (commentSectionIndex == 0 || commentSectionIndex < 0) commentSectionIndex = 1;
            int index = commentSectionIndex ?? 1;
            var comments = await dbContext.Commets
                .Where(dr => dr.BlogDetailsId == blog.Id && dr.IsBlocked == false && dr.ParentId == null)
                .Select(x => new
                {
                    x.Id,
                    x.IsChild, 
                    x.ParentId,
                    x.BlogDetailsId,
                    x.Comment,
                    x.Date,
                    x.HtmlId,
                    x.User.UserName,
                    x.User.Image
                })
                .Skip(Math.Abs(index - 1) * commentSize).Take(commentSize).ToListAsync();
            return Json(comments);
        }

        [HttpGet]
        public async Task<JsonResult> GetChildComment(int? parentId,int? index)
        {
            if(parentId == null && index == null) return Json(new { status = 404 });
            int cIndex = index ?? 1;
           
            var comments = await dbContext.Commets
                .Where(dr => dr.ParentId == parentId && dr.IsBlocked == false)
                .Select(x => new CommentJVM
                {
                    Id = x.Id,
                    IsChild = x.IsChild,
                    ParentId =x.ParentId,
                    BlogDetailsId=x.BlogDetailsId,
                    Comment=x.Comment,
                    Date=x.Date,
                    HtmlId=x.HtmlId,
                    UserName=x.User.UserName,
                    Image=x.User.Image,
                    ParentUserName =x.Parent.User.UserName
                })
                .Skip((cIndex - 1) * 5).Take(5).ToListAsync();
            return Json(comments);
        }

    }
}
