namespace ASM1_Database
{
    partial class Manage_Table
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRevenue = new System.Windows.Forms.Button();
            this.btCustomer = new System.Windows.Forms.Button();
            this.btEmployee = new System.Windows.Forms.Button();
            this.btProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btStaticPr = new System.Windows.Forms.Button();
            this.btCus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCus);
            this.groupBox1.Controls.Add(this.btEmployee);
            this.groupBox1.Controls.Add(this.btProduct);
            this.groupBox1.Controls.Add(this.btStaticPr);
            this.groupBox1.Controls.Add(this.btCustomer);
            this.groupBox1.Controls.Add(this.btRevenue);
            this.groupBox1.Location = new System.Drawing.Point(185, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btRevenue
            // 
            this.btRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btRevenue.Location = new System.Drawing.Point(208, 171);
            this.btRevenue.Name = "btRevenue";
            this.btRevenue.Size = new System.Drawing.Size(121, 65);
            this.btRevenue.TabIndex = 3;
            this.btRevenue.Text = "Revenue";
            this.btRevenue.UseVisualStyleBackColor = true;
            this.btRevenue.Click += new System.EventHandler(this.btRevenue_Click);
            // 
            // btCustomer
            // 
            this.btCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btCustomer.Location = new System.Drawing.Point(39, 289);
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.Size = new System.Drawing.Size(121, 65);
            this.btCustomer.TabIndex = 2;
            this.btCustomer.Text = "Customer Bill";
            this.btCustomer.UseVisualStyleBackColor = true;
            this.btCustomer.Click += new System.EventHandler(this.btCustomer_Click);
            // 
            // btEmployee
            // 
            this.btEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btEmployee.Location = new System.Drawing.Point(39, 171);
            this.btEmployee.Name = "btEmployee";
            this.btEmployee.Size = new System.Drawing.Size(121, 65);
            this.btEmployee.TabIndex = 1;
            this.btEmployee.Text = "Employee";
            this.btEmployee.UseVisualStyleBackColor = true;
            this.btEmployee.Click += new System.EventHandler(this.btEmployee_Click);
            // 
            // btProduct
            // 
            this.btProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btProduct.Location = new System.Drawing.Point(39, 53);
            this.btProduct.Name = "btProduct";
            this.btProduct.Size = new System.Drawing.Size(121, 65);
            this.btProduct.TabIndex = 0;
            this.btProduct.Text = "Product";
            this.btProduct.UseVisualStyleBackColor = true;
            this.btProduct.Click += new System.EventHandler(this.btProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(297, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table Manage";
            // 
            // btStaticPr
            // 
            this.btStaticPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btStaticPr.Location = new System.Drawing.Point(208, 53);
            this.btStaticPr.Name = "btStaticPr";
            this.btStaticPr.Size = new System.Drawing.Size(121, 65);
            this.btStaticPr.TabIndex = 5;
            this.btStaticPr.Text = "Static Products";
            this.btStaticPr.UseVisualStyleBackColor = true;
            this.btStaticPr.Click += new System.EventHandler(this.btStaticPr_Click);
            // 
            // btCus
            // 
            this.btCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btCus.Location = new System.Drawing.Point(208, 289);
            this.btCus.Name = "btCus";
            this.btCus.Size = new System.Drawing.Size(121, 65);
            this.btCus.TabIndex = 6;
            this.btCus.Text = "Customer";
            this.btCus.UseVisualStyleBackColor = true;
            this.btCus.Click += new System.EventHandler(this.btCus_Click);
            // 
            // Manage_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Manage_Table";
            this.Text = "Manage_Table";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btRevenue;
        private System.Windows.Forms.Button btCustomer;
        private System.Windows.Forms.Button btEmployee;
        private System.Windows.Forms.Button btProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStaticPr;
        private System.Windows.Forms.Button btCus;
    }
}