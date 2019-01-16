using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

    public partial class Suppliers_Products : Form
    {
        // Create a list of both products and supliers
        List<Product> products = new List<Product>();
        List<Supplier> suppliers = new List<Supplier>();
        public Suppliers_Products()
        {
            InitializeComponent();
        }
        // Adds product by name to the list of products and appends it to DB
        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            // TODO: get input product.Text and append to list and then DB
            string product = txtProducts.Text;
            Product pro = new Product();
            pro.ProdName = product;
            pro.ProductId = ProductDB.AddProduct(pro);
            products = ProductDB.GetProducts();
            displayProducts();
            txtProducts.Clear();
        }
        // Take all products in list and display them
        private void displayProducts()
        {
            lbProducts.Items.Clear();
            // take all the products from list and display it in the list box
            foreach (Product product in products)
            {
                lbProducts.Items.Add(product.ProdName);
            }
        }
        // Adds Supplier by name to the list of suppliers and appends it to the DB
        private void btnAddSuppliers_Click(object sender, EventArgs e)
        {
            // get input supplier.Text and append to list and then DB
            string supplier = txtSuppliers.Text;
            Supplier sup = new Supplier();
            sup.SupName = supplier;
            sup.SupplierId = SupplierDB.AddSupplier(sup);
            suppliers = SupplierDB.GetSuppliers();
            displaySuppliers();
            txtSuppliers.Clear();
        }
        private void displaySuppliers()
        {
            lbSuppliers.Items.Clear();
            // take all the suppliers from list and display it in the list box
            foreach(Supplier supplier in suppliers)
            {
                lbSuppliers.Items.Add(supplier.SupName);
            }
        }
        // on load get all suppliers, products, and there relation table then append the data to the corisponding list
        private void Suppliers_Products_Load(object sender, EventArgs e)
        {
            // get all suppliers and products and append to corisonding list
            products = ProductDB.GetProducts();
            suppliers = SupplierDB.GetSuppliers();
            displayProducts();
            displaySuppliers();
        }
        // link selected list box items
        private void btnLinkPS_Click(object sender, EventArgs e)
        {
            // TODO: get selected items from both list box's and link them to the Products_suppliers Table in the DB
        }
        // Open form to the products_suppliers_package form
        //By Nathan Armstrong
        private void btnLinkToPackage_Click(object sender, EventArgs e)
        {
            Packages_Products_Suppliers ppsForm = new Packages_Products_Suppliers();
            ppsForm.Show();
            this.Hide();
            ppsForm.FormClosing += PPS_FormClosing;
        }
        // on Packages_Products_Suppliers closing re show this form it is is hidden
        //By Nathan Armstrong
        private void PPS_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        // close this form
        //By Nathan Armstrong
        private void btnBackPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         // Close the application
         //By Nathan Armstrong
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
