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
    public class EmployeeTimeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EmployeeTimeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EmployeeTime
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeTime>>> GetEmployeeTime()
        {
            return await _context.EmployeeTime.ToListAsync();
        }

        // GET: api/EmployeeTime/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeTime>> GetEmployeeTime(int id)
        {
            var employeeTime = await _context.EmployeeTime.FindAsync(id);

            if (employeeTime == null)
            {
                return NotFound();
            }

            return employeeTime;
        }

        // PUT: api/EmployeeTime/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeTime(int id, EmployeeTime employeeTime)
        {
            if (id != employeeTime.PK_EmployeeTime)
            {
                return BadRequest();
            }

            _context.Entry(employeeTime).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeTimeExists(id))
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

        // POST: api/EmployeeTime
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EmployeeTime>> PostEmployeeTime(EmployeeTime employeeTime)
        {
            _context.EmployeeTime.Add(employeeTime);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployeeTime", new { id = employeeTime.PK_EmployeeTime }, employeeTime);
        }

        // DELETE: api/EmployeeTime/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmployeeTime>> DeleteEmployeeTime(int id)
        {
            var employeeTime = await _context.EmployeeTime.FindAsync(id);
            if (employeeTime == null)
            {
                return NotFound();
            }

            _context.EmployeeTime.Remove(employeeTime);
            await _context.SaveChangesAsync();

            return employeeTime;
        }

        private bool EmployeeTimeExists(int id)
        {
            return _context.EmployeeTime.Any(e => e.PK_EmployeeTime == id);
        }
    }
}
