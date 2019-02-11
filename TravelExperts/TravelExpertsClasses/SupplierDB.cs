using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClasses
{
    /* Project 2 Group 1 
     * Date: January 2019
     * Author: Nathan Armstrong and James Sharpe
     * Co-author: Manish Sudani
     */
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
        public static int AddSupplier(Supplier supplier)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO Suppliers (Supplierid, SupName) " +
                                     "VALUES(@supID, @Name)";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@Name", supplier.SupName);
            cmd.Parameters.AddWithValue("@supID", SupplierDB.GetSuppliers().Count());
            try
            {
                con.Open();
                cmd.ExecuteNonQuery(); // run the insert command
                string selectQuery = "SELECT IDENT_CURRENT('Suppliers') FROM Suppliers";
                SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                int supplierId = SupplierDB.GetSuppliers().Count(); // single value
                return supplierId;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public static void DeleteSupplier(string supplier)
        {
            SqlConnection dbConnect = TravelExpertsDB.GetConnection();
            string deletePackage = "DELETE FROM [Suppliers] " +
                                   "WHERE SupName = @SupName";
            SqlCommand cmd = new SqlCommand(deletePackage, dbConnect);
            cmd.Parameters.AddWithValue("@SupName", supplier);
            try
            {
                dbConnect.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbConnect.Close();
            }
        }
        public static bool UpdateSupplier(string oldSup, string newSup)
        {
            bool success = false;
            SqlConnection dbConnect = TravelExpertsDB.GetConnection();
            string updateSupplier = "UPDATE Suppliers " +
                                    "SET SupName = @SupName " +
                                    "WHERE SupName = @oldSupId ";
            SqlCommand cmd = new SqlCommand(updateSupplier, dbConnect);
            cmd.Parameters.AddWithValue("@SupName", newSup);
            cmd.Parameters.AddWithValue("@oldSupId", oldSup);
            try
            {
                dbConnect.Open();
                cmd.ExecuteNonQuery();
                success = true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbConnect.Close();
            }
            return success;
        }
    }
}
