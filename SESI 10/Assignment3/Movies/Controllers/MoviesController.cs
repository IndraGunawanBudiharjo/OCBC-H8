using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies.Data;
using Movies.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;


namespace Movies.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MoviesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public MoviesController(ApiDbContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var movies = await _context.Movies.ToListAsync();
            return Ok(movies);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(MovieData data)
        {
            if(ModelState.IsValid)
            {
                await _context.Movies.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new {data.Id}, data);
            }

            return new JsonResult("Something went wrong") {StatusCode = 500};
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);

            if(movie == null)
                return NotFound();

            return Ok(movie);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, MovieData movie)
        {
            if(id != movie.Id)
                return BadRequest();

            var existItem = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);

            if(existItem == null)
                return NotFound();

            existItem.Name = movie.Name;
            existItem.Genre = movie.Genre;
            existItem.Duration = movie.Duration;
            existItem.ReleaseDate = movie.ReleaseDate;

            // Implement the changes on the database level
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);

            if(existItem == null)
                return NotFound();

            _context.Movies.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok(existItem);
        }

    }
}