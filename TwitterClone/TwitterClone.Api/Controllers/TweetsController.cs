

using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TweetsController : ControllerBase
    {
        // GET: api/tweets
        [HttpGet]
        public IActionResult GetTweets()
        {
            var tweets = new List<Tweet>
            {
                new Tweet("Tweet 1"),
                new Tweet("Tweet 2")
            };

            var likeNotification = new LikeNotification(new Guid());

            return Ok(tweets);
        }
    }
}
