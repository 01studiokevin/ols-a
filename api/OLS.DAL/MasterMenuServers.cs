using OLS.EF;
using OLS.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLS.DAL
{
    public class MasterMenuServers : IMasterMenuServers
    {
        public MasterMenuServers(SqlserverContext context)
        {
            _context = context;
        }

        private readonly SqlserverContext _context;

        public List<Models.MasterMenu> GetMasterMenus()
        {
            return _context.MasterMenus.ToList();
        }
    }
}
