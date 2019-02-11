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
     * Design, validation: James Sharpe
     * Loading selected package and insert fuction for editing package, fixes and bugs: Nathan Armstrong and James Sharpe 
     */

    public partial class EditPackage : Form
    {
        public TravelPackage package;

        public EditPackage()
        {
            InitializeComponent();
        }

        // back to previous form
        private void btnBackPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        // exit app
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Loads travel package and sets text boxes to contain package info
        // sets date time picker min dates
        private void EditPackage_Load(object sender, EventArgs e)
        {
            txtPkgID.Text = package.PkgID.ToString();
            txtPkgName.Text = package.PkgName.ToString();
            txtPkgDesc.Text = package.PkgDesc.ToString();
            txtPkgBasePrice.Text = package.PkgBasePrice.ToString();
            txtPkgAgncComm.Text = package.PkgAgencyCommission.ToString();
            dtpStartDate.Value = package.PkgStartDate;
            dtpEndDate.Value = package.PkgEndDate;

            dtpStartDate.MinDate = package.PkgStartDate;
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);
        }

        // sets datetime picker min date
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);
        }

        // on click validate text fields and create new package for insertion
        private void btnUpdatePackage_Click(object sender, EventArgs e)
        {
            if (Validator.IsProvided(txtPkgName, "Package Name") &&
            Validator.IsProvided(txtPkgDesc, "Package Description") &&
            Validator.IsProvided(txtPkgBasePrice, "Package Base Price") &&
            Validator.IsNonNegativeMoney(txtPkgBasePrice, "Package Base Price") &&
            Validator.IsNonNegativeMoney(txtPkgAgncComm, "Agency Commision"))
            {
                if (dtpStartDate.Value < dtpEndDate.Value)
                {
                    // get input fields
                    string pkgName = txtPkgName.Text;
                    DateTime pkgStartDate = dtpStartDate.Value.Date;
                    DateTime pkgEndDate = dtpEndDate.Value.Date;
                    string pkgDesc = txtPkgDesc.Text;
                    decimal pkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                    decimal pkgAgncCommish = 0;
                    if (txtPkgAgncComm.Text == "")
                    {
                        txtPkgAgncComm.Text = null;
                    }
                    else
                    {
                        pkgAgncCommish = Convert.ToDecimal(txtPkgAgncComm.Text);
                    }

                    //create new newpackage class
                    TravelPackage newpackage = new TravelPackage();
                    newpackage.PkgName = pkgName;
                    newpackage.PkgStartDate = pkgStartDate;
                    newpackage.PkgEndDate = pkgEndDate;
                    newpackage.PkgDesc = pkgDesc;
                    newpackage.PkgBasePrice = pkgBasePrice;
                    newpackage.PkgAgencyCommission = pkgAgncCommish;

                    // call insert function and insert new package with old package
                    if (TravelPackageDB.UpdatePackage(package, newpackage))
                    {
                        MessageBox.Show("Package was updated successfully");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error while updating, try again");
                    }
                }
            }
        }
    }
}
