using Microsoft.AspNetCore.Mvc;

namespace AgriLink.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult GetHello()
        {
            return Ok("Hello, AgriLink backend is working 🚀");
        }
    }
}
