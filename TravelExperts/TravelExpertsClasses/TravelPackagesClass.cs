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
      
      
      
      
      
        Note: need to add:
 
        List<TravelPackage> travelPackage = new List<TravelPackage>(); // empty list of travelPackage

        to the start of the Form
    */

    // Travel Packages Class
    public class TravelPackage
    {
        // Private data for packages class
        private string pkgName;
        private string pkgStartDate;
        private string pkgEndDate;
        private string pkgDesc;
        private decimal pkgBasePrice;
        private decimal pkgAgencyCommission;

        // Public getters and setters
        public string PkgName
        {
            get { return pkgName; }
            set { pkgName = value; }
        }

        public string PkgStartDate
        {
            get { return pkgStartDate; }
            set { pkgStartDate = value; }
        }

        public string PkgEndDate
        {
            get { return pkgEndDate; }
            set { pkgEndDate = value; }
        }

        public string PkgDesc
        {
            get { return pkgDesc; }
            set { pkgDesc = value; }
        }

        public decimal PkgBasePrice
        {
            get { return pkgBasePrice; }
            set { pkgBasePrice = value; }
        }

        public decimal PkgAgencyCommission
        {
            get { return pkgAgencyCommission; }
            set { pkgAgencyCommission = value; }
        }

        // constructors
        public TravelPackage (string name, string start, string end, string desc, decimal price, decimal commish)
        {
            PkgName = name;
            PkgStartDate = start;
            PkgEndDate = end;
            PkgDesc = PkgDesc;
            PkgBasePrice = price;
            PkgAgencyCommission = commish;
        }

        // Methods

        //write to file string method
        public string ToFileString()
        {
            return pkgName.ToString() + "," +
                pkgStartDate + "," +
                pkgEndDate.ToString() + "," +
                pkgDesc.ToString() + "," +
                pkgBasePrice.ToString() + "," +
                pkgAgencyCommission.ToString();
        }
    }
}
