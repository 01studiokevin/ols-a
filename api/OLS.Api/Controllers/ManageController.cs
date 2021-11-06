using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OLS.IApplication;

namespace OLS.Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ManageController : ControllerBase
    {
        private readonly ILogger<ManageController> _logger;
        private readonly IManageServers _manageServers;
        public ManageController(ILogger<ManageController> logger, IManageServers manageServers)
        {
            this._logger = logger;
            this._manageServers = manageServers;
        }

        [HttpGet]
        public string GetMenu()
        {
            var result = _manageServers.GetMenu();
            return result;
        }

        [HttpGet]
        public string ReturnInput(string str)
        {
            return str;
        }
    }
}
