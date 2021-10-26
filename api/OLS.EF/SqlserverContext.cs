using Microsoft.EntityFrameworkCore;
using OLS.Models;

namespace OLS.EF
{
    public class SqlserverContext:DbContext 
    {

        public SqlserverContext(DbContextOptions<SqlserverContext> options)
            :base(options)
        {

        }

        public DbSet<UserInfo>? UserInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>().ToTable("UserInfo");
        }
    }
}