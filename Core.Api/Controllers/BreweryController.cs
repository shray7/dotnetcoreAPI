using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.DataLayer;
using Core.Models;

namespace Core.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BreweryController : Controller
    {
        private readonly CoreContext _context;

        public BreweryController(CoreContext context)
        {
            _context = context;
        }

        // GET: api/Breweries
        [HttpGet]
        public IEnumerable<Brewery> GetBrewery()
        {
            return _context.Brewery;
        }

        // GET: api/Breweries/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrewery([FromRoute] int id)
        {

            var brewery = await _context.Brewery.SingleOrDefaultAsync(m => m.BreweryId == id);

            return Ok(brewery);
        }

        // PUT: api/Breweries/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBrewery([FromRoute] int id, [FromBody] Brewery brewery)
        {
             if (id != brewery.BreweryId)
            {
                return BadRequest();
            }

            _context.Entry(brewery).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Brewery.Any(e => e.BreweryId == id))
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

        // POST: api/Breweries
        [HttpPost]
        public async Task<IActionResult> PostBrewery([FromBody] Brewery brewery)
        {
            var breweries = _context.Brewery;
            breweries.Add(brewery);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBrewery", new { id = brewery.BreweryId }, brewery);
        }

        // DELETE: api/Breweries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrewery([FromRoute] int id)
        {
            var brewery = await _context.Brewery.SingleOrDefaultAsync(m => m.BreweryId == id);

            _context.Brewery.Remove(brewery);
            await _context.SaveChangesAsync();

            return Ok(brewery);
        }
    }
}