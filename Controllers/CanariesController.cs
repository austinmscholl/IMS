using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CanariesController : Controller
    {
        private readonly CanaryContext _context;

        public CanariesController(CanaryContext context)
        {
            _context = context;
        }

        // GET: Canaries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Canary.ToListAsync());
        }

        // GET: Canaries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canary = await _context.Canary
                .SingleOrDefaultAsync(m => m.CanaryId == id);
            if (canary == null)
            {
                return NotFound();
            }

            return View(canary);
        }

        // GET: Canaries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Canaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CanaryId,Name,Species,Breeder,Cost,Gender,Sold,Deceased")] Canary canary)
        {
            if (ModelState.IsValid)
            {
                _context.Add(canary);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(canary);
        }

        // GET: Canaries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canary = await _context.Canary.SingleOrDefaultAsync(m => m.CanaryId == id);
            if (canary == null)
            {
                return NotFound();
            }
            return View(canary);
        }

        // POST: Canaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CanaryId,Name,Species,Breeder,Cost,Gender,Sold,Deceased")] Canary canary)
        {
            if (id != canary.CanaryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(canary);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CanaryExists(canary.CanaryId))
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
            return View(canary);
        }

        // GET: Canaries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var canary = await _context.Canary
                .SingleOrDefaultAsync(m => m.CanaryId == id);
            if (canary == null)
            {
                return NotFound();
            }

            return View(canary);
        }

        // POST: Canaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var canary = await _context.Canary.SingleOrDefaultAsync(m => m.CanaryId == id);
            _context.Canary.Remove(canary);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CanaryExists(int id)
        {
            return _context.Canary.Any(e => e.CanaryId == id);
        }
    }
}
