using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Properties.Controller
{

    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class LikesController : ControllerBase
    {
      
        [HttpGet]
        public IActionResult GetLikes()
        {
            // For demonstration purposes, we'll return a static list of likes.
            var likes = new List<object>
            {
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid(), CreatedAt = DateTime.UtcNow },
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid(), CreatedAt = DateTime.UtcNow },
                new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid(), CreatedAt = DateTime.UtcNow }
            };
            return Ok(likes);
        }


    }
}
