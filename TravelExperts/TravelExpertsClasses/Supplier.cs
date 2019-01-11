using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsClasses
{
    //public class supplier
    public class Supplier

    {
        private int supplierId;
        private string supplierName;


        //public getters and setters
        public int SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }

        public string SupplierName
        {
            get { return supplierName; }
            set { supplierName = value; }
        }


        // constructors
        public Supplier(int id, string name)
        {
            SupplierId = id;
            SupplierName = name;
        }

        public string SupplierInfo
        {
            get
            {
                // returns "Supplier Id - SupplierName"
                return $"{ SupplierId } - { SupplierName }";
            }
        }
    }
}

    

