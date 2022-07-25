using Microsoft.AspNetCore.Mvc;
using ParfolioWebSiteView.ViewModels;
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

        [Route("/Error/{status}")]
        public IActionResult Error(int status) => View(new ErrorVM { Code = status,Message = "Ooops! Something went wrong ." });

    }



}
