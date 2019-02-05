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
    public partial class EditPackage : Form
    {
        public TravelPackage package;

        public EditPackage()
        {
            InitializeComponent();
        }

        private void btnBackPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditPackage_Load(object sender, EventArgs e)
        {
            txtPkgID.Text = package.PkgID.ToString();
            txtPkgName.Text = package.PkgName.ToString();
            txtPkgDesc.Text = package.PkgDesc.ToString();
            txtPkgBasePrice.Text = package.PkgBasePrice.ToString();
            txtPkgAgncComm.Text = package.PkgAgencyCommission.ToString();
            dtpStartDate.Value = package.PkgStartDate;
            dtpEndDate.Value = package.PkgEndDate;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);
        }

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
