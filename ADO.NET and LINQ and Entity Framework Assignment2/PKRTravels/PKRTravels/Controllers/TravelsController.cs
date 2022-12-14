using Microsoft.AspNetCore.Mvc;
using PKRTravels.Models;

namespace PKRTravels.Controllers
{
    public class TravelsController : Controller
    {
        private readonly ContextDB context;
        public TravelsController(ContextDB _context)
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
                context.TravelsDBs.Add(travels);
                context.SaveChanges();
                return Ok("Successfully created");
            }
            return View(travels);
        }
        public IActionResult ListOfBuses(TravelsDB travels)
        {
           var arr= context.TravelsDBs.ToList();
         return View(arr);
        }
    }
}
