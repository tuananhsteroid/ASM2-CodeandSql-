namespace ASM1_Database
{
    partial class ProductStatisticsForm
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
            this.dataGridViewStaticPR = new System.Windows.Forms.DataGridView();
            this.btUP = new System.Windows.Forms.Button();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtFormDate = new System.Windows.Forms.DateTimePicker();
            this.DtToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btsearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbStaticPrQuan = new System.Windows.Forms.Label();
            this.lbStaticPrName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btCalPrQuan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaticPR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStaticPR
            // 
            this.dataGridViewStaticPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaticPR.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStaticPR.Name = "dataGridViewStaticPR";
            this.dataGridViewStaticPR.RowHeadersWidth = 51;
            this.dataGridViewStaticPR.RowTemplate.Height = 24;
            this.dataGridViewStaticPR.Size = new System.Drawing.Size(1272, 393);
            this.dataGridViewStaticPR.TabIndex = 0;
            // 
            // btUP
            // 
            this.btUP.Location = new System.Drawing.Point(564, 419);
            this.btUP.Name = "btUP";
            this.btUP.Size = new System.Drawing.Size(102, 40);
            this.btUP.TabIndex = 1;
            this.btUP.Text = "UpLoad";
            this.btUP.UseVisualStyleBackColor = true;
            this.btUP.Click += new System.EventHandler(this.btUP_Click);
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(9, 52);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(172, 22);
            this.tbsearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Name";
            // 
            // DtFormDate
            // 
            this.DtFormDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtFormDate.Location = new System.Drawing.Point(6, 136);
            this.DtFormDate.Name = "DtFormDate";
            this.DtFormDate.Size = new System.Drawing.Size(112, 22);
            this.DtFormDate.TabIndex = 4;
            // 
            // DtToDate
            // 
            this.DtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtToDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DtToDate.Location = new System.Drawing.Point(193, 136);
            this.DtToDate.Name = "DtToDate";
            this.DtToDate.Size = new System.Drawing.Size(112, 22);
            this.DtToDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "From Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "To Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btsearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DtToDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DtFormDate);
            this.groupBox1.Controls.Add(this.tbsearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 184);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(230, 51);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(75, 23);
            this.btsearch.TabIndex = 8;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbStaticPrQuan);
            this.groupBox2.Controls.Add(this.lbStaticPrName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(754, 475);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 146);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // lbStaticPrQuan
            // 
            this.lbStaticPrQuan.AutoSize = true;
            this.lbStaticPrQuan.Location = new System.Drawing.Point(205, 105);
            this.lbStaticPrQuan.Name = "lbStaticPrQuan";
            this.lbStaticPrQuan.Size = new System.Drawing.Size(44, 16);
            this.lbStaticPrQuan.TabIndex = 5;
            this.lbStaticPrQuan.Text = "label9";
            // 
            // lbStaticPrName
            // 
            this.lbStaticPrName.AutoSize = true;
            this.lbStaticPrName.Location = new System.Drawing.Point(205, 37);
            this.lbStaticPrName.Name = "lbStaticPrName";
            this.lbStaticPrName.Size = new System.Drawing.Size(44, 16);
            this.lbStaticPrName.TabIndex = 4;
            this.lbStaticPrName.Text = "label8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Product Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(811, 453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(383, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Table of statistics on the number of products sold";
            // 
            // btCalPrQuan
            // 
            this.btCalPrQuan.Location = new System.Drawing.Point(553, 559);
            this.btCalPrQuan.Name = "btCalPrQuan";
            this.btCalPrQuan.Size = new System.Drawing.Size(125, 55);
            this.btCalPrQuan.TabIndex = 13;
            this.btCalPrQuan.Text = "Calculate product quantity";
            this.btCalPrQuan.UseVisualStyleBackColor = true;
            this.btCalPrQuan.Click += new System.EventHandler(this.btCalPrQuan_Click);
            // 
            // ProductStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 633);
            this.Controls.Add(this.btCalPrQuan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btUP);
            this.Controls.Add(this.dataGridViewStaticPR);
            this.Name = "ProductStatisticsForm";
            this.Text = "ProductStatisticsForm";
            this.Load += new System.EventHandler(this.ProductStatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaticPR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStaticPR;
        private System.Windows.Forms.Button btUP;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtFormDate;
        private System.Windows.Forms.DateTimePicker DtToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbStaticPrQuan;
        private System.Windows.Forms.Label lbStaticPrName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btCalPrQuan;
    }
}