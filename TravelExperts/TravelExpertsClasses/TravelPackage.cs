using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClasses
{
    /* 
        Author: James Sharpe

        Current version - 1.0
            version:
                 v1.0 - Januray 6, 2018
                 v1.1 - January 8, 2018
                 
                 v1.0 - Created Travel Package class and FileIO for future testing
                 v1.1 - Debugged Visual Studio bug causing compiling error.  No change to code :0
                 
      
      
      
      
      
        
    */

    // Travel Packages Class
    public class TravelPackage
    {
        // Private data for packages class
        private int pkgID;
        private string pkgName;
        private DateTime pkgStartDate;
        private DateTime pkgEndDate;
        private string pkgDesc;
        private string pkgBasePrice;
        private string pkgAgencyCommission;

        // Public getters and setters
        public int PkgID
        {
            get { return pkgID; }
            set { pkgID = value; }
        }
        public string PkgName
        {
            get { return pkgName; }
            set { pkgName = value; }
        }

        public DateTime PkgStartDate
        {
            get { return pkgStartDate; }
            set { pkgStartDate = value; }
        }

        public DateTime PkgEndDate
        {
            get { return pkgEndDate; }
            set { pkgEndDate = value; }
        }

        public string PkgDesc
        {
            get { return pkgDesc; }
            set { pkgDesc = value; }
        }

        public string PkgBasePrice
        {
            get { return pkgBasePrice; }
            set { pkgBasePrice = value; }
        }

        public string PkgAgencyCommission
        {
            get { return pkgAgencyCommission; }
            set { pkgAgencyCommission = value; }
        }

        // constructors
        //public TravelPackage (decimal ID, string name, string start, string end, string desc, decimal price, decimal commish)
        //{
        //    PkgID = ID;
        //    PkgName = name;
        //    PkgStartDate = start;
        //    PkgEndDate = end;
        //    PkgDesc = PkgDesc;
        //    PkgBasePrice = price;
        //    PkgAgencyCommission = commish;
        //}

        // Methods

        //write to file string method
        public string ToFileString()
        {
            return pkgName.ToString() + "," +
                pkgStartDate.ToString() + "," +
                pkgEndDate.ToString() + "," +
                pkgDesc.ToString() + "," +
                pkgBasePrice.ToString() + "," +
                pkgAgencyCommission.ToString();
        }
    }
}
