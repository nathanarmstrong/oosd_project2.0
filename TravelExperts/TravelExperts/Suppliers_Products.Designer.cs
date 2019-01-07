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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnAddSuppliers = new System.Windows.Forms.Button();
            this.btnLinkPS = new System.Windows.Forms.Button();
            this.btnLinkToPackage = new System.Windows.Forms.Button();
            this.btnBackPage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(89, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 75);
            this.label1.TabIndex = 3;
            this.label1.Text = "Travel Experts Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(38, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 238);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(259, 101);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(184, 238);
            this.listBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 377);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(259, 377);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Suppliers";
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Location = new System.Drawing.Point(38, 412);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(184, 25);
            this.btnAddProducts.TabIndex = 7;
            this.btnAddProducts.Text = "Add &Products";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnAddSuppliers
            // 
            this.btnAddSuppliers.Location = new System.Drawing.Point(259, 412);
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
            this.btnLinkPS.Location = new System.Drawing.Point(492, 101);
            this.btnLinkPS.Name = "btnLinkPS";
            this.btnLinkPS.Size = new System.Drawing.Size(194, 238);
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
            // Suppliers_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackPage);
            this.Controls.Add(this.btnLinkToPackage);
            this.Controls.Add(this.btnLinkPS);
            this.Controls.Add(this.btnAddSuppliers);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Suppliers_Products";
            this.Text = "Suppliers_Products";
            this.Load += new System.EventHandler(this.Suppliers_Products_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnAddSuppliers;
        private System.Windows.Forms.Button btnLinkPS;
        private System.Windows.Forms.Button btnLinkToPackage;
        private System.Windows.Forms.Button btnBackPage;
        private System.Windows.Forms.Button btnExit;
    }
}