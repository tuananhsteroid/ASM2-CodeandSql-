namespace ASM1_Database
{
    partial class FormRevenue
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
            this.dataGridViewRevenue = new System.Windows.Forms.DataGridView();
            this.btUpdata = new System.Windows.Forms.Button();
            this.cbRevebue = new System.Windows.Forms.ComboBox();
            this.btCalculate = new System.Windows.Forms.Button();
            this.tbselectID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotalRevenue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbProfit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFromdate = new System.Windows.Forms.DateTimePicker();
            this.tbTodate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRevenue
            // 
            this.dataGridViewRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRevenue.Location = new System.Drawing.Point(12, 88);
            this.dataGridViewRevenue.Name = "dataGridViewRevenue";
            this.dataGridViewRevenue.RowHeadersWidth = 51;
            this.dataGridViewRevenue.RowTemplate.Height = 24;
            this.dataGridViewRevenue.Size = new System.Drawing.Size(1258, 210);
            this.dataGridViewRevenue.TabIndex = 0;
            // 
            // btUpdata
            // 
            this.btUpdata.Location = new System.Drawing.Point(603, 334);
            this.btUpdata.Name = "btUpdata";
            this.btUpdata.Size = new System.Drawing.Size(89, 44);
            this.btUpdata.TabIndex = 1;
            this.btUpdata.Text = "Upload Data";
            this.btUpdata.UseVisualStyleBackColor = true;
            this.btUpdata.Click += new System.EventHandler(this.btUpdata_Click);
            // 
            // cbRevebue
            // 
            this.cbRevebue.FormattingEnabled = true;
            this.cbRevebue.Items.AddRange(new object[] {
            "Calculate Total Revenue by Day",
            "",
            "Calculate Total Revenue by Customer ID",
            "",
            "Calculate Total Revenue"});
            this.cbRevebue.Location = new System.Drawing.Point(32, 397);
            this.cbRevebue.Name = "cbRevebue";
            this.cbRevebue.Size = new System.Drawing.Size(386, 24);
            this.cbRevebue.TabIndex = 2;
            this.cbRevebue.SelectedIndexChanged += new System.EventHandler(this.cbRevebue_SelectedIndexChanged);
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(520, 532);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(111, 49);
            this.btCalculate.TabIndex = 3;
            this.btCalculate.Text = "Calculate Total";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // tbselectID
            // 
            this.tbselectID.Location = new System.Drawing.Point(32, 484);
            this.tbselectID.Name = "tbselectID";
            this.tbselectID.Size = new System.Drawing.Size(141, 22);
            this.tbselectID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select the customer ID for which you want to calculate the total bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Please enter the date range for which you want to calculate revenue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 596);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "To date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "From date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Revenue";
            // 
            // lbTotalRevenue
            // 
            this.lbTotalRevenue.AutoSize = true;
            this.lbTotalRevenue.Location = new System.Drawing.Point(150, 35);
            this.lbTotalRevenue.Name = "lbTotalRevenue";
            this.lbTotalRevenue.Size = new System.Drawing.Size(0, 16);
            this.lbTotalRevenue.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Profit";
            // 
            // lbProfit
            // 
            this.lbProfit.AutoSize = true;
            this.lbProfit.Location = new System.Drawing.Point(150, 85);
            this.lbProfit.Name = "lbProfit";
            this.lbProfit.Size = new System.Drawing.Size(0, 16);
            this.lbProfit.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbProfit);
            this.groupBox1.Controls.Add(this.lbTotalRevenue);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(865, 446);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 135);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(1024, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Revenue Statistics";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(533, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Revenue Statistics";
            // 
            // tbFromdate
            // 
            this.tbFromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbFromdate.Location = new System.Drawing.Point(32, 613);
            this.tbFromdate.Name = "tbFromdate";
            this.tbFromdate.Size = new System.Drawing.Size(118, 22);
            this.tbFromdate.TabIndex = 20;
            // 
            // tbTodate
            // 
            this.tbTodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbTodate.Location = new System.Drawing.Point(303, 615);
            this.tbTodate.Name = "tbTodate";
            this.tbTodate.Size = new System.Drawing.Size(115, 22);
            this.tbTodate.TabIndex = 21;
            // 
            // FormRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 662);
            this.Controls.Add(this.tbTodate);
            this.Controls.Add(this.tbFromdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbselectID);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.cbRevebue);
            this.Controls.Add(this.btUpdata);
            this.Controls.Add(this.dataGridViewRevenue);
            this.Name = "FormRevenue";
            this.Text = "FormRevenue";
            this.Load += new System.EventHandler(this.FormRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRevenue;
        private System.Windows.Forms.Button btUpdata;
        private System.Windows.Forms.ComboBox cbRevebue;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.TextBox tbselectID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotalRevenue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbProfit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker tbFromdate;
        private System.Windows.Forms.DateTimePicker tbTodate;
    }
}