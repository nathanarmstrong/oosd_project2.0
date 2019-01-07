namespace TravelExperts
{
    partial class Packages_Products_Suppliers
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
            this.btnLink = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBackPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(88, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 75);
            this.label1.TabIndex = 4;
            this.label1.Text = "Travel Experts Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(309, 225);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(382, 115);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(306, 225);
            this.listBox2.TabIndex = 6;
            // 
            // btnLink
            // 
            this.btnLink.Enabled = false;
            this.btnLink.Location = new System.Drawing.Point(228, 372);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(260, 37);
            this.btnLink.TabIndex = 7;
            this.btnLink.Text = "&Link Package to Product_Supliers";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(633, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 75);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBackPage
            // 
            this.btnBackPage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBackPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackPage.Location = new System.Drawing.Point(0, 0);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(90, 75);
            this.btnBackPage.TabIndex = 13;
            this.btnBackPage.Text = "Back<--";
            this.btnBackPage.UseVisualStyleBackColor = false;
            this.btnBackPage.Click += new System.EventHandler(this.btnBackPage_Click);
            // 
            // Packages_Products_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackPage);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Packages_Products_Suppliers";
            this.Text = "Packages_Products_Suppliers";
            this.Load += new System.EventHandler(this.Packages_Products_Suppliers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBackPage;
    }
}