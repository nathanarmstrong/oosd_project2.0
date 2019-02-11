using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TravelExpertsClasses;

namespace TravelExperts
{
    /* Project 2 Group 1 
     * Date: January 2019
     * Creators: Nathan Armstrong, Abel Rojas Bueno, James Sharpe, Manish Sudani
     * Basic layout, display list boxes and combo boxes and linking prods/supps: Nathan Armstrong
     * Add/edit/delete buttons and functions for prod and supps: James Sharpe
     * bugs and fixes: Nathan Armstrong and James Sharpe
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
                bool valid = true;
                foreach (Product p in products)
                {
                    if (p.ProdName == product)
                    {
                        MessageBox.Show(product + " already exists");
                        valid = false;
                        break;
                    }
                }
                if (valid)
                {
                    Product pro = new Product();
                    pro.ProdName = product;
                    pro.ProductId = ProductDB.AddProduct(pro);
                    products = ProductDB.GetProducts();
                    displayProducts();
                    listProducts();
                    txtProducts.Clear();
                    MessageBox.Show(product + " was added");
                }
            }
        }
        // Take all products in list and display them
        private void displayProducts()
        {
            products = ProductDB.GetProducts();
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
                string supplier = txtSuppliers.Text.ToUpper();
                bool valid = true;
                foreach (Supplier createdSup in suppliers)
                {
                    if(createdSup.SupName == supplier)
                    {
                        MessageBox.Show(supplier + " already exists");
                        valid = false;
                        break;
                    }  
                }
                if (valid)
                {
                    Supplier sup = new Supplier();
                    sup.SupName = supplier;
                    sup.SupplierId = SupplierDB.AddSupplier(sup);
                    suppliers = SupplierDB.GetSuppliers();
                    displaySuppliers();
                    listSuppliers();
                    txtSuppliers.Clear();
                    MessageBox.Show(supplier + " was added");
                }
            }
        }

        // display lsit box of supplies
        private void displaySuppliers()
        {
            suppliers = SupplierDB.GetSuppliers();
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
            displayProducts();
            displaySuppliers();
            listProducts();
            listSuppliers();

            cbProducts.ContextMenu = new ContextMenu();
            cbSuppliers.ContextMenu = new ContextMenu();
        }
        // link selected list box items
        private void btnLinkPS_Click(object sender, EventArgs e)
        {
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
            displayProducts();
            displaySuppliers();
            listProducts();
            listSuppliers();
            this.Show();
            btnDeleteSupplier.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnEditSupplier.Enabled = false;
            btnEditProduct.Enabled = false;
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

        // clear fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            cbSuppliers.Text = "";
            cbProducts.Text = "";
            btnLinkPS.Enabled = false;
        }

        // call delete function for the product selected and set a confirmation box.
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        { 
            string selectedProduct = lbProducts.SelectedItem.ToString();
            var confirmDelete = MessageBox.Show("Are you sure you want to delete " + selectedProduct + "?", "Confirm?", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
            try
            {
                ProductDB.DeleteProduct(selectedProduct);
                MessageBox.Show(selectedProduct + " was deleted");
            }
            catch
            {
                MessageBox.Show(selectedProduct + " could not be deleted, contact the administrator");
            }
            displayProducts();
            listProducts();
            cbProducts.SelectedIndex = -1;
            cbProducts.Text = "";
            }
            else
            {
                MessageBox.Show(selectedProduct + " was not deleted");
            }
        }

        // call delete function for the supplier selected and set a confirmation box.
        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            string selectedSupplier = lbSuppliers.SelectedItem.ToString();
            var confirmDelete = MessageBox.Show("Are you sure you want to delete " + selectedSupplier + "?", "Confirm?", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                try
                {
                    SupplierDB.DeleteSupplier(selectedSupplier);
                    MessageBox.Show(selectedSupplier + " was deleted");
                }
                catch
                {
                    MessageBox.Show(selectedSupplier + " could not be deleted, contact the administrator");
                }
                displaySuppliers();
                listSuppliers();
                cbSuppliers.SelectedIndex = -1;
                cbSuppliers.Text = "";
            }
            else
            {
                MessageBox.Show(selectedSupplier + " was not deleted");
            }
        }

        //  disable delete buttons
        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteProduct.Enabled = true;
            btnEditProduct.Enabled = true;
        }

        //  disable delete buttons
        private void lbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteSupplier.Enabled = true;
            btnEditSupplier.Enabled = true;
        }

        // set selected item to pass into the edit form
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            EditProdSup epsForm = new EditProdSup();
            epsForm.SelectedProductName = lbProducts.SelectedItem.ToString();
            epsForm.Show();
            this.Hide();
            epsForm.FormClosing += PPS_FormClosing;
        }

        // set selected item to pass into the edit form
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            EditProdSup epsForm = new EditProdSup();
            epsForm.SelectedSupplierName = lbSuppliers.SelectedItem.ToString();
            epsForm.Show();
            this.Hide();
            epsForm.FormClosing += PPS_FormClosing;
        }

        // for the remaining fucntions: disable/surpress keystrokes and mouse context menus on list boxes
        private void cbProducts_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void cbSuppliers_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void cbProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbSuppliers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
