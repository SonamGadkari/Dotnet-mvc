﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace mvc2.Controllers
{
    public class QuotesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Text()
        {			
             return Content("A calm and modest life brings more happiness than the pursuit of success combined with constant restlessness.--Albert Einstein");
        }
        public IActionResult HTML()
        {
             return Content("<html><p>This is HTML content</p><h1>Centered Heading</h1></html>");
        }
        
        public IActionResult Views()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public JsonResult JSON()
        {
            return Json(new {Text="JSON data",Description="JSON value"});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
