using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParfolioWebSiteView.Areas.UserAdmin.ViewModels;
using ParfolioWebSiteView.Extensions;
using ParfolioWebSiteView.Models;
using ParfolioWebSiteView.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Collections.Generic;
using ParfolioWebSiteView.Areas.UserAdmin.Models;
using System.Text.Json;

namespace ParfolioWebSiteView.Areas.UserAdmin.Controllers
{
    [Area("UserAdmin")]
    [Authorize(Roles = "SuperAdmin")]
    public class DataBaseController : Controller
    {

        private readonly PorfolioDbContext dbContext;
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;
        public DataBaseController(PorfolioDbContext _dbContext,
            IConfiguration configuration,
            IWebHostEnvironment env)
        {
            dbContext = _dbContext;
            _configuration = configuration;
            _env = env;
        }

        [HttpGet]
        public async Task<IActionResult> Table() => View(new SqlSelectVM());

        public async Task<IActionResult> Table(SqlSelectVM sqlSelect)
        {
            if (ModelState.IsValid)
            {
                switch (sqlSelect.Id)
                {
                    case 1:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<User, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 2:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<DetailImage, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 3:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<About, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 4:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<Achievements, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 5:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<Blog, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 6:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<Contact, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 7:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<ContactOnline, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 8:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<BlogCategory, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 9:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<Portfolio, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 10:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<PortfolioCategory, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 11:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<PortfolioDetail, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 12:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<Referance, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 13:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<Service, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 14:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<SkillCode, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 15:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<Tag, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 16:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<BlogToTag, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 17:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<BlogDetails, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 18:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<Commet, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 19:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<Home, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                    case 20:
                        sqlSelect.Resault = JsonSerializer.Serialize(await SelectSqlExtation<Home, PorfolioDbContext>.SqlData(dbContext, sqlSelect.Code));
                        break;
                }
            }

            return View(sqlSelect);
        }

        

        [HttpGet]
        public async Task<IActionResult> Edit() => View(new SqlEditVM());

        [HttpPost]
        public async Task<IActionResult> Edit(SqlEditVM sqlEditVM)
        {

            if (ModelState.IsValid)
            {
                var count = await dbContext.Database.ExecuteSqlCommandAsync(sqlEditVM.Code);

                TempData["SqlMgs"] = count + " affected";
                return Redirect("/User/DataBase/" + nameof(Edit));
            }

            return View(sqlEditVM);
        }

    }
}
