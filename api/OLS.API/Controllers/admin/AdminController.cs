using Microsoft.AspNetCore.Mvc;

namespace OLS.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AdminController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "hello admin";
        }
    }
}
