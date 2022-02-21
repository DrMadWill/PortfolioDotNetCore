﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ParfolioWebSiteView.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            ViewBag.ImageData = PartfolioImages.AllImage();
            ViewBag.WorkImage = PartfolioImages.WorkImage();
            ViewBag.Testimonials = PartfolioImages.Testimonials();
            ViewBag.PartfolioServices = PartfolioImages.PartfolioServices();
            return View();
        }

        public IActionResult SinglePage()
        {
            return View();
        }

        public IActionResult PortfolioDetails()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
