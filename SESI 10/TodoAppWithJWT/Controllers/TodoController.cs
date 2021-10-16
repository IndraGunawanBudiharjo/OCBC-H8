using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoAppWithJWT.Data;
using TodoAppWithJWT.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;


namespace TodoAppWithJWT.Controllers
{
    [Route("api/[controller]")] // define the routing that our controller going to use
    [ApiController] // specify the type of the controller to let .Net core know
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TodoController : ControllerBase
    {
        // [Route("TestRun")] // define the routing for this action
        // [HttpGet]

        //  public ActionResult TestRun()
        // {
        //     return Ok("success");
        // }

        private readonly ApiDbContext _context;
        public TodoController(ApiDbContext context)
        {
            _context = context;
        }
       
        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var items = await _context.Items.ToListAsync();
            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(ItemData data)
        {
            if(ModelState.IsValid)
            {
                await _context.Items.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new {data.id}, data);
            }

            return new JsonResult("Something went wrong") {StatusCode = 500};
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _context.Items.FirstOrDefaultAsync(x => x.id == id);

            if(item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpPut("{id}")] 
        public async Task<IActionResult> UpdateItem(int id, ItemData item)
        {
            if(id != item.id)
                return BadRequest();

            var existItem = await _context.Items.FirstOrDefaultAsync(x => x.id == id);

            if(existItem == null)
                return NotFound();

            existItem.title = item.title;
            existItem.description = item.description;
            existItem.done = item.done;

            await _context.SaveChangesAsync();

            return NoContent();

        }

        [HttpDelete("{id}")] 
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _context.Items.FirstOrDefaultAsync(x => x.id == id);

            if(existItem == null)
                return NotFound();
            
            _context.Items.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok(existItem);
        }

    }
}