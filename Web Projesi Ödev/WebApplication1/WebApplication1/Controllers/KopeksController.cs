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
    public class KopeksController : Controller
    {
        private readonly KediDbContext _context;

        public KopeksController(KediDbContext context)
        {
            _context = context;
        }

        // GET: Kopeks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kopek.ToListAsync());
        }

        // GET: Kopeks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kopek = await _context.Kopek
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kopek == null)
            {
                return NotFound();
            }

            return View(kopek);
        }

        // GET: Kopeks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kopeks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,fiyat,adi")] Kopek kopek)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kopek);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kopek);
        }

        // GET: Kopeks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kopek = await _context.Kopek.FindAsync(id);
            if (kopek == null)
            {
                return NotFound();
            }
            return View(kopek);
        }

        // POST: Kopeks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,fiyat,adi")] Kopek kopek)
        {
            if (id != kopek.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kopek);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KopekExists(kopek.Id))
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
            return View(kopek);
        }

        // GET: Kopeks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kopek = await _context.Kopek
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kopek == null)
            {
                return NotFound();
            }

            return View(kopek);
        }

        // POST: Kopeks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kopek = await _context.Kopek.FindAsync(id);
            _context.Kopek.Remove(kopek);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KopekExists(int id)
        {
            return _context.Kopek.Any(e => e.Id == id);
        }
    }
}
