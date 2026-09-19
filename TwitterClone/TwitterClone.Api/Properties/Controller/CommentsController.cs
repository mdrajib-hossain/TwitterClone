using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Properties.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CommentsController : ControllerBase
    {

        [HttpGet]

        public IActionResult GetComments()
        {
            // For demonstration purposes, we'll return a static list of comments.
            var comments = new List<object>
            {
                new { Id = Guid.NewGuid(), TweetId = Guid.NewGuid(), UserId = Guid.NewGuid(), Content = "Great tweet!", CreatedAt = DateTime.UtcNow },
                new { Id = Guid.NewGuid(), TweetId = Guid.NewGuid(), UserId = Guid.NewGuid(), Content = "I totally agree!", CreatedAt = DateTime.UtcNow },
                new { Id = Guid.NewGuid(), TweetId = Guid.NewGuid(), UserId = Guid.NewGuid(), Content = "Thanks for sharing!", CreatedAt = DateTime.UtcNow }
            };
            return Ok(comments);
        }
    }
}
