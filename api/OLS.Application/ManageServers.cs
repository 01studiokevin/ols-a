using OLS.IApplication;
using OLS.IDAL;
using OLS.IUtils;

namespace OLS.Application
{
    public class ManageServers : IManageServers
    {
        private readonly ITool _tool;
        private readonly IMasterMenuServers _masterMenu;


        public ManageServers(ITool tool,IMasterMenuServers masterMenu)
        {
            this._tool = tool;
            this._masterMenu = masterMenu;
        }

        /// <summary>
        /// 获取管理员后台管理菜单
        /// </summary>
        /// <returns>值：menu tree,格式：standard json string</returns>
        public string GetMenu()
        {
            var data=_masterMenu.GetMasterMenus();
            var rootMenu=_tool.MasterMenuToRMasterMenu(data); 
            _tool.FindSubMenu(rootMenu,data);
            var menus=_tool.SerializeObject(rootMenu);
            return menus;
            
        }
    }
}
