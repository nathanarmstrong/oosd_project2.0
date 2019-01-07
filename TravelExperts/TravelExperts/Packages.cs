using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Packages()
        {
            InitializeComponent();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            // TODO: get all input field.Text and append to packages list then SQL DB
            displayPackages();
        }
        //Display all packages from list
        private void displayPackages()
        {
            // TODO: Get all packages from list and display in list box
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
