using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Properties.Controller
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
