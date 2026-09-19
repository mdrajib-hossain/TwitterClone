using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Properties.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class TwittersController : ControllerBase
    {


        private readonly IConfiguration _configuration;


        public TwittersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [HttpGet]
        public IActionResult GetTweets()
        {
            var tweets = new List<Tweet>
            {
                new Tweet("My first tweet"){ 
                    UserId = Guid.NewGuid(),
                    Content = "Hello, world!"
                },
                new Tweet("My second tweet"){
                    UserId = Guid.NewGuid(),
                    Content = "This is a tweet from the Twitter clone API."
                },

            };


            return Ok(tweets);
        }


    }   
}
