using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuanLyGiaiDau.Models;

namespace QuanLyGiaiDau.Controllers
{
    public class DoiDausController : Controller
    {
        private readonly QuanLyGiaiDauContext _context;

        public DoiDausController(QuanLyGiaiDauContext context)
        {
            _context = context;
        }

        // GET: DoiDaus
        public async Task<IActionResult> Index()
        {
            return View(await _context.DoiDaus.ToListAsync());
        }

        // GET: DoiDaus/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doiDau = await _context.DoiDaus
                .FirstOrDefaultAsync(m => m.IdDoiDau == id);
            if (doiDau == null)
            {
                return NotFound();
            }

            return View(doiDau);
        }

        // GET: DoiDaus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DoiDaus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdDoiDau,TenDoiDau,Logo")] DoiDau doiDau)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doiDau);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doiDau);
        }

        // GET: DoiDaus/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doiDau = await _context.DoiDaus.FindAsync(id);
            if (doiDau == null)
            {
                return NotFound();
            }
            return View(doiDau);
        }

        // POST: DoiDaus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdDoiDau,TenDoiDau,Logo")] DoiDau doiDau)
        {
            if (id != doiDau.IdDoiDau)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doiDau);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoiDauExists(doiDau.IdDoiDau))
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
            return View(doiDau);
        }

        // GET: DoiDaus/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doiDau = await _context.DoiDaus
                .FirstOrDefaultAsync(m => m.IdDoiDau == id);
            if (doiDau == null)
            {
                return NotFound();
            }

            return View(doiDau);
        }

        // POST: DoiDaus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var doiDau = await _context.DoiDaus.FindAsync(id);
            _context.DoiDaus.Remove(doiDau);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoiDauExists(string id)
        {
            return _context.DoiDaus.Any(e => e.IdDoiDau == id);
        }
    }
}
