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
    public class FinchesController : Controller
    {
        private readonly FinchContext _context;

        public FinchesController(FinchContext context)
        {
            _context = context;
        }

        // GET: Finches
        public async Task<IActionResult> Index()
        {
            return View(await _context.Finch.ToListAsync());
        }

        // GET: Finches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var finch = await _context.Finch
                .SingleOrDefaultAsync(m => m.FinchId == id);
            if (finch == null)
            {
                return NotFound();
            }

            return View(finch);
        }

        // GET: Finches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Finches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FinchId,Name,Species,Breeder,Cost,Gender,Sold,Deceased")] Finch finch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(finch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(finch);
        }

        // GET: Finches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var finch = await _context.Finch.SingleOrDefaultAsync(m => m.FinchId == id);
            if (finch == null)
            {
                return NotFound();
            }
            return View(finch);
        }

        // POST: Finches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FinchId,Name,Species,Breeder,Cost,Gender,Sold,Deceased")] Finch finch)
        {
            if (id != finch.FinchId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(finch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FinchExists(finch.FinchId))
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
            return View(finch);
        }

        // GET: Finches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var finch = await _context.Finch
                .SingleOrDefaultAsync(m => m.FinchId == id);
            if (finch == null)
            {
                return NotFound();
            }

            return View(finch);
        }

        // POST: Finches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var finch = await _context.Finch.SingleOrDefaultAsync(m => m.FinchId == id);
            _context.Finch.Remove(finch);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FinchExists(int id)
        {
            return _context.Finch.Any(e => e.FinchId == id);
        }
    }
}
