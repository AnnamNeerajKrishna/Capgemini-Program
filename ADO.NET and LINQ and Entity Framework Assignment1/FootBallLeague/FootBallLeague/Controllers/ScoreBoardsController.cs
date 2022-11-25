using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FootBallLeague;
using FootBallLeague.Models;

namespace FootBallLeague.Controllers
{
    public class ScoreBoardsController : Controller
    {
        private readonly FootBallLeagueContextDB _context;

        public ScoreBoardsController(FootBallLeagueContextDB context)
        {
            _context = context;
        }

        // GET: ScoreBoards
        public async Task<IActionResult> Index()
        {
              return View(await _context.ScoreBoards.ToListAsync());
        }
        // Show list of winners
        public async Task<IActionResult> Winners()
        {
            var TotalList = await _context.ScoreBoards.ToListAsync();
            var WinnersList = TotalList.Where(team => team.Points == 4);
            return View(WinnersList);
        }


        // GET: ScoreBoards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ScoreBoards == null)
            {
                return NotFound();
            }

            var scoreBoard = await _context.ScoreBoards
                .FirstOrDefaultAsync(m => m.MatchId == id);
            if (scoreBoard == null)
            {
                return NotFound();
            }

            return View(scoreBoard);
        }

        // GET: ScoreBoards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ScoreBoards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MatchId,TeamName1,TeamName2,Status,WinningTeams,Points")] ScoreBoard scoreBoard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scoreBoard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(scoreBoard);
        }

        // GET: ScoreBoards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ScoreBoards == null)
            {
                return NotFound();
            }

            var scoreBoard = await _context.ScoreBoards.FindAsync(id);
            if (scoreBoard == null)
            {
                return NotFound();
            }
            return View(scoreBoard);
        }

        // POST: ScoreBoards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MatchId,TeamName1,TeamName2,Status,WinningTeams,Points")] ScoreBoard scoreBoard)
        {
            if (id != scoreBoard.MatchId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scoreBoard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScoreBoardExists(scoreBoard.MatchId))
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
            return View(scoreBoard);
        }

        // GET: ScoreBoards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ScoreBoards == null)
            {
                return NotFound();
            }

            var scoreBoard = await _context.ScoreBoards
                .FirstOrDefaultAsync(m => m.MatchId == id);
            if (scoreBoard == null)
            {
                return NotFound();
            }

            return View(scoreBoard);
        }

        // POST: ScoreBoards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ScoreBoards == null)
            {
                return Problem("Entity set 'FootBallLeagueContextDB.ScoreBoards'  is null.");
            }
            var scoreBoard = await _context.ScoreBoards.FindAsync(id);
            if (scoreBoard != null)
            {
                _context.ScoreBoards.Remove(scoreBoard);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScoreBoardExists(int id)
        {
          return _context.ScoreBoards.Any(e => e.MatchId == id);
        }
    }
}
