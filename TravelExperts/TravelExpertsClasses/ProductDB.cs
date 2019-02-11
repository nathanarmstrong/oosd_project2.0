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
     * Author: Abel Rojas Bueno
     * Co-Author: Nathan Armstrong and James Sharpe
     */
    public static class ProductDB
    {
        // get products from db
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT ProductId, ProdName "
                                   + "FROM Products "
                                   + "ORDER BY ProductId";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Product prod = new Product();
                    prod.ProductId = (int)reader["ProductId"];
                    prod.ProdName = reader["ProdName"].ToString();
                    products.Add(prod);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return products;
        }

        // add product to db
        public static int AddProduct(Product product)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO Products (ProdName) " +
                                     "VALUES(@Name)";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@Name", product.ProdName);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery(); // run the insert command
                // get the generated ID - current identity value for  Customers table
                string selectQuery = "SELECT IDENT_CURRENT('Products') FROM Products";
                SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                int productId = Convert.ToInt32(selectCmd.ExecuteScalar()); // single value
                return productId;
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

        // delete product from db
        public static void DeleteProduct(string product)
        {
            SqlConnection dbConnect = TravelExpertsDB.GetConnection();
            string deletePackage = "DELETE FROM [Products] " +
                                   "WHERE ProdName = @ProdName";
            SqlCommand cmd = new SqlCommand(deletePackage, dbConnect);
            cmd.Parameters.AddWithValue("@ProdName", product);
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

        // update product to db
        public static bool UpdateProduct(string oldProd, string newProd)
        {
            bool success = false;
            SqlConnection dbConnect = TravelExpertsDB.GetConnection();
            string updateProduct = "UPDATE Products " +
                                    "SET ProdName = @ProdName " +
                                    "WHERE ProdName = @oldProdId ";
            SqlCommand cmd = new SqlCommand(updateProduct, dbConnect);
            cmd.Parameters.AddWithValue("@ProdName", newProd);
            cmd.Parameters.AddWithValue("@oldProdId", oldProd);
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
