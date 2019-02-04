namespace TravelExperts
{
    partial class Suppliers_Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lbSuppliers = new System.Windows.Forms.ListBox();
            this.txtProducts = new System.Windows.Forms.TextBox();
            this.txtSuppliers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnAddSuppliers = new System.Windows.Forms.Button();
            this.btnLinkPS = new System.Windows.Forms.Button();
            this.btnLinkToPackage = new System.Windows.Forms.Button();
            this.btnBackPage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(89, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 75);
            this.label1.TabIndex = 3;
            this.label1.Text = "Travel Experts Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.Location = new System.Drawing.Point(38, 101);
            this.lbProducts.MultiColumn = true;
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(184, 238);
            this.lbProducts.TabIndex = 4;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // lbSuppliers
            // 
            this.lbSuppliers.FormattingEnabled = true;
            this.lbSuppliers.Location = new System.Drawing.Point(259, 101);
            this.lbSuppliers.Name = "lbSuppliers";
            this.lbSuppliers.Size = new System.Drawing.Size(184, 238);
            this.lbSuppliers.TabIndex = 4;
            this.lbSuppliers.SelectedIndexChanged += new System.EventHandler(this.lbSuppliers_SelectedIndexChanged);
            // 
            // txtProducts
            // 
            this.txtProducts.Location = new System.Drawing.Point(38, 365);
            this.txtProducts.MaxLength = 50;
            this.txtProducts.Name = "txtProducts";
            this.txtProducts.Size = new System.Drawing.Size(184, 20);
            this.txtProducts.TabIndex = 5;
            // 
            // txtSuppliers
            // 
            this.txtSuppliers.Location = new System.Drawing.Point(259, 365);
            this.txtSuppliers.MaxLength = 255;
            this.txtSuppliers.Name = "txtSuppliers";
            this.txtSuppliers.Size = new System.Drawing.Size(184, 20);
            this.txtSuppliers.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Suppliers";
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Location = new System.Drawing.Point(38, 395);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(184, 25);
            this.btnAddProducts.TabIndex = 7;
            this.btnAddProducts.Text = "Add &Products";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnAddSuppliers
            // 
            this.btnAddSuppliers.Location = new System.Drawing.Point(259, 391);
            this.btnAddSuppliers.Name = "btnAddSuppliers";
            this.btnAddSuppliers.Size = new System.Drawing.Size(184, 25);
            this.btnAddSuppliers.TabIndex = 8;
            this.btnAddSuppliers.Text = "Add &Suppliers";
            this.btnAddSuppliers.UseVisualStyleBackColor = true;
            this.btnAddSuppliers.Click += new System.EventHandler(this.btnAddSuppliers_Click);
            // 
            // btnLinkPS
            // 
            this.btnLinkPS.Enabled = false;
            this.btnLinkPS.Location = new System.Drawing.Point(492, 150);
            this.btnLinkPS.Name = "btnLinkPS";
            this.btnLinkPS.Size = new System.Drawing.Size(194, 28);
            this.btnLinkPS.TabIndex = 9;
            this.btnLinkPS.Text = "Link Prodct + Suplier";
            this.btnLinkPS.UseVisualStyleBackColor = true;
            this.btnLinkPS.Click += new System.EventHandler(this.btnLinkPS_Click);
            // 
            // btnLinkToPackage
            // 
            this.btnLinkToPackage.Location = new System.Drawing.Point(492, 377);
            this.btnLinkToPackage.Name = "btnLinkToPackage";
            this.btnLinkToPackage.Size = new System.Drawing.Size(194, 60);
            this.btnLinkToPackage.TabIndex = 10;
            this.btnLinkToPackage.Text = "Link To Package";
            this.btnLinkToPackage.UseVisualStyleBackColor = true;
            this.btnLinkToPackage.Click += new System.EventHandler(this.btnLinkToPackage_Click);
            // 
            // btnBackPage
            // 
            this.btnBackPage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBackPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackPage.Location = new System.Drawing.Point(0, 0);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(90, 75);
            this.btnBackPage.TabIndex = 11;
            this.btnBackPage.Text = "Back<--";
            this.btnBackPage.UseVisualStyleBackColor = false;
            this.btnBackPage.Click += new System.EventHandler(this.btnBackPage_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(630, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 75);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(492, 110);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(193, 21);
            this.cbProducts.TabIndex = 12;
            this.cbProducts.SelectedIndexChanged += new System.EventHandler(this.cbProducts_SelectedIndexChanged);
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(493, 201);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(191, 21);
            this.cbSuppliers.TabIndex = 13;
            this.cbSuppliers.SelectedIndexChanged += new System.EventHandler(this.cbSuppliers_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Products";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Suppliers";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(496, 249);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(187, 38);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Enabled = false;
            this.btnDeleteProduct.Location = new System.Drawing.Point(131, 426);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(91, 30);
            this.btnDeleteProduct.TabIndex = 16;
            this.btnDeleteProduct.Text = "&Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Enabled = false;
            this.btnDeleteSupplier.Location = new System.Drawing.Point(355, 426);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(88, 30);
            this.btnDeleteSupplier.TabIndex = 17;
            this.btnDeleteSupplier.Text = "&Delete Supplier";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Enabled = false;
            this.btnEditProduct.Location = new System.Drawing.Point(38, 426);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(87, 30);
            this.btnEditProduct.TabIndex = 18;
            this.btnEditProduct.Text = "&Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Enabled = false;
            this.btnEditSupplier.Location = new System.Drawing.Point(259, 426);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(80, 30);
            this.btnEditSupplier.TabIndex = 19;
            this.btnEditSupplier.Text = "&Edit Supplier";
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // Suppliers_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 461);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackPage);
            this.Controls.Add(this.btnLinkToPackage);
            this.Controls.Add(this.btnLinkPS);
            this.Controls.Add(this.btnAddSuppliers);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSuppliers);
            this.Controls.Add(this.txtProducts);
            this.Controls.Add(this.lbSuppliers);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.label1);
            this.Name = "Suppliers_Products";
            this.Text = "Suppliers_Products";
            this.Load += new System.EventHandler(this.Suppliers_Products_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.ListBox lbSuppliers;
        private System.Windows.Forms.TextBox txtProducts;
        private System.Windows.Forms.TextBox txtSuppliers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnAddSuppliers;
        private System.Windows.Forms.Button btnLinkPS;
        private System.Windows.Forms.Button btnLinkToPackage;
        private System.Windows.Forms.Button btnBackPage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnEditSupplier;
    }
}