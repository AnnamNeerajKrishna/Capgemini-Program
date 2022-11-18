using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2sample.Controllers.Models;

namespace WebApplication2sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("{id}")]
        public string get()
        {
            return "Hello World";
        }
        [HttpGet("add/{days}")] 
        public string GetDateTime(int id)
        {
            return DateTime.Now.ToString(); 
        }
        [HttpGet("frlyused/{id}")]
        public IActionResult frlyused(int id = 0)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            if (id < 10)
            {
                return NotFound();
            }
            var obj = new { id = id, Name ="Neeraj" };
            return Ok(obj);
        }
        [HttpGet("  /{id}")]
        public IActionResult GetProductDetails(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            if (id < 10)
            {
                return NotFound();
            }
            var obj = new Product{ ProductId = id, ProductName = "Neeraj" };
            return Ok(obj);
        }
    }
}
