using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClasses
{
    public class ProductSuppliersDB
    {
        public static List<ProductSuppliers> GetProductSuppliers()
        {
            List<ProductSuppliers> ProSups = new List<ProductSuppliers>();
            ProductSuppliers ProSup;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectQuery = "Select SP.ProductSupplierId, SP.ProductId, P.ProdName, S.SupName, SP.SupplierId " +
                "from Products P " +
                "Join Products_Suppliers SP on P.ProductId = SP.ProductId " +
                "Join Suppliers S on SP.SupplierId = S.SupplierId";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProSup = new ProductSuppliers();
                        ProSup.ProdName = (string)reader["ProdName"];
                        ProSup.ProductSupplierId = (int)reader["ProductSupplierId"];
                        ProSup.SupName = (string)reader["SupName"];
                        ProSup.ProductId = (int)reader["ProductId"];
                        ProSup.SupplierId = (int)reader["SupplierId"];
                        ProSups.Add(ProSup);
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
            return ProSups;
        }
        public static bool LinkProductSuppliers(int SupID, int ProdID)
        {
            bool results = false;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertQuery = "Insert into Products_Suppliers(ProductId, SupplierID) Values (@ProdID, @SupID)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@ProdID", ProdID);
            cmd.Parameters.AddWithValue("@SupID", SupID);
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
        public static List<ProductSuppliers> GetProducts(int SupID)
        {
            List<ProductSuppliers> ProSups = new List<ProductSuppliers>();
            ProSups = GetInfo(SupID, "supplier");
            return ProSups;
        }

        public static List<ProductSuppliers> GetSuppliers(int ProdID)
        {
            List<ProductSuppliers> ProSups = new List<ProductSuppliers>();
            ProSups = GetInfo(ProdID, "Product");
            return ProSups;
        }

        public static List<ProductSuppliers> GetInfo(int ID, string type)
        {
            List<ProductSuppliers> list = new List<ProductSuppliers>();
            ProductSuppliers ProSup;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectQuery;
            if (type == "Product") {
                selectQuery = "Select SP.ProductSupplierId, SP.ProductId, P.ProdName, S.SupName, SP.SupplierId " +
                "from Products P " +
                "Join Products_Suppliers SP on P.ProductId = SP.ProductId " +
                "Join Suppliers S on SP.SupplierId = S.SupplierId " +
                "where SP.ProductId = @prodID";
            }
            else
            {
                selectQuery = "Select SP.ProductSupplierId, SP.ProductId, P.ProdName, S.SupName, SP.SupplierId " +
                "from Suppliers S " +
                "Join Products_Suppliers SP on S.SupplierId = SP.SupplierId " +
                "Join Products P on SP.ProductId = P.ProductId " +
                "where SP.SupplierId = @supID";
            }
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            if(type == "Product")
            {
                cmd.Parameters.AddWithValue("@prodID", ID);
            }
            else
            {
                cmd.Parameters.AddWithValue("@supID", ID);
            }
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProSup = new ProductSuppliers();
                        ProSup.ProdName = (string)reader["ProdName"];
                        ProSup.SupName = (string)reader["SupName"];
                        ProSup.ProductId = (int)reader["ProductId"];
                        ProSup.SupplierId = (int)reader["SupplierId"];
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
    }
}
