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
    public class StoreSalesItemController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StoreSalesItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/StoreSalesItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoreSalesItem>>> GetStoreSalesItem()
        {
            return await _context.StoreSalesItem.ToListAsync();
        }

        // GET: api/StoreSalesItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoreSalesItem>> GetStoreSalesItem(int id)
        {
            var storeSalesItem = await _context.StoreSalesItem.FindAsync(id);

            if (storeSalesItem == null)
            {
                return NotFound();
            }

            return storeSalesItem;
        }

        // PUT: api/StoreSalesItem/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoreSalesItem(int id, StoreSalesItem storeSalesItem)
        {
            if (id != storeSalesItem.PK_StoreSalesItem)
            {
                return BadRequest();
            }

            _context.Entry(storeSalesItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoreSalesItemExists(id))
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

        // POST: api/StoreSalesItem
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<StoreSalesItem>> PostStoreSalesItem(StoreSalesItem storeSalesItem)
        {
            _context.StoreSalesItem.Add(storeSalesItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStoreSalesItem", new { id = storeSalesItem.PK_StoreSalesItem }, storeSalesItem);
        }

        // DELETE: api/StoreSalesItem/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StoreSalesItem>> DeleteStoreSalesItem(int id)
        {
            var storeSalesItem = await _context.StoreSalesItem.FindAsync(id);
            if (storeSalesItem == null)
            {
                return NotFound();
            }

            _context.StoreSalesItem.Remove(storeSalesItem);
            await _context.SaveChangesAsync();

            return storeSalesItem;
        }

        private bool StoreSalesItemExists(int id)
        {
            return _context.StoreSalesItem.Any(e => e.PK_StoreSalesItem == id);
        }
    }
}
