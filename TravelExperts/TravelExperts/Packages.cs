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
    public partial class Packages : Form
    {
        // TODO: Create list Package class called packages
        List<TravelPackage> packages;
        public Packages()
        {
            InitializeComponent();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            // TODO: get all input field.Text and append to packages list then SQL DB
            // get input fields
            string pkgName = txtPkgName.Text;
            DateTime pkgStartDate = dtpStartDate.Value;
            DateTime pkgEndDate = dtpEndDate.Value;
            string pkgDesc = txtPkgDesc.Text;
            decimal pkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
            decimal pkgAgncCommish = Convert.ToDecimal(txtPkgAgncCommish.Text);

            // convert to currency?
            string price = string.Format("{0:C}", pkgBasePrice);
            string commish = string.Format("{0:C}", pkgAgncCommish);

            //create package class
            TravelPackage package = new TravelPackage();
            package.PkgName = pkgName;
            package.PkgStartDate = pkgStartDate;
            package.PkgEndDate = pkgEndDate;
            package.PkgDesc = pkgDesc;
            package.PkgBasePrice = pkgBasePrice;
            package.PkgAgencyCommission = pkgAgncCommish;

            // call insert command
            TravelPackageDB.AddPackage(package);

            // clear fields
            txtPkgName.Text = "";
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            txtPkgDesc.Text = "";
            txtPkgBasePrice.Text = "";
            txtPkgAgncCommish.Text = "";

            displayPackages();
        }
        //Display all packages from list
        private void displayPackages()
        {
            // lists items in list view in specified sub list items
            packages = TravelPackageDB.GetTavelPackage();
            int i = 0;
            foreach (TravelPackage package in packages)
            {
                ListViewItem lvi = new ListViewItem(package.PkgName, i); // new list view item starting with package name
                lvi.SubItems.Add((package.PkgStartDate).ToShortDateString());
                lvi.SubItems.Add((package.PkgEndDate).ToShortDateString());
                lvi.SubItems.Add(package.PkgDesc);
                lvi.SubItems.Add(package.PkgBasePrice.ToString());
                lvi.SubItems.Add(package.PkgAgencyCommission.ToString());
                lstPackages.Items.Add(lvi);
                i++;
            }

            //foreach (TravelPackage package in packages)
            //{
            //    listPackages.Items.Add(package.PkgName + "," + package.PkgDesc);
            //}


            //packages = TravelPackageDB.GetTavelPackage();
            //listPackages.DataSource = packages;

        }
        // Close Application
        // By Nathan Armstrong
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //close this form
        //By Nathan Armstrong
        private void btnBackPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Open new Packages_Products_Suppliers form and hide this one
        // By Nathan Armstrong
        private void btnLinkProSup_Click(object sender, EventArgs e)
        {
            Packages_Products_Suppliers ppsForm = new Packages_Products_Suppliers();
            ppsForm.Show();
            this.Hide();
            ppsForm.FormClosing += PPS_FormClosing;
        }
        // on Packages_Products_Suppliers closing re show this form it is is hidden
        // By Nathan Armstrong
        private void PPS_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        // When form loads get all data from DB and display it
        private void Packages_Load(object sender, EventArgs e)
        {
            // TODO: get all info from DB and append to list of packages
            displayPackages();
        }
    }
}
