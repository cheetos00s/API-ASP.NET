//------------------------------------------------------------------------------
// <written-by>
//     This code was written by David Cardenas.
//     © 2024 David Cardenas. All rights reserved.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </written-by>
//------------------------------------------------------------------------------

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
    /// <summary>
    /// API controller for managing actors.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ActoresController : ControllerBase
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ActoresController"/> class.
        /// </summary>
        /// <param name="context">The database context to be used by the controller.</param>
        public ActoresController(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets a list of all actors.
        /// </summary>
        /// <returns>A list of <see cref="Actores"/> objects.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actores>>> GetActores()
        {
            try
            {
                return await _context.Actores.ToListAsync();
            }
            catch (Exception ex)
            {
                // Log the exception (ex) as needed
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving the data.");
            }
        }

        /// <summary>
        /// Gets a specific actor by ID.
        /// </summary>
        /// <param name="id">The ID of the actor.</param>
        /// <returns>The <see cref="Actores"/> object with the specified ID.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Actores>> GetActores(int id)
        {
            try
            {
                var actores = await _context.Actores.FindAsync(id);

                if (actores == null)
                {
                    return NotFound();
                }

                return actores;
            }
            catch (Exception ex)
            {
                // Log the exception (ex) as needed
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving the data.");
            }
        }

        /// <summary>
        /// Updates an existing actor.
        /// </summary>
        /// <param name="id">The ID of the actor to update.</param>
        /// <param name="actores">The updated actor object.</param>
        /// <returns>An <see cref="IActionResult"/> indicating the result of the operation.</returns>
        /// <remarks>To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754</remarks>
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
            catch (Exception ex)
            {
                // Log the exception (ex) as needed
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while updating the data.");
            }

            return NoContent();
        }

        /// <summary>
        /// Creates a new actor.
        /// </summary>
        /// <param name="actores">The actor object to create.</param>
        /// <returns>The created <see cref="Actores"/> object.</returns>
        /// <remarks>To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754</remarks>
        [HttpPost]
        public async Task<ActionResult<Actores>> PostActores(Actores actores)
        {
            try
            {
                _context.Actores.Add(actores);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetActores", new { id = actores.actor_id }, actores);
            }
            catch (Exception ex)
            {
                // Log the exception (ex) as needed
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while creating the data.");
            }
        }

        /// <summary>
        /// Deletes an existing actor.
        /// </summary>
        /// <param name="id">The ID of the actor to delete.</param>
        /// <returns>An <see cref="IActionResult"/> indicating the result of the operation.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActores(int id)
        {
            try
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
            catch (Exception ex)
            {
                // Log the exception (ex) as needed
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while deleting the data.");
            }
        }

        /// <summary>
        /// Checks if an actor exists.
        /// </summary>
        /// <param name="id">The ID of the actor to check.</param>
        /// <returns>True if the actor exists; otherwise, false.</returns>
        private bool ActoresExists(int id)
        {
            try
            {
                return _context.Actores.Any(e => e.actor_id == id);
            }
            catch (Exception ex)
            {
                // Log the exception (ex) as needed
                throw new Exception("An error occurred while checking if the actor exists.", ex);
            }
        }
    }
}
