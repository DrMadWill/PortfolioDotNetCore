using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Areas.Admin.Controllers
{
    
    public class SystemController : Controller
    {
        // Not Found
        public IActionResult Error404() => View();
        // Access Denied
        public IActionResult Error403() => View();
        // Server 
        public IActionResult Error500() => View();

    }



}
