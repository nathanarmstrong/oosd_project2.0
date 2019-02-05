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
    public partial class EditProdSup : Form
    {
        public string SelectedProductName = null;
        public string SelectedSupplierName = null;
        List<Product> products = new List<Product>();
        List<Supplier> suppliers = new List<Supplier>();

        public EditProdSup()
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

        private void EditProdSup_Load(object sender, EventArgs e)
        {
            products = ProductDB.GetProducts();
            suppliers = SupplierDB.GetSuppliers();

            if (SelectedProductName != null)
            {
                btnUpdate.Text = "Update Product";
                lblProdSup.Text = "Selected Product Name:";
                txtProdSup.Text = SelectedProductName;
                txtProdSup.MaxLength = 50;
            }
            else
            {
                btnUpdate.Text = "Update Supplier";
                lblProdSup.Text = "Selected Supplier Name:";
                txtProdSup.Text = SelectedSupplierName;
                txtProdSup.MaxLength = 255;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedProductName != null)
            {
                if (Validator.IsProvided(txtProdSup, "A Product Name"))
                {
                    string newName = txtProdSup.Text;
                    bool valid = false;

                    foreach (Product p in products)
                    {
                        if (p.ProdName == newName)
                        {
                            MessageBox.Show("Product already exists, choose a unique product name");
                            valid = false;
                            break;
                        }
                        else
                        {
                            valid = true;
                        }
                    }
                    if (valid == true)
                    {
                        try
                        {
                            ProductDB.UpdateProduct(SelectedProductName, newName);
                            MessageBox.Show(SelectedProductName + " was updated to " + newName);
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Update was unsuccessful, try again");
                        }
                    }
                }
            }
            else if (Validator.IsProvided(txtProdSup, "A Supplier name"))
            {
                string newName = txtProdSup.Text;
                bool valid = false;

                foreach (Supplier s in suppliers)
                {
                    if (s.SupName == newName)
                    {
                        MessageBox.Show("Supplier already exists, choose a unique supplier name");
                        valid = false;
                        break;
                    }
                    else
                    {
                        valid = true;
                    }
                }
                if (valid == true)
                {
                    try
                    {
                        SupplierDB.UpdateSupplier(SelectedSupplierName, newName);
                        MessageBox.Show(SelectedSupplierName + " was updated to " + newName);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Update was unsuccessful, try again");
                    }
                }
            }
        }
    }
}
