using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsClasses;

namespace TravelExperts
{
    /* Project 2 Group 1 
     * Date: January 2019
     * Creators: Nathan Armstrong, Abel Rojas Bueno, James Sharpe, Manish Sudani
     * Basic layout: Nathan Armstrong
     * 
     */
    public partial class Packages_Products_Suppliers : Form
    {

        List<TravelPackage> packages = new List<TravelPackage>();
        List<ProductSuppliers> ProSups = new List<ProductSuppliers>();
        List<string> CorProSups = new List<string>();

        int selectedProSup = 0;
        int selectedPackage = 0;
        
        public Packages_Products_Suppliers()
        {
            InitializeComponent();
        }
        // Link the selected items from the list box and append to DB
        private void btnLink_Click(object sender, EventArgs e)
        {
           if(PackageProductSupplierDB.LinkPackageProductSuppliers(selectedProSup, selectedPackage))
            {
                MessageBox.Show("Product and Supplier linked to Package");
            }
            else
            {
                MessageBox.Show("Linked Failed");
            }
            cbPackage.Text = "";
            cbPackage.SelectedValue = null;
            cbProSup.Text = "";
            cbProSup.SelectedValue = null;
            listPackages();
            listProSup();
            btnLink.Enabled = false;
        }
        // On load get all related info and append to list, then display all packages and Product_Suppliers from lists
        private void Packages_Products_Suppliers_Load(object sender, EventArgs e)
        {
            btnLink.Enabled = false;
            listPackages();
            listProSup();

            cbPackage.ContextMenu = new ContextMenu();
            cbProSup.ContextMenu = new ContextMenu();
        }
        //Display all packages from list
        private void listPackages()
        {
            cbPackage.Items.Clear();
            packages = TravelPackageDB.GetTavelPackage();
            foreach (TravelPackage package in packages)
            {
                cbPackage.Items.Add(package.PkgName);
            }
                
            }
        //Display all Product_Suppliers from list
        private void listProSup()
        {
            cbProSup.Items.Clear();
            ProSups = ProductSuppliersDB.GetProductSuppliers();
            foreach(ProductSuppliers ProSup in ProSups)
            {
                cbProSup.Items.Add(ProSup.ProdName + " - " + ProSup.SupName);
            }
            // TODO: Get all packages from list and display in list box
        }
        private void displayProSup()
        {
            lsbPackageProducts.Items.Clear();
            foreach (string CorProSup in CorProSups)
            {
                lsbPackageProducts.Items.Add(CorProSup);
            }
            
        }
        //Close Application
        //By Nathan Armstrong
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // close this form
        //By nathan Armstrong
        private void btnBackPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            listProSup();
            CorProSups.Clear();
            string select = cbPackage.SelectedItem.ToString();
            List<PackageProductSupplier> corispondingProSup = new List<PackageProductSupplier>();
            foreach (TravelPackage package in packages)
            {
                if(select == package.PkgName)
                {
                    selectedPackage = package.PkgID;
                    corispondingProSup = PackageProductSupplierDB.GetProSup(selectedPackage);
                    foreach (PackageProductSupplier cProSup in corispondingProSup)
                    {
                        foreach (ProductSuppliers ProSup in ProSups)
                        {
                            if (cProSup.ProductSupplierID == ProSup.ProductSupplierId)
                            {
                                cbProSup.Items.Remove(ProSup.ProdName + " - " + ProSup.SupName);
                                CorProSups.Add(ProSup.ProdName + " - " + ProSup.SupName);
                            }  
                        }
                    }
                }
            }
            displayProSup();
            if (selectedProSup > 0)
            {
                btnLink.Enabled = true;
            }
        }

        private void cbProSup_SelectedIndexChanged(object sender, EventArgs e)
        {
            listPackages();
            string select = cbProSup.SelectedItem.ToString();
            List<PackageProductSupplier> corispondingPackage = new List<PackageProductSupplier>();
            foreach (ProductSuppliers ProSup in ProSups)
            {
                string ProSupString = ProSup.ProdName + " - " + ProSup.SupName;
                if (select == ProSupString)
                {
                    selectedProSup = ProSup.ProductSupplierId;
                    corispondingPackage = PackageProductSupplierDB.GetPackage(selectedProSup);
                    foreach(PackageProductSupplier cpack in corispondingPackage)
                    {
                        foreach(TravelPackage pack in packages)
                        {
                            if (cpack.PackageID == pack.PkgID)
                            {
                                cbPackage.Items.Remove(pack.PkgName);
                            }
                        }
                    }
                }
            }
            if (selectedPackage > 0)
            {
                btnLink.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbPackage.Text = "";
            cbProSup.Text = "";
            lsbPackageProducts.Items.Clear();
            btnLink.Enabled = false;
        }

        private void cbProSup_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private void cbPackage_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private void cbPackage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbProSup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        
    }
}
