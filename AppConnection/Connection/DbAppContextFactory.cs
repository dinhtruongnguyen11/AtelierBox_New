using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using System.Text;

namespace AppConnection.Connection
{
    public class DbAppContextFactory : IDesignTimeDbContextFactory<DbAppContext>
    {
        public DbAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbAppContext>();
            if(args.Length > 0)
            {
                optionsBuilder.UseSqlite(args[0]);
                return new DbAppContext(optionsBuilder.Options, args[0]);
            }
            optionsBuilder.UseSqlite("Data source = AtelierDB.sqlite");
            return new DbAppContext(optionsBuilder.Options, "Data source = AtelierDB.sqlite");
        }
    }
}
