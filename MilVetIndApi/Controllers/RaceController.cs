﻿using System;
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
    public class RaceController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RaceController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Race
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Race>>> GetRace()
        {
            return await _context.Race.ToListAsync();
        }

        // GET: api/Race/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Race>> GetRace(int id)
        {
            var race = await _context.Race.FindAsync(id);

            if (race == null)
            {
                return NotFound();
            }

            return race;
        }

        // PUT: api/Race/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRace(int id, Race race)
        {
            if (id != race.PK_Race)
            {
                return BadRequest();
            }

            _context.Entry(race).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceExists(id))
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

        // POST: api/Race
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Race>> PostRace(Race race)
        {
            _context.Race.Add(race);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRace", new { id = race.PK_Race }, race);
        }

        // DELETE: api/Race/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Race>> DeleteRace(int id)
        {
            var race = await _context.Race.FindAsync(id);
            if (race == null)
            {
                return NotFound();
            }

            _context.Race.Remove(race);
            await _context.SaveChangesAsync();

            return race;
        }

        private bool RaceExists(int id)
        {
            return _context.Race.Any(e => e.PK_Race == id);
        }
    }
}
