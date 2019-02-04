﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClasses
{
    public static class ProductDB
    {
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
    }
}
