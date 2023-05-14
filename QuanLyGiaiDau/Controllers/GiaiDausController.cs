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
    [Route("api/[controller]")]
    [ApiController]
    public class GiaiDausController : Controller
    {
        private readonly QuanLyGiaiDauContext _context;

        public GiaiDausController(QuanLyGiaiDauContext context)
        {
            _context = context;
        }

        // GET: GiaiDaus
        public async Task<IActionResult> Index()
        {
            return View(await _context.GiaiDaus.ToListAsync());
        }

        // GET: GiaiDaus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var giaiDau = await _context.GiaiDaus
                .FirstOrDefaultAsync(m => m.IdGiaiDau == id);
            if (giaiDau == null)
            {
                return NotFound();
            }

            return View(giaiDau);
        }

        // GET: GiaiDaus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GiaiDaus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdGiaiDau,TenGiaiDau,NgayBatDau,MoTa,DiaDiem,TrangThai")] GiaiDau giaiDau)
        {
            if (ModelState.IsValid)
            {
                _context.Add(giaiDau);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(giaiDau);
        }

        // GET: GiaiDaus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var giaiDau = await _context.GiaiDaus.FindAsync(id);
            if (giaiDau == null)
            {
                return NotFound();
            }
            return View(giaiDau);
        }

        // POST: GiaiDaus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdGiaiDau,TenGiaiDau,NgayBatDau,MoTa,DiaDiem,TrangThai")] GiaiDau giaiDau)
        {
            if (id != giaiDau.IdGiaiDau)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(giaiDau);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GiaiDauExists(giaiDau.IdGiaiDau))
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
            return View(giaiDau);
        }

        // GET: GiaiDaus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var giaiDau = await _context.GiaiDaus
                .FirstOrDefaultAsync(m => m.IdGiaiDau == id);
            if (giaiDau == null)
            {
                return NotFound();
            }

            return View(giaiDau);
        }

        // POST: GiaiDaus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var giaiDau = await _context.GiaiDaus.FindAsync(id);
            _context.GiaiDaus.Remove(giaiDau);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GiaiDauExists(int id)
        {
            return _context.GiaiDaus.Any(e => e.IdGiaiDau == id);
        }
    }
}
