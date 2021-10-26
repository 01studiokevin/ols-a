using Microsoft.AspNetCore.Mvc;

namespace OLS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServerController : ControllerBase
    {
       
        private readonly ILogger<ServerController> _logger;

        public ServerController(ILogger<ServerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Login() 
        {


            return Content("");
        }

    }
}