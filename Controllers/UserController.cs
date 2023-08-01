using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarryFlix.Models.Databases;

namespace StarryFlix.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("[action]")]
        public IActionResult List()
        {
            using var context = new StarryFlixContext();
            var users = context.Users.ToList();
            return Ok(users);
        }
    }
}
