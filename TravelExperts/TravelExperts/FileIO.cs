using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsClasses;

namespace TravelExperts
{
    public static class FileIO
    {
        const string path = "testPackage.txt";

        //writes data from the array to the file
        
        public static void WriteData(List<TravelPackage> travelPackage)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                // open the file for writing; overwrite old content
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                // write data
                foreach (TravelPackage tp in travelPackage)
                    sw.WriteLine(tp.ToFileString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while writing to the file: " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (sw != null) sw.Close(); // also closes fs

            }
        }
        

        // reads data from the file and puts in a list and returns it
        // returns number of elements
        public static List<TravelPackage> ReadData()
        {
            List<TravelPackage> travelPackage = new List<TravelPackage>();
            FileStream fs = null;
            StreamReader sr = null;
            string line;  // for reading
            string[] fields; //result from splitting the line
            // open the file for reading and read number into data 
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
                while (!sr.EndOfStream)//while there is data in the file
                {
                    line = sr.ReadLine(); //read the next line
                    fields = line.Split(',');  //split line into fields

                    // call the other contsructor to not re-calculate the charge amount
                    //TravelPackage tp = new TravelPackage(Convert.ToString(fields[0]),
                    //                          Convert.ToString(fields[1]),
                    //                          Convert.ToString(fields[2]),
                    //                          Convert.ToString(fields[3]),
                    //                          Convert.ToDecimal(fields[4]),
                    //                          Convert.ToDecimal(fields[5])
                    //                        );
                    //travelPackage.Add(tp);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("File contains bad format data.  Aborting reading");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while reading the file: " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                //close the file if open
                if (sr != null) sr.Close();     // file stream gets closed too

            }
            return travelPackage;
        }
    }
}