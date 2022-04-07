using Microsoft.AspNetCore.Mvc;
using ParfolioWebSiteView.Areas.UserAdmin.Data;
using ParfolioWebSiteView.Areas.UserAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Areas.UserAdmin.ViewComponents
{
    public class SideBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string link = "/" + "UserAdmin" + "/" + RouteData.Values["controller"].ToString() + "/" + RouteData.Values["action"];
            SideBarRepository sideBar = new SideBarRepository();
            
            // Is Admin
            if (User.IsInRole("Admin"))
            {
                sideBar.Adds(
                        new Bar
                        {
                            Id = 8,
                            Name = "Users",
                            Icon = "fas fa-users-cog",
                            BarChildren = new List<BarChild>
                            {
                                new BarChild { Id=14,Name = "List",Link="/UserAdmin/Account/List",BarId = 8 },
                                new BarChild { Id=15,Name = "Create",Link="/UserAdmin/Account/Create",BarId = 8 }
                            }
                        },
                         new Bar
                         {
                             Id = 9,
                             Name = "Roles",
                             Icon = "fas fa-user-lock",
                             BarChildren = new List<BarChild>
                            {
                                new BarChild { Id=16,Name = "List",Link="/UserAdmin/Role/List",BarId = 9 },
                                new BarChild { Id=17,Name = "Create",Link="/UserAdmin/Role/Create" ,BarId = 9}
                            }
                         }
                    );
            }

            ViewBag.child = sideBar.GetChildIdByLink(link);

            return View(sideBar.Bars);
        }
    }
}
