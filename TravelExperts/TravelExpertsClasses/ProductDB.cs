using System;
using System.Collections.Generic;
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
                    prod.ProductId = reader["ProductId"].ToString();
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
    }
}
