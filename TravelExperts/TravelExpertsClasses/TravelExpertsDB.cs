using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TravelExpertsClasses
{
    /*
        Co-Authors: Nathan Armstrong, Abel Rojas Bueno, James Sharpe, Manish Sudani
    */
    public static class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        { 
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\app_data\TravelExperts.mdf; Integrated Security=True;";

            // old connection strings

            //string for bd from web app
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\746162\Desktop\Online\Online\App_Data\TravelExperts.mdf;Integrated Security=True;";

            //string for local source
            //string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=TravelExperts;Integrated Security=True";
            //string connectionString = @"Data Source=localhost;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
        

    }
}
