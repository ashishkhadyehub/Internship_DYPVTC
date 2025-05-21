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

            //Students student = new Students();
            //student.Id = 6;
            //student.Name = "Shree";
            //student.City = "Pune";



            //return View(student);
            //collection data type-list is generic collection
            List<Students> studentList= new List<Students>();
            studentList.Add(new Students { Id = 1, Name = "Shree", City = "Pune" });
            studentList.Add(new Students { Id = 2, Name = "Test", City = "Mumbai" });
            studentList.Add(new Students { Id = 3, Name = "ABC", City = "Kolhapur" });
            studentList.Add(new Students { Id = 4, Name = "PQR", City = "Jaipur" });

            return View(studentList);

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
