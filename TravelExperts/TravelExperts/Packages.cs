using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        List<TravelPackage> packages;
        private TravelPackage selectedPackage;

        public Packages()
        {
            InitializeComponent();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
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
            lstPackages.Items.Clear();
            packages = TravelPackageDB.GetTavelPackage();
            int i = 0;
            foreach (TravelPackage package in packages)
            {
                ListViewItem lvi = new ListViewItem(package.PkgID.ToString(), i); // new list view item starting with package name
                lvi.SubItems.Add(package.PkgName);
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
            displayPackages();
            btnDelete.Enabled = false;
            btnEditPackage.Enabled = false;
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
            btnEditPackage.Enabled = true;
            btnDelete.Enabled = true;
            selectedPackage = new TravelPackage();
            selectedPackage.PkgID = Convert.ToInt32(lstPackages.FocusedItem.SubItems[0].Text);
            selectedPackage.PkgName = lstPackages.FocusedItem.SubItems[1].Text;
            selectedPackage.PkgStartDate = Convert.ToDateTime(lstPackages.FocusedItem.SubItems[2].Text);
            selectedPackage.PkgEndDate = Convert.ToDateTime(lstPackages.FocusedItem.SubItems[3].Text);
            selectedPackage.PkgDesc = Convert.ToString(lstPackages.FocusedItem.SubItems[4].Text);
            selectedPackage.PkgBasePrice = Convert.ToDecimal(lstPackages.FocusedItem.SubItems[5].Text.Substring(1));
            selectedPackage.PkgAgencyCommission = Convert.ToDecimal(lstPackages.FocusedItem.SubItems[6].Text.Substring(1));
        }

        private void txtPkgBasePrice_TextChanged(object sender, EventArgs e)
        {
            string previousInput = "";
            Regex r = new Regex(@"[0-9]+(\\.[0-9][0-9]?)?"); // This is the main part, can be altered to match any desired form or limitations
            Match m = r.Match(txtPkgBasePrice.Text);
            if (m.Success)
            {
                previousInput = txtPkgBasePrice.Text;
            }
            else
            {
                txtPkgBasePrice.Text = previousInput;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedPkg = Convert.ToInt32(lstPackages.SelectedItems[0].Text);
            string selectedPkgName = lstPackages.FocusedItem.SubItems[1].Text;

            var confirmDelete = MessageBox.Show("Are you sure you want to delete " + selectedPkgName + "?", "Confirm?", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                try
                {
                    TravelPackageDB.DeletePackage(selectedPkg);
                    MessageBox.Show("Package deleted successfully");
                }
                catch
                {
                    MessageBox.Show("Package could not be deleted, contact the administrator");
                }
                displayPackages();
            }
        }

        private void btnEditPackage_Click(object sender, EventArgs e)
        {
            EditPackage ppsForm = new EditPackage();
            ppsForm.package = selectedPackage;
            ppsForm.Show();
            this.Hide();
            ppsForm.FormClosing += PPS_FormClosing;
        }
    }
}
