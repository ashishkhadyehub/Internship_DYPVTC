﻿using Microsoft.AspNetCore.Mvc;

namespace Internship.dotnetcoreSessions.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }   
    }
}
