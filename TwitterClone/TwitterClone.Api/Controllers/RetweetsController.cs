using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class RetweetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
