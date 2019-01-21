using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TravelExpertsClasses
{
    public static class TravelPackageDB
    {
        public static List<TravelPackage> GetTavelPackage()
        {
            List<TravelPackage> packages = new List<TravelPackage>(); // empty list of Packages
            TravelPackage travelPackage;
            SqlConnection dbConnect = TravelExpertsDB.GetConnection();
            string selectQuery = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                                  "FROM Packages";
            SqlCommand cmd = new SqlCommand(selectQuery, dbConnect);
            try
            {
                dbConnect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    travelPackage = new TravelPackage();
                    travelPackage.PkgID = (int)reader["PackageId"];
                    travelPackage.PkgName = (string)reader["PkgName"];
                    travelPackage.PkgStartDate = (DateTime)reader["PkgStartDate"];
                    travelPackage.PkgEndDate = (DateTime)reader["PkgEndDate"];
                    travelPackage.PkgDesc = (string)reader["PkgDesc"];
                    travelPackage.PkgBasePrice = (reader["PkgBasePrice"]).ToString();
                    travelPackage.PkgAgencyCommission = (reader["PkgAgencyCommission"]).ToString();
                    packages.Add(travelPackage);
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbConnect.Close();
            }
            return packages;
        }
        public static void AddPackage(TravelPackage tp)
        {
            SqlConnection dbConnect = TravelExpertsDB.GetConnection();
            string insertPackage = "INSERT INTO [Packages] ([PkgName], [PkgStartDate], [PkgEndDate], [PkgDesc], [PkgBasePrice], [PkgAgencyCommission]) " +
                                   "VALUES(@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";
            SqlCommand cmd = new SqlCommand(insertPackage, dbConnect);
            cmd.Parameters.AddWithValue("@PkgName", tp.PkgName);
            cmd.Parameters.AddWithValue("@PkgStartDate", tp.PkgStartDate);
            cmd.Parameters.AddWithValue("@PkgEndDate", tp.PkgEndDate);
            cmd.Parameters.AddWithValue("@PkgDesc", tp.PkgDesc);
            cmd.Parameters.AddWithValue("@PkgBasePrice", tp.PkgBasePrice);
            cmd.Parameters.AddWithValue("@PkgAgencyCommission", tp.PkgAgencyCommission);
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
