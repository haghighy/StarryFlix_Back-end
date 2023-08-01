using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarryFlix.Models;
using StarryFlix.Models.Databases;

namespace StarryFlix.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        [HttpGet]
        [Route("[action]")]
        public IActionResult List()
        {
            using var context = new StarryFlixContext();
            var directors = context.Directors.ToList();
            return Ok(directors);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Create(DirectorCreateModel data)
        {
            using var context = new StarryFlixContext();
            var directors = context.Directors.ToList();
            return Ok(directors);
        }
    }
}
