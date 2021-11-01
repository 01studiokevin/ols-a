using Microsoft.AspNetCore.Mvc;
using OLS.EF;
using System.Linq;

namespace OLS.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ChannelController : ControllerBase
    {
        private readonly SqlserverContext _context;

        public ChannelController(SqlserverContext context)
        {
            _context = context;
        }

        [HttpGet]
        public string GetCourseGroups()
        {
            var data = _context.CourseGroups.ToList();
            return data.ToString();
        }
    }
}
