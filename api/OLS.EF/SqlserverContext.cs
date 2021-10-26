using Microsoft.EntityFrameworkCore;
using OLS.Models;

namespace OLS.EF
{
    public class SqlserverContext : DbContext
    {

        public SqlserverContext(DbContextOptions<SqlserverContext> options)
            : base(options)
        {

        }

        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>().HasData(
                new UserInfo
                {
                    Id = 1,
                    UserName = "李明航",
                    Account = "kevin.minghnag.li@outlook.com",
                    Password = "123456",
                    Gender = "1",
                    Tel = "19923985290",
                    IsActive = "1"
                }
                );
            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = 1,
                RoleValue = "1",
                RoleName = "用户",
                Describe = "普通用户"
            },
            new Role
            {
                Id = 2,
                RoleValue = "2",
                RoleName = "管理员",
                Describe = "权限：所有"
            });
            modelBuilder.Entity<UserRole>().HasData(new UserRole
            {
                Id = 1,
                UserId = 1,
                RoleId = 1
            });
        }
    }
}