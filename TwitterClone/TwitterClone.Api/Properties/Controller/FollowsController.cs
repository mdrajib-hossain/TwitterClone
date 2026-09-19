using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Properties.Controller
{

    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class FollowsController : ControllerBase
    {

    }

}
