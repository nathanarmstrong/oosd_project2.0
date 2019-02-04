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
        string selectedProduct = null;
        string selectedSupplier = null;
        public Suppliers_Products()
        {
            InitializeComponent();
        }
        // Adds product by name to the list of products and appends it to DB
        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            if (Validator.IsProvided(txtProducts, "Product Name"))
            {
                string product = txtProducts.Text;
                Product pro = new Product();
                pro.ProdName = product;
                pro.ProductId = ProductDB.AddProduct(pro);
                products = ProductDB.GetProducts();
                displayProducts();
                listProducts();
                txtProducts.Clear();
            }
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
            if (Validator.IsProvided(txtSuppliers, "Supplier Name"))
            {
                string supplier = txtSuppliers.Text;
                foreach(Supplier createdSup in suppliers)
                {
                    if(createdSup.SupName == supplier)
                    {
                        MessageBox.Show("That supllier already exists");
                    }
                }
                Supplier sup = new Supplier();
                sup.SupName = supplier;
                sup.SupplierId = SupplierDB.AddSupplier(sup);
                suppliers = SupplierDB.GetSuppliers();
                displaySuppliers();
                listSuppliers();
                txtSuppliers.Clear();
            }
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
            listProducts();
            listSuppliers();
        }
        // link selected list box items
        private void btnLinkPS_Click(object sender, EventArgs e)
        {
            // TODO: get selected items from both list box's and link them to the Products_suppliers Table in the DB
            int supID = -1;
            int proID = -1;
            foreach (Product pro in products)
            {
                if (selectedProduct == pro.ProdName)
                {
                    proID = pro.ProductId;
                }
            }
            foreach (Supplier sup in suppliers)
            {
                if (selectedSupplier == sup.SupName)
                {
                    supID = sup.SupplierId;
                }
            }
            if(ProductSuppliersDB.LinkProductSuppliers(supID, proID))
            {
                MessageBox.Show("You have linked the product with that supplier");
            }
            else
            {
                MessageBox.Show("product could not be linked to supllier");
            }

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

      
        // Add all suppliers to the combo box
        //By:Nathan Armstrong
        private void listSuppliers()
        {
            cbSuppliers.Items.Clear();
            // take all the suppliers from list and display it in the combo box
            foreach (Supplier supplier in suppliers)
            {
                cbSuppliers.Items.Add(supplier.SupName);
            }
        }
        //Add all products to the combo box
        private void listProducts()
        {
            cbProducts.Items.Clear();
            // take all the suppliers from list and display it in the combo box
            foreach (Product product in products)
            {
                cbProducts.Items.Add(product.ProdName);
            }
        }
        // selected value change in the products combo box
        //By:Nathan Armstrong
        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSuppliers(); // refresh the combo box to have all suppliers
            selectedProduct = cbProducts.SelectedItem.ToString(); // selected value of the combo box
            List<ProductSuppliers> corispondingSuppliers = new List<ProductSuppliers>(); // empty list that we will put all previously linked product and suppliers
            int selectedProdID; // the ID we will use to find corisponding relationship
            // go through all products in the List
            foreach (Product pro in products)
            {
                if (pro.ProdName == selectedProduct)
                {
                    selectedProdID = pro.ProductId;
                    corispondingSuppliers = ProductSuppliersDB.GetSuppliers(selectedProdID);
                    foreach (ProductSuppliers sup in corispondingSuppliers)
                    {
                        cbSuppliers.Items.Remove(sup.SupName);
                    }
                }
            }
            if(selectedSupplier != null)
            {
                btnLinkPS.Enabled = true;
            }
            
        }
        // selected value change in the suppliers combo box
        //By:Nathan Armstrong
        private void cbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            listProducts();// refresh the combo box to have all products
            selectedSupplier = cbSuppliers.SelectedItem.ToString(); // selected value of the combo box
            List<ProductSuppliers> corispondingProducts = new List<ProductSuppliers>(); // empty list that we will put all previously linked product and suppliers
            int selectedSupID; // the ID we will use to find corisponding relationship
            // go through all suppliers in the List
            foreach (Supplier sup in suppliers)
            {
                if (sup.SupName == selectedSupplier)
                {
                    selectedSupID = sup.SupplierId;
                    corispondingProducts = ProductSuppliersDB.GetProducts(selectedSupID);
                    foreach (ProductSuppliers prod in corispondingProducts)
                    {
                        cbProducts.Items.Remove(prod.ProdName);
                    }
                }
            }
            if (selectedProduct != null)
            {
                btnLinkPS.Enabled = true;
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbProducts.SelectedIndex = -1;
            cbSuppliers.SelectedIndex = -1;
            btnLinkPS.Enabled = false;
        }
    }
}
