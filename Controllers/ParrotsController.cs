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
    public class ParrotsController : Controller
    {
        private readonly ParrotContext _context;

        public ParrotsController(ParrotContext context)
        {
            _context = context;
        }

        // GET: Parrots
        public async Task<IActionResult> Index()
        {
            return View(await _context.Parrot.ToListAsync());
        }

        // GET: Parrots/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parrot = await _context.Parrot
                .SingleOrDefaultAsync(m => m.ParrotId == id);
            if (parrot == null)
            {
                return NotFound();
            }

            return View(parrot);
        }

        // GET: Parrots/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parrots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ParrotId,Name,Species,Breeder,Cost,Gender,Sold,Deceased,OldWorld,NewWorld")] Parrot parrot)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parrot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parrot);
        }

        // GET: Parrots/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parrot = await _context.Parrot.SingleOrDefaultAsync(m => m.ParrotId == id);
            if (parrot == null)
            {
                return NotFound();
            }
            return View(parrot);
        }

        // POST: Parrots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ParrotId,Name,Species,Breeder,Cost,Gender,Sold,Deceased,OldWorld,NewWorld")] Parrot parrot)
        {
            if (id != parrot.ParrotId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parrot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParrotExists(parrot.ParrotId))
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
            return View(parrot);
        }

        // GET: Parrots/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parrot = await _context.Parrot
                .SingleOrDefaultAsync(m => m.ParrotId == id);
            if (parrot == null)
            {
                return NotFound();
            }

            return View(parrot);
        }

        // POST: Parrots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parrot = await _context.Parrot.SingleOrDefaultAsync(m => m.ParrotId == id);
            _context.Parrot.Remove(parrot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParrotExists(int id)
        {
            return _context.Parrot.Any(e => e.ParrotId == id);
        }
    }
}
