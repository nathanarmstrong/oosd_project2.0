using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClasses
{
    public class PackageProductSupplierDB
    {
        public static List<PackageProductSupplier> GetPackage(int ID)
        {
            List<PackageProductSupplier> list = new List<PackageProductSupplier>();
            PackageProductSupplier ProSup;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectQuery = "select PackageId, ProductSupplierId from Packages_Products_Suppliers where ProductSupplierId = @ID";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProSup = new PackageProductSupplier();
                        ProSup.PackageID = (int)reader["PackageId"];
                        ProSup.ProductSupplierID = (int)reader["ProductSupplierId"];
                        list.Add(ProSup);
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
            return list;
        }
        public static List<PackageProductSupplier> GetProSup(int ID)
        {
            List<PackageProductSupplier> list = new List<PackageProductSupplier>();
            PackageProductSupplier ProSup;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectQuery = "select PackageId, ProductSupplierId from Packages_Products_Suppliers where PackageId = @ID";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProSup = new PackageProductSupplier();
                        ProSup.PackageID = (int)reader["PackageId"];
                        ProSup.ProductSupplierID = (int)reader["ProductSupplierId"];
                        list.Add(ProSup);
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
            return list;
        }
        public static bool LinkPackageProductSuppliers(int ProSupID, int PackageID)
        {
            bool results = false;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertQuery = "Insert into Packages_Products_Suppliers(PackageId, ProductSupplierId) Values (@PackageID, @ProSupID)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@PackageID", PackageID);
            cmd.Parameters.AddWithValue("@ProSupID", ProSupID);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                results = true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return results;
        }
    }
}
