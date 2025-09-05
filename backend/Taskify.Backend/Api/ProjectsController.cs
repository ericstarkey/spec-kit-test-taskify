using Microsoft.AspNetCore.Mvc;
using Taskify.Backend.Models;
using Taskify.Backend.Services;

namespace Taskify.Backend.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectService _service = new();

        [HttpPost]
        public IActionResult Post([FromBody] Project project)
        {
            var created = _service.CreateProject(project);
            return CreatedAtAction(nameof(Post), new { id = created.Id }, created);
        }
    }
}
