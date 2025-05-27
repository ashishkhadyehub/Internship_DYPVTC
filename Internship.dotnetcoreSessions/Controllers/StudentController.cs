using Internship.dotnetcoreSessions.Data;
using Internship.dotnetcoreSessions.Models;
using Microsoft.AspNetCore.Mvc;

namespace Internship.dotnetcoreSessions.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var studentList = _context.Students.ToList();
            return View(studentList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Students student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
