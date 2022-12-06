using Microsoft.AspNetCore.Mvc;
using PKRTravels.Models;

namespace PKRTravels.Controllers
{
    public class TravelsController : Controller
    {
        private readonly ADDContextDB context;
        public TravelsController(ADDContextDB _context)
        {
            this.context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(TravelsDB travels)
        {
            if (ModelState.IsValid)
            {
                context.Add(travels);
                return RedirectToAction("Index");
            }
            return View(travels);
        }
    }
}
