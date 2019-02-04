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
            //if (Validator.IsProvided(txtPkgName, "Package Name ") &&
            //Validator.IsProvided(txtPkgDesc, "Package Description ") &&
            //Validator.IsProvided(txtPkgBasePrice, "Package Base Price ") &&
            //Validator.IsProvided(txtPkgAgncCommish, "Package Commission "))

            if (Validator.IsProvided(txtPkgName, "Package Name") &&
            Validator.IsProvided(txtPkgDesc, "Package Description") &&
            Validator.IsProvided(txtPkgBasePrice, "Package Base Price") &&
            Validator.IsNonNegativeMoney(txtPkgBasePrice, "Package Base Price"))
                {
                if (dtpStartDate.Value < dtpEndDate.Value)
                {
                    // get input fields
                    string pkgName = txtPkgName.Text;
                    DateTime pkgStartDate = dtpStartDate.Value;
                    DateTime pkgEndDate = dtpEndDate.Value;
                    string pkgDesc = txtPkgDesc.Text;
                    decimal pkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                    decimal pkgAgncCommish = 0;
                    if (txtPkgAgncCommish.Text == "")
                    {
                        txtPkgAgncCommish.Text = null;
                    }
                    else
                    {
                        pkgAgncCommish = Convert.ToDecimal(txtPkgAgncCommish.Text);
                    }
                    //decimal pkgAgncCommish = Convert.ToDecimal(txtPkgAgncCommish.Text);
                
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
                    txtPkgDesc.Text = "";
                    txtPkgBasePrice.Text = "";
                    txtPkgAgncCommish.Text = "";

                    displayPackages();
                }
                else
                {
                    MessageBox.Show("The Start Date must be before the End Date");
                }
            }
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
                lvi.SubItems.Add(package.PkgBasePrice.ToString("c"));
                lvi.SubItems.Add(package.PkgAgencyCommission.ToString("c"));
                lstPackages.Items.Add(lvi);
                i++;
            }
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
            displayPackages();
            dtpStartDate.MinDate = DateTime.Today;
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
