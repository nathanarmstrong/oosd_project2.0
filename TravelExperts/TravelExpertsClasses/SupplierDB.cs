using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClasses
{
    public static class SupplierDB
    {
        public static List<Supplier> GetSuppliers()
        {

            List<Supplier> suppliers = new List<Supplier>(); // empty list
            Supplier sup; // for reading
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectQuery = "SELECT SupplierId, SupName FROM dbo.Suppliers ORDER BY SupName";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            try
            {

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sup = new Supplier();
                        sup.SupplierId = (int)reader["SupplierId"];
                        sup.SupName = (string)reader["SupName"];
                      

                        suppliers.Add(sup); // add the new order object to the list
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return suppliers;
        }

    }
}
