using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SystemController : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
    }
}
