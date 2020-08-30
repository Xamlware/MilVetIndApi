using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public class GenderController : ControllerBase
        {
            private readonly ApplicationDbContext _context;

            public GenderController(ApplicationDbContext context)
            {
                _context = context;
            }

            // GET: api/Gender
            [HttpGet]
            public async Task<ActionResult<ObservableCollection<Gender>>> GetGender()
            {
                var resp = await _context.Gender.ToListAsync();

                return new ObservableCollection<Gender>(resp);
            }

            // GET: api/Gender/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Gender>> GetGender(int id)
            {
                var Gender = await _context.Gender.FindAsync(id);

                if (Gender == null)
                {
                    return NotFound();
                }

                return Gender;
            }

            // PUT: api/Gender/5
            // To protect from overposting attacks, enable the specific properties you want to bind to, for
            // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
            [HttpPut("{id}")]
            public async Task<IActionResult> PutGender(int id, Gender Gender)
            {
                if (id != Gender.PK_Gender)
                {
                    return BadRequest();
                }

                _context.Entry(Gender).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenderExists(id))
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

            // POST: api/Gender
            // To protect from overposting attacks, enable the specific properties you want to bind to, for
            // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
            [HttpPost]
            public async Task<ActionResult<Gender>> PostGender(Gender Gender)
            {
                _context.Gender.Add(Gender);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetGender", new { id = Gender.PK_Gender }, Gender);
            }

            // DELETE: api/Gender/5
            [HttpDelete("{id}")]
            public async Task<ActionResult<Gender>> DeleteGender(int id)
            {
                var Gender = await _context.Gender.FindAsync(id);
                if (Gender == null)
                {
                    return NotFound();
                }

                _context.Gender.Remove(Gender);
                await _context.SaveChangesAsync();

                return Gender;
            }

            private bool GenderExists(int id)
            {
                return _context.Gender.Any(e => e.PK_Gender == id);
            }
        }
    }
