using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Properties.Controller
{

    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class MessagesController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetMessages()
        {
            // For demonstration purposes, we'll return a static list of messages.
            var messages = new List<object>
                {
                    new { Id = Guid.NewGuid(), SenderId = Guid.NewGuid(), ReceiverId = Guid.NewGuid(), Content = "Hello!", CreatedAt = DateTime.UtcNow },
                    new { Id = Guid.NewGuid(), SenderId = Guid.NewGuid(), ReceiverId = Guid.NewGuid(), Content = "How are you?", CreatedAt = DateTime.UtcNow },
                    new { Id = Guid.NewGuid(), SenderId = Guid.NewGuid(), ReceiverId = Guid.NewGuid(), Content = "Goodbye!", CreatedAt = DateTime.UtcNow }
                };
            return Ok(messages);
        }

    }
}
