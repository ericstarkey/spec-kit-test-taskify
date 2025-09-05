using Microsoft.AspNetCore.Mvc;
using Taskify.Backend.Services;

namespace Taskify.Backend.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationsController : ControllerBase
    {
        private readonly NotificationService _service = new();

        [HttpPost]
        public IActionResult Post([FromBody] string message)
        {
            _service.SendNotification(message);
            return Ok();
        }
    }
}
