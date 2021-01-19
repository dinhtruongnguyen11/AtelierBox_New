using AppConnection.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMain.AppCode
{
    public static class DBHelper
    {
        private static string connectionString = "Data Source=AtelierDB.sqlite";
        public static DbAppContext CreateConnection()
        {

            DbAppContext dbAppContext = new DbAppContextFactory().CreateDbContext(new string[] { connectionString, "" });
            return dbAppContext;

        }



    }
}
