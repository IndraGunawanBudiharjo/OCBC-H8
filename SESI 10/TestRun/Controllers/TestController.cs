using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace TestRun.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [Route("TestRun")]
        [HttpGet]

        public ActionResult TestRun()
        {
            return Ok("success");
        }

    }
}