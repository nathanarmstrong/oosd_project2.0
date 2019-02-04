namespace TravelExperts
{
    partial class EditPackage
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBackPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPackageID = new System.Windows.Forms.Label();
            this.txtPkgID = new System.Windows.Forms.TextBox();
            this.txtPkgAgncComm = new System.Windows.Forms.TextBox();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdatePackage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(713, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 75);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBackPage
            // 
            this.btnBackPage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBackPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackPage.Location = new System.Drawing.Point(1, -2);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(90, 75);
            this.btnBackPage.TabIndex = 16;
            this.btnBackPage.Text = "Back<--";
            this.btnBackPage.UseVisualStyleBackColor = false;
            this.btnBackPage.Click += new System.EventHandler(this.btnBackPage_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(89, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 75);
            this.label1.TabIndex = 14;
            this.label1.Text = "Travel Experts Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPackageID
            // 
            this.lblPackageID.AutoSize = true;
            this.lblPackageID.Location = new System.Drawing.Point(91, 141);
            this.lblPackageID.Name = "lblPackageID";
            this.lblPackageID.Size = new System.Drawing.Size(67, 13);
            this.lblPackageID.TabIndex = 17;
            this.lblPackageID.Text = "Package ID:";
            // 
            // txtPkgID
            // 
            this.txtPkgID.Enabled = false;
            this.txtPkgID.Location = new System.Drawing.Point(171, 137);
            this.txtPkgID.Name = "txtPkgID";
            this.txtPkgID.Size = new System.Drawing.Size(100, 20);
            this.txtPkgID.TabIndex = 22;
            // 
            // txtPkgAgncComm
            // 
            this.txtPkgAgncComm.Location = new System.Drawing.Point(171, 241);
            this.txtPkgAgncComm.Name = "txtPkgAgncComm";
            this.txtPkgAgncComm.Size = new System.Drawing.Size(100, 20);
            this.txtPkgAgncComm.TabIndex = 23;
            // 
            // txtPkgName
            // 
            this.txtPkgName.Location = new System.Drawing.Point(171, 163);
            this.txtPkgName.MaxLength = 50;
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(150, 20);
            this.txtPkgName.TabIndex = 24;
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Location = new System.Drawing.Point(171, 189);
            this.txtPkgDesc.MaxLength = 50;
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(150, 20);
            this.txtPkgDesc.TabIndex = 26;
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Location = new System.Drawing.Point(171, 215);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(100, 20);
            this.txtPkgBasePrice.TabIndex = 27;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(481, 134);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(109, 20);
            this.dtpStartDate.TabIndex = 31;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(478, 173);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(109, 20);
            this.dtpEndDate.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Package Start Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Package End Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Package Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Package Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Package Base Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Package Agency Commision:";
            // 
            // btnUpdatePackage
            // 
            this.btnUpdatePackage.Location = new System.Drawing.Point(386, 227);
            this.btnUpdatePackage.Name = "btnUpdatePackage";
            this.btnUpdatePackage.Size = new System.Drawing.Size(143, 33);
            this.btnUpdatePackage.TabIndex = 39;
            this.btnUpdatePackage.Text = "&Update Package";
            this.btnUpdatePackage.UseVisualStyleBackColor = true;
            this.btnUpdatePackage.Click += new System.EventHandler(this.btnUpdatePackage_Click);
            // 
            // EditPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 399);
            this.Controls.Add(this.btnUpdatePackage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtPkgBasePrice);
            this.Controls.Add(this.txtPkgDesc);
            this.Controls.Add(this.txtPkgName);
            this.Controls.Add(this.txtPkgAgncComm);
            this.Controls.Add(this.txtPkgID);
            this.Controls.Add(this.lblPackageID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackPage);
            this.Controls.Add(this.label1);
            this.Name = "EditPackage";
            this.Text = "EditPackage";
            this.Load += new System.EventHandler(this.EditPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBackPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPackageID;
        private System.Windows.Forms.TextBox txtPkgID;
        private System.Windows.Forms.TextBox txtPkgAgncComm;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdatePackage;
    }
}