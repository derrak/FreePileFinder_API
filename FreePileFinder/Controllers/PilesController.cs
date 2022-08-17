using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FreePileFinder.Models;

namespace FreePileFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilesController : ControllerBase
    {
        private readonly FreePileFinderContext _db;

        public PilesController(FreePileFinderContext context)
        {
            _db = context;
        }

        // GET: api/Piles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pile>>> GetPiles()
        {
            return await _db.Piles.ToListAsync();
        }

        // GET: api/Piles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pile>> GetPile(int id)
        {
            var pile = await _db.Piles.FindAsync(id);

            if (pile == null)
            {
                return NotFound();
            }

            return pile;
        }

        // PUT: api/Piles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPile(int id, Pile pile)
        {
            if (id != pile.PileId)
            {
                return BadRequest();
            }

            _db.Entry(pile).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PileExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            // return NoContent();
            return CreatedAtAction(nameof(GetPile), new { id = pile.PileId }, pile);
        }


        // POST: api/Piles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pile>> PostPile([FromBody] Pile pile)
        {
            pile.CreatedDate = DateTime.Now;
            _db.Piles.Add(pile);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetPile", new { id = pile.PileId }, pile);
        }


        // DELETE: api/Piles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePile(int id)
        {
            var pile = await _db.Piles.FindAsync(id);
            if (pile == null)
            {
                return NotFound();
            }

            _db.Piles.Remove(pile);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool PileExists(int id)
        {
            return _db.Piles.Any(e => e.PileId == id);
        }
    }
}
