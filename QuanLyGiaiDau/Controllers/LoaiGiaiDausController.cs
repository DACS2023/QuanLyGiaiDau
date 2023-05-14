using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyGiaiDau.Models;

namespace QuanLyGiaiDau.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiGiaiDausController : ControllerBase
    {
        private readonly QuanLyGiaiDauContext _context;

        public LoaiGiaiDausController(QuanLyGiaiDauContext context)
        {
            _context = context;
        }

        // GET: api/LoaiGiaiDaus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoaiGiaiDau>>> GetLoaiGiaiDau()
        {
            return await _context.LoaiGiaiDau.ToListAsync();
        }

        // GET: api/LoaiGiaiDaus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoaiGiaiDau>> GetLoaiGiaiDau(int id)
        {
            var loaiGiaiDau = await _context.LoaiGiaiDau.FindAsync(id);

            if (loaiGiaiDau == null)
            {
                return NotFound();
            }

            return loaiGiaiDau;
        }

        // PUT: api/LoaiGiaiDaus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoaiGiaiDau(int id, LoaiGiaiDau loaiGiaiDau)
        {
            if (id != loaiGiaiDau.IdloaiGiaiDau)
            {
                return BadRequest();
            }

            _context.Entry(loaiGiaiDau).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoaiGiaiDauExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        // POST: api/LoaiGiaiDaus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LoaiGiaiDau>> PostLoaiGiaiDau(LoaiGiaiDau loaiGiaiDau)
        {
            var MonTheThao = await _context.MonTheThaos.FindAsync(loaiGiaiDau.IdMonTheThao);
            //MonTheThao monTheThao = await _context.MonTheThaos.Where(x => x.IdMonTheThao.Equals(loaiGiaiDau.IdMonTheThao.ToString()));
            loaiGiaiDau.MonTheThao = MonTheThao;
               // MonTheThao monTheThao = var 
            _context.LoaiGiaiDau.Add(loaiGiaiDau);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoaiGiaiDau", new { id = loaiGiaiDau.IdloaiGiaiDau }, loaiGiaiDau);
        }

        // DELETE: api/LoaiGiaiDaus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoaiGiaiDau(int id)
        {
            var loaiGiaiDau = await _context.LoaiGiaiDau.FindAsync(id);
            if (loaiGiaiDau == null)
            {
                return NotFound();
            }

            _context.LoaiGiaiDau.Remove(loaiGiaiDau);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LoaiGiaiDauExists(int id)
        {
            return _context.LoaiGiaiDau.Any(e => e.IdloaiGiaiDau == id);
        }
    }
}
