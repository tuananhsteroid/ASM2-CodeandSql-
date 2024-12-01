namespace ASM1_Database
{
    partial class Customers
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
            this.dataGridViewcustomer = new System.Windows.Forms.DataGridView();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btEdit = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewcustomer
            // 
            this.dataGridViewcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcustomer.Location = new System.Drawing.Point(115, 45);
            this.dataGridViewcustomer.Name = "dataGridViewcustomer";
            this.dataGridViewcustomer.RowHeadersWidth = 51;
            this.dataGridViewcustomer.RowTemplate.Height = 24;
            this.dataGridViewcustomer.Size = new System.Drawing.Size(691, 181);
            this.dataGridViewcustomer.TabIndex = 0;
            this.dataGridViewcustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewcustomer_CellContentClick);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(177, 284);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(174, 22);
            this.tbname.TabIndex = 1;
            // 
            // tbaddress
            // 
            this.tbaddress.Location = new System.Drawing.Point(177, 412);
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(174, 22);
            this.tbaddress.TabIndex = 2;
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(177, 345);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(174, 22);
            this.tbphone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Name";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(565, 319);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(83, 48);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(710, 290);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(205, 22);
            this.tbsearch.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Customer Address";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(763, 329);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(94, 38);
            this.btSearch.TabIndex = 14;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Customer Phone";
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(420, 319);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(83, 48);
            this.btEdit.TabIndex = 10;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(490, 399);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(83, 48);
            this.upload.TabIndex = 16;
            this.upload.Text = "UpLoad";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 477);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.tbaddress);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.dataGridViewcustomer);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewcustomer;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button upload;
    }
}