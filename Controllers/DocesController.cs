using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BotasDocesAPI.Data;
using BotasDocesAPI.Models;

namespace BotasDocesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DocesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Doces
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doce>>> GetDoce()
        {
            return await _context.Doce.ToListAsync();
        }

        // GET: api/Doces/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Doce>> GetDoce(Guid id)
        {
            var doce = await _context.Doce.FindAsync(id);

            if (doce == null)
            {
                return NotFound();
            }

            return doce;
        }

        // PUT: api/Doces/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDoce(Guid id, Doce doce)
        {
            if (id != doce.Id)
            {
                return BadRequest();
            }

            _context.Entry(doce).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DoceExists(id))
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

        // POST: api/Doces
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Doce>> PostDoce(Doce doce)
        {
            _context.Doce.Add(doce);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDoce", new { id = doce.Id }, doce);
        }

        // DELETE: api/Doces/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoce(Guid id)
        {
            var doce = await _context.Doce.FindAsync(id);
            if (doce == null)
            {
                return NotFound();
            }

            _context.Doce.Remove(doce);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DoceExists(Guid id)
        {
            return _context.Doce.Any(e => e.Id == id);
        }
    }
}
