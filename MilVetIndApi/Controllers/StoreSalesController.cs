using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MilVetIndApi.Authentication;
using MilVetIndApi.Data;

namespace MilVetIndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreSalesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StoreSalesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/StoreSales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoreSales>>> GetStoreSales()
        {
            return await _context.StoreSales.ToListAsync();
        }

        // GET: api/StoreSales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoreSales>> GetStoreSales(int id)
        {
            var storeSales = await _context.StoreSales.FindAsync(id);

            if (storeSales == null)
            {
                return NotFound();
            }

            return storeSales;
        }

        // PUT: api/StoreSales/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoreSales(int id, StoreSales storeSales)
        {
            if (id != storeSales.PK_StoreSales)
            {
                return BadRequest();
            }

            _context.Entry(storeSales).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoreSalesExists(id))
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

        // POST: api/StoreSales
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<StoreSales>> PostStoreSales(StoreSales storeSales)
        {
            _context.StoreSales.Add(storeSales);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStoreSales", new { id = storeSales.PK_StoreSales }, storeSales);
        }

        // DELETE: api/StoreSales/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StoreSales>> DeleteStoreSales(int id)
        {
            var storeSales = await _context.StoreSales.FindAsync(id);
            if (storeSales == null)
            {
                return NotFound();
            }

            _context.StoreSales.Remove(storeSales);
            await _context.SaveChangesAsync();

            return storeSales;
        }

        private bool StoreSalesExists(int id)
        {
            return _context.StoreSales.Any(e => e.PK_StoreSales == id);
        }
    }
}
