using Microsoft.AspNetCore.Mvc;
using Taskify.Backend.Models;
using Taskify.Backend.Services;

namespace Taskify.Backend.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly TaskService _service = new();

        [HttpPost]
        public IActionResult Post([FromBody] Taskify.Backend.Models.Task task)
        {
            var created = _service.CreateTask(task);
            return CreatedAtAction(nameof(Post), new { id = created.Id }, created);
        }
    }
}
