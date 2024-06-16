using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_MySql_ASP.NET.Context;
using API_MySql_ASP.NET.Models;

namespace API_MySql_ASP.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActoresController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ActoresController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Actores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actores>>> GetActores()
        {
            return await _context.Actores.ToListAsync();
        }

        // GET: api/Actores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Actores>> GetActores(int id)
        {
            var actores = await _context.Actores.FindAsync(id);

            if (actores == null)
            {
                return NotFound();
            }

            return actores;
        }

        // PUT: api/Actores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActores(int id, Actores actores)
        {
            if (id != actores.actor_id)
            {
                return BadRequest();
            }

            _context.Entry(actores).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActoresExists(id))
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

        // POST: api/Actores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Actores>> PostActores(Actores actores)
        {
            _context.Actores.Add(actores);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActores", new { id = actores.actor_id }, actores);
        }

        // DELETE: api/Actores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActores(int id)
        {
            var actores = await _context.Actores.FindAsync(id);
            if (actores == null)
            {
                return NotFound();
            }

            _context.Actores.Remove(actores);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ActoresExists(int id)
        {
            return _context.Actores.Any(e => e.actor_id == id);
        }
    }
}
