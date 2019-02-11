using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TravelExpertsClasses
{
    /* 
        Author: James Sharpe
    */

    public static class TravelPackageDB
    {
        // get package from db
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
                    travelPackage.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                    travelPackage.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];
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

        //add new package to db
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

        // delete package from the db
        public static void DeletePackage(int tp)
        {
            SqlConnection dbConnect = TravelExpertsDB.GetConnection();
            string deletePackage = "DELETE FROM [Packages] " +
                                   "WHERE PackageId = @PkgID";
            SqlCommand cmd = new SqlCommand(deletePackage, dbConnect);
            cmd.Parameters.AddWithValue("@PkgID", tp);
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

        // update package from the db
        public static bool UpdatePackage(TravelPackage oldPkg, TravelPackage newPkg)
        {
            bool success = false;
            SqlConnection dbConnect = TravelExpertsDB.GetConnection();
            string updatePackage = "UPDATE Packages " +
                                    "SET PkgName = @PkgName, " +
                                        "PkgDesc = @PkgDesc, " +
                                        "PkgStartDate = @PkgStartDate, " +
                                        "PkgEndDate = @PkgEndDate, " +
                                        "PkgBasePrice = @PkgBasePrice, " +
                                        "PkgAgencyCommission = @PkgAgencyCommission " +
                                    "WHERE PackageId = @oldPkgID ";
            SqlCommand cmd = new SqlCommand(updatePackage, dbConnect);
            cmd.Parameters.AddWithValue("@PkgName", newPkg.PkgName);
            cmd.Parameters.AddWithValue("@PkgStartDate", newPkg.PkgStartDate);
            cmd.Parameters.AddWithValue("@PkgEndDate", newPkg.PkgEndDate);
            cmd.Parameters.AddWithValue("@PkgDesc", newPkg.PkgDesc);
            cmd.Parameters.AddWithValue("@PkgBasePrice", newPkg.PkgBasePrice);
            cmd.Parameters.AddWithValue("@PkgAgencyCommission", newPkg.PkgAgencyCommission);
            cmd.Parameters.AddWithValue("@oldPkgID", oldPkg.PkgID);
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
