using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TravelExpertsClasses
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"192.168.205.135\SQLEXPRESS";
            string database = "dbo";
            string username = "Manish";
            string password = "January2@19";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }

}