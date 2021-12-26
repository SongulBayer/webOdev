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
    public class BaliksController : Controller
    {
        private readonly KediDbContext _context;

        public BaliksController(KediDbContext context)
        {
            _context = context;
        }

        // GET: Baliks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Balik.ToListAsync());
        }

        // GET: Baliks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var balik = await _context.Balik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (balik == null)
            {
                return NotFound();
            }

            return View(balik);
        }

        // GET: Baliks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Baliks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,fiyat,adi")] Balik balik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(balik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(balik);
        }

        // GET: Baliks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var balik = await _context.Balik.FindAsync(id);
            if (balik == null)
            {
                return NotFound();
            }
            return View(balik);
        }

        // POST: Baliks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,fiyat,adi")] Balik balik)
        {
            if (id != balik.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(balik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BalikExists(balik.Id))
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
            return View(balik);
        }

        // GET: Baliks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var balik = await _context.Balik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (balik == null)
            {
                return NotFound();
            }

            return View(balik);
        }

        // POST: Baliks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var balik = await _context.Balik.FindAsync(id);
            _context.Balik.Remove(balik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BalikExists(int id)
        {
            return _context.Balik.Any(e => e.Id == id);
        }
    }
}
