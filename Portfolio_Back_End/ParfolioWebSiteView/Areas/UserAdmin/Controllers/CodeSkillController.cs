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
    public class CodeSkillController : Controller
    {
        private readonly PorfolioDbContext dbContext;
        private readonly UserManager<User> userManager;


        public CodeSkillController(PorfolioDbContext _dbContext, UserManager<User> _userManager)
        {
            dbContext = _dbContext;
            userManager = _userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var about = await dbContext.Abouts.FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name);
            if(about == null) return Redirect("/System/Error404");
            ViewBag.IsCreate = true;
            SkillCode skill = new SkillCode
            {
                AboutId = about.Id
            };
            return View(skill);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SkillCode skill)
        {
            ViewBag.IsCreate = true;
            var about = await dbContext.Abouts.Include(x => x.SkillCodes).FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name);
            if (about == null) return Redirect("/System/Error404");
            // Limit Skill
            TempData["AccountAlert"] = "Your Limit Skill Code 10";
            if (about.SkillCodes.Count == 10) return Redirect("/UserAdmin/UserAccount/Account");
            skill.AboutId = about.Id;
            
            // Already Added Skill
            var AddedSkill = about.SkillCodes.Find(dr => dr.Name == skill.Name);
            if (AddedSkill != null)
            {
                ModelState.AddModelError("Name", "Already Added This Name");
                return View(skill);
            }

            if (!ModelState.IsValid) return View(skill);

            if (skill.Percent >= 100)
            {
                ModelState.AddModelError("Percent", "Maximum Length");
                return View(skill);
            }

            

            var skilltest = await dbContext.SkillCodes
                .FirstOrDefaultAsync(dr => dr.Id == skill.Id && dr.Name == skill.Name);
            if (skilltest != null)
            {
                ModelState.AddModelError("Name", "This Skill Already Added");
                return View(skill);
            }

            await dbContext.SkillCodes.AddAsync(skill);
            await dbContext.SaveChangesAsync();
            TempData["AccountAlert"] =skill.Name + " Code Skill Created";
            return Redirect("/UserAdmin/UserAccount/Account");
        }


        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            ViewBag.IsCreate = false;
            if(id==null) return Redirect("/System/Error404");
            var skill = await dbContext.SkillCodes
                .FirstOrDefaultAsync(dr => dr.About.User.UserName == User.Identity.Name &&
                dr.Id == id);


            return View("Create", skill);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(SkillCode skill)
        {
            ViewBag.IsCreate = false;
            
            if (!ModelState.IsValid) return View("Create", skill);
            
            if (skill.Percent >= 100)
            {
                ModelState.AddModelError("Percent", "Maximum Length");
                return View(skill);
            }


            // Already Added Skill
            var about = await dbContext.Abouts
                .Include(x => x.SkillCodes)
                .FirstOrDefaultAsync(dr => dr.User.UserName == User.Identity.Name);
            var AddedSkill = about.SkillCodes.Find(dr => dr.Name == skill.Name && dr.Id!=skill.Id);
            if (AddedSkill != null)
            {
                ModelState.AddModelError("Name", "Already Added This Name");
                return View("Create",skill);
            }

            // Find Skill
            var skillDB = await dbContext.SkillCodes
                .FirstOrDefaultAsync(dr =>dr.Id == skill.Id);
            if(skillDB==null) return Redirect("/System/Error404");

            

            skillDB.Name = skill.Name;
            skillDB.Percent = skill.Percent;
            await dbContext.SaveChangesAsync();
            return Redirect("/UserAdmin/UserAccount/Account");
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if(id ==null) Redirect("/System/Error404");
            var skill = await dbContext.SkillCodes
                .FirstOrDefaultAsync(dr => dr.Id == id && dr.About.User.UserName == User.Identity.Name);
            if(skill==null) Redirect("/System/Error404");

            dbContext.SkillCodes.Remove(skill);
            await dbContext.SaveChangesAsync();
            return Redirect("/UserAdmin/UserAccount/Account");
        }

    }
}
