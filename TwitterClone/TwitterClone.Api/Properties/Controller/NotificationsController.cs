using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Properties.Controller
{

    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class NotificationsController : ControllerBase
    {


        [HttpGet]
        public IActionResult GetNotifications()
        {
            // For demonstration purposes, we'll return a static list of notifications.
            var notifications = new List<object>
            {
                new { Id = Guid.NewGuid(), Type = "Like", Message = "User A liked your tweet.", IsRead = false },
                new { Id = Guid.NewGuid(), Type = "Follow", Message = "User B started following you.", IsRead = true },
                new { Id = Guid.NewGuid(), Type = "Mention", Message = "User C mentioned you in a tweet.", IsRead = false }
            };
            return Ok(notifications);
        }

    }
}
