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
            var child = sideBar.GetChildIdByLink(link);
            if(child == null)
            {
                ViewBag.child = null;
            }
            else
            {
                ViewBag.child = child;
            }
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
                                new BarChild { Id=14,Name = "List",Link="" },
                                new BarChild { Id=15,Name = "Create",Link="" }
                            }
                        },
                         new Bar
                         {
                             Id = 8,
                             Name = "Roles",
                             Icon = "fas fa-user-lock",
                             BarChildren = new List<BarChild>
                            {
                                new BarChild { Id=16,Name = "List",Link="" },
                                new BarChild { Id=17,Name = "Create",Link="" }
                            }
                         }
                    );
            }
            
            return View(sideBar.Bars);
        }
    }
}
