using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public string SayHello() => "Hello World";

        public string Today() =>DateTime.Today.ToString();

        public string NextDate(int id)=> DateTime.Now.AddDays(id).ToString();   

        public string AddDays(int days)=> DateTime.Now.AddDays(days).ToString();

        public ActionResult GetJsom()
        {
            var obj = new { id = 1, name = "SomeThing" };
            return Json(obj);
        }

        public IActionResult Index1()
        {
            return View(viewName:"Index");
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