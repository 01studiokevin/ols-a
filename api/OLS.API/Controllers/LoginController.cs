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
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        private readonly SqlserverContext _context;

        public LoginController(ILogger<LoginController> logger, SqlserverContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<UserInfo> Login(string account, string pwd)
        {
            var users = _context.UserInfos.Where(i => i.Account == account);
            return users;
        }

        [HttpGet]
        [Route("GetUsers")]
        public IEnumerable<UserInfo> GetUsers()
        {
            var users = _context.UserInfos.ToList();
            return users;
        }

    }
}
