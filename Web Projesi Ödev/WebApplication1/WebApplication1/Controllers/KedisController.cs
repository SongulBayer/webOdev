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
    public class KedisController : Controller
    {
        private readonly KediDbContext _context;

        public KedisController(KediDbContext context)
        {
            _context = context;
        }

        // GET: Kedis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kedi.ToListAsync());
        }

        // GET: Kedis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kedi = await _context.Kedi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kedi == null)
            {
                return NotFound();
            }

            return View(kedi);
        }

        // GET: Kedis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kedis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,fiyat,adi")] Kedi kedi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kedi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kedi);
        }

        // GET: Kedis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kedi = await _context.Kedi.FindAsync(id);
            if (kedi == null)
            {
                return NotFound();
            }
            return View(kedi);
        }

        // POST: Kedis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,fiyat,adi")] Kedi kedi)
        {
            if (id != kedi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kedi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KediExists(kedi.Id))
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
            return View(kedi);
        }

        // GET: Kedis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kedi = await _context.Kedi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kedi == null)
            {
                return NotFound();
            }

            return View(kedi);
        }

        // POST: Kedis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kedi = await _context.Kedi.FindAsync(id);
            _context.Kedi.Remove(kedi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KediExists(int id)
        {
            return _context.Kedi.Any(e => e.Id == id);
        }
    }
}
