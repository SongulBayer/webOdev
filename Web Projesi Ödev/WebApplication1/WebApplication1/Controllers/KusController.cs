using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.data;

namespace WebApplication1.Controllers
{
    public class KusController : Controller
    {
        private readonly KediDbContext _context;

        public KusController(KediDbContext context)
        {
            _context = context;
        }

        // GET: Kus
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kus.ToListAsync());
        }

        // GET: Kus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kus = await _context.Kus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kus == null)
            {
                return NotFound();
            }

            return View(kus);
        }

        // GET: Kus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,fiyat,adi")] Kus kus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kus);
        }

        // GET: Kus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kus = await _context.Kus.FindAsync(id);
            if (kus == null)
            {
                return NotFound();
            }
            return View(kus);
        }

        // POST: Kus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,fiyat,adi")] Kus kus)
        {
            if (id != kus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KusExists(kus.Id))
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
            return View(kus);
        }

        // GET: Kus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kus = await _context.Kus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kus == null)
            {
                return NotFound();
            }

            return View(kus);
        }

        // POST: Kus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kus = await _context.Kus.FindAsync(id);
            _context.Kus.Remove(kus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KusExists(int id)
        {
            return _context.Kus.Any(e => e.Id == id);
        }
    }
}
