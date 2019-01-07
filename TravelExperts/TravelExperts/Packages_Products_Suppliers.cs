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
    public partial class Packages_Products_Suppliers : Form
    {
        // TODO: create a list of all Suppliers_Products and list of Packages
        public Packages_Products_Suppliers()
        {
            InitializeComponent();
        }
        // Link the selected items from the list box and append to DB
        private void btnLink_Click(object sender, EventArgs e)
        {
            // TODO: get selected inputs and then link them to the DB
        }
        // On load get all related info and append to list, then display all packages and Product_Suppliers from lists
        private void Packages_Products_Suppliers_Load(object sender, EventArgs e)
        {
            // TODO: get all packages and Products_Suppliers from DB and append to corisponding list then display all info
            displayPackages();
            displayProSup();
        }
        //Display all packages from list
        private void displayPackages()
        {
            // TODO: Get all packages from list and display in list box
        }
        //Display all Product_Suppliers from list
        private void displayProSup()
        {
            // TODO: Get all packages from list and display in list box
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
    }
}
