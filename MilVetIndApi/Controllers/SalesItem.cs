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
    public class SalesItem : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SalesItem(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesItem>>> GetSalesItem()
        {
            return await _context.SalesItem.ToListAsync();
        }

        // GET: api/SalesItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesItem>> GetSalesItem(int id)
        {
            var salesItem = await _context.SalesItem.FindAsync(id);

            if (salesItem == null)
            {
                return NotFound();
            }

            return salesItem;
        }

        // PUT: api/SalesItem/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesItem(int id, SalesItem salesItem)
        {
            if (id != salesItem.PK_SalesItem)
            {
                return BadRequest();
            }

            _context.Entry(salesItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesItemExists(id))
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

        // POST: api/SalesItem
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SalesItem>> PostSalesItem(SalesItem salesItem)
        {
            _context.SalesItem.Add(salesItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesItem", new { id = salesItem.PK_SalesItem }, salesItem);
        }

        // DELETE: api/SalesItem/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SalesItem>> DeleteSalesItem(int id)
        {
            var salesItem = await _context.SalesItem.FindAsync(id);
            if (salesItem == null)
            {
                return NotFound();
            }

            _context.SalesItem.Remove(salesItem);
            await _context.SaveChangesAsync();

            return salesItem;
        }

        private bool SalesItemExists(int id)
        {
            return _context.SalesItem.Any(e => e.PK_SalesItem == id);
        }
    }
}
