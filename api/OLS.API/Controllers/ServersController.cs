using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OLS.Models;
using OLS.EF;

namespace OLS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServersController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        private readonly SqlserverContext _context;


        [HttpGet]
        [Route("GetUsers")]
        public IEnumerable<UserInfo> GetUsers()
        {
            var users = _context.UserInfos.ToList();
            return users;
        }

    }
}
