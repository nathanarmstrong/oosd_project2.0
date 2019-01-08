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
     * 
     */
    public partial class AdminPannel : Form
    {
        List<TravelPackage> travelPackage = new List<TravelPackage>(); // empty list of travelPackage
        public AdminPannel()
        {
            InitializeComponent();
        }
        //On click open package form and hide current form
        //By Nathan Armstrong
        

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            Packages pForm = new Packages();
            pForm.Show();
            this.Hide();
            pForm.FormClosing += Packages_FormClosing;
        }
        // when Packages from is closed it will show this form again
        // By Nathan Armstrong
        private void Packages_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        //On click open  Suppliers/Products and hide current form
        // By Nathan Armstrong
        private void button2_Click(object sender, EventArgs e)
        {
            Suppliers_Products spForm = new Suppliers_Products();
            spForm.Show();
            this.Hide();
            spForm.FormClosing += Supplies_Products_FormClosing;
        }
        //when supplies and products form is closed show this form again
        //By Nathan Armstrong
        private void Supplies_Products_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        // Close Application
        // By Nathan Armstrong
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
