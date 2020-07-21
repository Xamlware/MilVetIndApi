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
    public class StoreController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StoreController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Store
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Store>>> GetStore()
        {
            return await _context.Store.ToListAsync();
        }

        // GET: api/Store/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Store>> GetStore(int id)
        {
            var store = await _context.Store.FindAsync(id);

            if (store == null)
            {
                return NotFound();
            }

            return store;
        }

        // PUT: api/Store/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStore(int id, Store store)
        {
            if (id != store.PK_Store)
            {
                return BadRequest();
            }

            _context.Entry(store).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoreExists(id))
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

        // POST: api/Store
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Store>> PostStore(Store store)
        {
            _context.Store.Add(store);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStore", new { id = store.PK_Store }, store);
        }

        // DELETE: api/Store/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Store>> DeleteStore(int id)
        {
            var store = await _context.Store.FindAsync(id);
            if (store == null)
            {
                return NotFound();
            }

            _context.Store.Remove(store);
            await _context.SaveChangesAsync();

            return store;
        }

        private bool StoreExists(int id)
        {
            return _context.Store.Any(e => e.PK_Store == id);
        }
    }
}