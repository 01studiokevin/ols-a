using OLS.Models;
using OLS.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLS.IUtils
{
    public interface ITool
    {
        string SerializeObject(object obj);
        List<RMasterMenu> MasterMenuToRMasterMenu(List<MasterMenu> menus);
        void FindSubMenu(List<RMasterMenu> rootMenu, List<MasterMenu> menus);
    }
}
