using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MilVetIndApi.Authentication;
using MilVetIndApi.Data;

namespace MilVetIndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DistrictController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DistrictController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/District
        [HttpGet]

        public async Task<ActionResult<ObservableCollection<District>>> GetDistrict()
        {
            var resp = await _context.District.ToListAsync();

            return new ObservableCollection<District>(resp);
        }

        // GET: api/District/5
        [HttpGet("{id}")]
        public async Task<ActionResult<District>> GetDistrict(int id)
        {
            var district = await _context.District.FindAsync(id);

            if (district == null)
            {
                return NotFound();
            }

            return district;
        }

        // PUT: api/District/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDistrict(int id, District district)
        {
            if (id != district.PK_District)
            {
                return BadRequest();
            }

            _context.Entry(district).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DistrictExists(id))
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

        // POST: api/District
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<District>> PostDistrict(District district)
        {
            var message = "";
            try
            {
                var d = _context.District.Where(w => w.DistrictName == district.DistrictName).FirstOrDefault();
                if (d != null)
                {
                    message = "Duplicate";
                }
                else
                {
                    _context.District.Add(district);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            if (message.Equals("Duplicate"))
            {
                district.DistrictName = "Duplicate";
            }

            return Ok(district);
            //return CreatedAtAction("GetDistrict", new { id = district.PK_District }, district);
        }

        // DELETE: api/District/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<District>> DeleteDistrict(int id)
        {
            var district = await _context.District.FindAsync(id);
            if (district == null)
            {
                return NotFound();
            }

            _context.District.Remove(district);
            await _context.SaveChangesAsync();

            return district;
        }

        private bool DistrictExists(int id)
        {
            return _context.District.Any(e => e.PK_District == id);
        }
    }
}
