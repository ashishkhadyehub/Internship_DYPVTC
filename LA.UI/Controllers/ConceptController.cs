using Microsoft.AspNetCore.Mvc;

namespace LA.UI.Controllers
{
    public class ConceptController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Message = "Concepts";
            ViewData["Message"] = "Concepts";
            TempData["TestMessage"] = "Data from previous request";
            return View();
        }

        public IActionResult NextPage()
        {
            return View();
        }
    }
}
