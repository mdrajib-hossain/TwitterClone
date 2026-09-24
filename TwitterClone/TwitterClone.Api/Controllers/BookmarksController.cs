using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class BookmarksController : Controller
    {



        [HttpGet] // <-- Add this attribute
        public IActionResult Index()
        {
            return Ok("Bookmarks endpoint working");
        }


    }
}
