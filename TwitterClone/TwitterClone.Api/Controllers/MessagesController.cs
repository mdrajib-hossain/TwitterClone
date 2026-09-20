using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class MessagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
