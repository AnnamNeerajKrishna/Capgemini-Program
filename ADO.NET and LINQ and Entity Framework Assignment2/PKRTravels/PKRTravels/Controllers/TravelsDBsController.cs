using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PKRTravels;
using PKRTravels.Models;

namespace PKRTravels.Controllers
{
    public class TravelsDBsController : Controller
    {
        private readonly ADDContextDB _context;

        public TravelsDBsController(ADDContextDB context)
        {
            _context = context;
        }

        // GET: TravelsDBs
        public async Task<IActionResult> Index()
        {
              return View(await _context.TravelsDB.ToListAsync());
        }

        // GET: TravelsDBs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TravelsDB == null)
            {
                return NotFound();
            }

            var travelsDB = await _context.TravelsDB
                .FirstOrDefaultAsync(m => m.BusId == id);
            if (travelsDB == null)
            {
                return NotFound();
            }

            return View(travelsDB);
        }

        // GET: TravelsDBs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TravelsDBs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BusId,BoardingPoint,TravelDate,Amount,Rating")] TravelsDB travelsDB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(travelsDB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(travelsDB);
        }

        // GET: TravelsDBs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TravelsDB == null)
            {
                return NotFound();
            }

            var travelsDB = await _context.TravelsDB.FindAsync(id);
            if (travelsDB == null)
            {
                return NotFound();
            }
            return View(travelsDB);
        }

        // POST: TravelsDBs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BusId,BoardingPoint,TravelDate,Amount,Rating")] TravelsDB travelsDB)
        {
            if (id != travelsDB.BusId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(travelsDB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TravelsDBExists(travelsDB.BusId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(travelsDB);
        }

        // GET: TravelsDBs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TravelsDB == null)
            {
                return NotFound();
            }

            var travelsDB = await _context.TravelsDB
                .FirstOrDefaultAsync(m => m.BusId == id);
            if (travelsDB == null)
            {
                return NotFound();
            }

            return View(travelsDB);
        }

        // POST: TravelsDBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TravelsDB == null)
            {
                return Problem("Entity set 'ADDContextDB.TravelsDB'  is null.");
            }
            var travelsDB = await _context.TravelsDB.FindAsync(id);
            if (travelsDB != null)
            {
                _context.TravelsDB.Remove(travelsDB);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravelsDBExists(int id)
        {
          return _context.TravelsDB.Any(e => e.BusId == id);
        }
    }
}
