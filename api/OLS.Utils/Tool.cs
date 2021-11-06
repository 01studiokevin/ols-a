using Newtonsoft.Json;
using OLS.IUtils;
using OLS.Models;
using OLS.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace OLS.Utils
{
    public class Tool : ITool
    {
        /// <summary>
        /// 把对象序列化为Json字符串
        /// </summary>
        /// <param name="obj">被转换的对象</param>
        /// <returns>标准json字符串</returns>
        public string SerializeObject(object obj)
        {
            var result = JsonConvert.SerializeObject(obj);
            return result;
        }

        /// <summary>
        /// 将MasterMenu实体类转换为RMasterMenu实体类
        /// </summary>
        /// <param name="menus"></param>
        /// <returns></returns>
        public List<RMasterMenu> MasterMenuToRMasterMenu(List<MasterMenu> menus)
        {
            List<RMasterMenu> rMasterMenus = new List<RMasterMenu>();
            foreach (var item in menus)
            {
                if (item.Pid == 0)
                {
                    rMasterMenus.Add(Mapper<RMasterMenu, MasterMenu>(item));
                }
            }

            return rMasterMenus;

        }

        /// <summary>
        /// 使用反射将两个实体中相同的属性拷贝到另一个实体类中
        /// </summary>
        /// <typeparam name="D">拷贝后的类型</typeparam>
        /// <typeparam name="S">被拷贝的类别</typeparam>
        /// <param name="s">被拷贝的具体值</param>
        /// <returns>返回拷贝后的实体数据，类型为D</returns>
        public static D Mapper<D, S>(S s)
        {
            D d = Activator.CreateInstance<D>();
            try
            {
                var Types = s.GetType();//获得类型
                var Typed = typeof(D);
                foreach (PropertyInfo sp in Types.GetProperties())//获得类型的属性字段
                {
                    foreach (PropertyInfo dp in Typed.GetProperties())
                    {
                        if (dp.Name == sp.Name)//判断属性名是否相同
                        {
                            dp.SetValue(d, sp.GetValue(s, null), null);//获得s对象属性的值复制给d对象的属性
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return d;
        }

        /// <summary>
        /// 递归查找子菜单
        /// </summary>
        /// <param name="rootMenu">List类型的顶级菜单</param>
        /// <param name="menus">菜单堆</param>
        public void FindSubMenu(List<RMasterMenu> rootMenu, List<MasterMenu> menus)
        {
            //root menu
            foreach (var root in rootMenu)
            {
                List<RMasterMenu> rSubMenus = new List<RMasterMenu>();
                foreach (var sub in menus)//based on root menu
                {
                    //TODO:fix no value
                    if (sub.Pid.Equals(root.Id))//if sub pid eaquls root id ,add sub menu to roo meun
                    {
                        rSubMenus.Add(Mapper<RMasterMenu, MasterMenu>(sub));
                        FindSubMenu(rSubMenus, menus);
                    }
                rSubMenus.Sort((a, b) => a.Seq.CompareTo(b.Seq));
                }
                root.SubMenu = rSubMenus;
            }

        }
    }
}
