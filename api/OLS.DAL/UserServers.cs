using System;
using System.Collections.Generic;
using System.Linq;
using OLS.EF;
using OLS.Models;

namespace OLS.DAL
{
    public class UserServers
    {
        private readonly SqlserverContext _context;
        public UserServers(SqlserverContext context)
        {
            _context = context;
        }


        /// <summary>
        /// get all user
        /// </summary>
        /// <returns>type:user info list</returns>
        public List<UserInfo> GetUsers()
        {
            var users = _context.UserInfos.ToList();
            return users;
        }

        public UserInfo GetUser(int id)
        {
            var user = _context.UserInfos.Find(id);
            return user;
        }

       /* public UserInfo GetUser(string name)
        {
            var user= _context.UserInfos.Where(i=>i.UserName==name).FirstOrDefault();
            return user;
        }*/

        public List<UserInfo> GetUsers(string name)
        {
            var users = _context.UserInfos.Where(i=>i.UserName==name).ToList();
            return users;
        }

        public UserInfo GetUser(string account)
        {
            var user = _context.UserInfos.Where(i => i.Account == account).FirstOrDefault();
            return user;
        }

    }
}
