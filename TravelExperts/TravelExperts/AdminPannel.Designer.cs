namespace TravelExperts
{
    partial class AdminPannel
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
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnAddSupPro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPackage.Location = new System.Drawing.Point(81, 150);
            this.btnAddPackage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(207, 176);
            this.btnAddPackage.TabIndex = 0;
            this.btnAddPackage.Text = "Add &Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnAddSupPro
            // 
            this.btnAddSupPro.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupPro.Location = new System.Drawing.Point(366, 150);
            this.btnAddSupPro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddSupPro.Name = "btnAddSupPro";
            this.btnAddSupPro.Size = new System.Drawing.Size(207, 176);
            this.btnAddSupPro.TabIndex = 0;
            this.btnAddSupPro.Text = "Add &Suppliers/Products";
            this.btnAddSupPro.UseVisualStyleBackColor = true;
            this.btnAddSupPro.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Travel Experts Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(558, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 75);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AdminPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 348);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddSupPro);
            this.Controls.Add(this.btnAddPackage);
            this.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminPannel";
            this.Text = "Travel Experts Admin Pannel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnAddSupPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}

