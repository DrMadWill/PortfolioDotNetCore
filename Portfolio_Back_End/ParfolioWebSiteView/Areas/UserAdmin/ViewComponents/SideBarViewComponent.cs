using Microsoft.AspNetCore.Mvc;
using ParfolioWebSiteView.Areas.UserAdmin.Data;
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
            
            return View(sideBar.Bars);
        }
    }
}
