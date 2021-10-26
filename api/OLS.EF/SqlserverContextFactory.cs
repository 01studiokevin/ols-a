using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OLS.EF
{
    public class SqlserverContextFactory : IDesignTimeDbContextFactory<SqlserverContext>
    {

        public SqlserverContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SqlserverContext>();
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ols;User Id=sa;Password=kevin;");

            return new SqlserverContext(optionsBuilder.Options);
        }
    }
}
