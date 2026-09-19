using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Properties.Controller
{

    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class BookmarksController : ControllerBase
    {
        
           [HttpGet]
           public IActionResult GetBookmarks()
        {
            // For demonstration purposes, we'll return a static list of bookmarks.
            var bookmarks = new List<object>
               {
                   new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid(), CreatedAt = DateTime.UtcNow },
                   new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid(), CreatedAt = DateTime.UtcNow },
                   new { Id = Guid.NewGuid(), UserId = Guid.NewGuid(), TweetId = Guid.NewGuid(), CreatedAt = DateTime.UtcNow }
               };
            return Ok(bookmarks);
        }


    }
}
