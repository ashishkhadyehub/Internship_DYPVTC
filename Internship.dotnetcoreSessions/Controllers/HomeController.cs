using System.Diagnostics;
using Internship.dotnetcoreSessions.Models;
using Microsoft.AspNetCore.Mvc;

namespace Internship.dotnetcoreSessions.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Action Method
        public IActionResult Index()
        {
            //int a = 70;
            //return View(a);

            //string name = "Shree";
            //return View("Index",name);

            Students student = new Students();
            student.Id = 6;
            student.Name = "Shree";
            student.City = "Pune";

            return View(student);
        }

        public IActionResult Privacy()
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
