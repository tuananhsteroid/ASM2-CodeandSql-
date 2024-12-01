namespace ASM1_Database
{
    partial class Employeemanagement
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.cbposition = new System.Windows.Forms.ComboBox();
            this.tbEmpFN = new System.Windows.Forms.TextBox();
            this.tbEmpCode = new System.Windows.Forms.TextBox();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbUsenameEmp = new System.Windows.Forms.TextBox();
            this.tbPassEmp = new System.Windows.Forms.TextBox();
            this.tbAccID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEmp = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpload = new System.Windows.Forms.Button();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.btsearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.gb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.cbposition);
            this.gb.Controls.Add(this.tbEmpFN);
            this.gb.Controls.Add(this.tbEmpCode);
            this.gb.Controls.Add(this.tbEmpID);
            this.gb.Controls.Add(this.label5);
            this.gb.Controls.Add(this.label4);
            this.gb.Controls.Add(this.label3);
            this.gb.Controls.Add(this.label2);
            this.gb.Location = new System.Drawing.Point(98, 459);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(408, 204);
            this.gb.TabIndex = 3;
            this.gb.TabStop = false;
            // 
            // cbposition
            // 
            this.cbposition.FormattingEnabled = true;
            this.cbposition.Items.AddRange(new object[] {
            "Sales staff",
            "",
            "Warehouse staff"});
            this.cbposition.Location = new System.Drawing.Point(176, 170);
            this.cbposition.Name = "cbposition";
            this.cbposition.Size = new System.Drawing.Size(210, 24);
            this.cbposition.TabIndex = 7;
            // 
            // tbEmpFN
            // 
            this.tbEmpFN.Location = new System.Drawing.Point(176, 117);
            this.tbEmpFN.Name = "tbEmpFN";
            this.tbEmpFN.Size = new System.Drawing.Size(210, 22);
            this.tbEmpFN.TabIndex = 6;
            // 
            // tbEmpCode
            // 
            this.tbEmpCode.Location = new System.Drawing.Point(176, 67);
            this.tbEmpCode.Name = "tbEmpCode";
            this.tbEmpCode.Size = new System.Drawing.Size(210, 22);
            this.tbEmpCode.TabIndex = 5;
            // 
            // tbEmpID
            // 
            this.tbEmpID.Location = new System.Drawing.Point(176, 17);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.Size = new System.Drawing.Size(210, 22);
            this.tbEmpID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Employee Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "EmployeeCode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "EmployeeID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbUsenameEmp);
            this.groupBox1.Controls.Add(this.tbPassEmp);
            this.groupBox1.Controls.Add(this.tbAccID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(637, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 191);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // tbUsenameEmp
            // 
            this.tbUsenameEmp.Location = new System.Drawing.Point(125, 73);
            this.tbUsenameEmp.Name = "tbUsenameEmp";
            this.tbUsenameEmp.Size = new System.Drawing.Size(183, 22);
            this.tbUsenameEmp.TabIndex = 7;
            // 
            // tbPassEmp
            // 
            this.tbPassEmp.Location = new System.Drawing.Point(125, 123);
            this.tbPassEmp.Name = "tbPassEmp";
            this.tbPassEmp.Size = new System.Drawing.Size(183, 22);
            this.tbPassEmp.TabIndex = 6;
            // 
            // tbAccID
            // 
            this.tbAccID.Location = new System.Drawing.Point(125, 23);
            this.tbAccID.Name = "tbAccID";
            this.tbAccID.Size = new System.Drawing.Size(183, 22);
            this.tbAccID.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "* Password must be more than 8 characters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "UseName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Account ID";
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDelete.Location = new System.Drawing.Point(750, 730);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(90, 43);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btEdit.Location = new System.Drawing.Point(601, 730);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(90, 43);
            this.btEdit.TabIndex = 7;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btReturn
            // 
            this.btReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btReturn.Location = new System.Drawing.Point(912, 730);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(90, 43);
            this.btReturn.TabIndex = 9;
            this.btReturn.Text = "Return";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(461, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Table Employee management";
            // 
            // dataGridViewEmp
            // 
            this.dataGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmp.Location = new System.Drawing.Point(17, 58);
            this.dataGridViewEmp.Name = "dataGridViewEmp";
            this.dataGridViewEmp.RowHeadersWidth = 51;
            this.dataGridViewEmp.RowTemplate.Height = 24;
            this.dataGridViewEmp.Size = new System.Drawing.Size(1005, 302);
            this.dataGridViewEmp.TabIndex = 12;
            this.dataGridViewEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmp_CellContentClick_1);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAdd.Location = new System.Drawing.Point(450, 730);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(90, 43);
            this.btAdd.TabIndex = 13;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click_1);
            // 
            // btUpload
            // 
            this.btUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btUpload.Location = new System.Drawing.Point(503, 380);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(104, 58);
            this.btUpload.TabIndex = 14;
            this.btUpload.Text = "Uplooad Data";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(33, 741);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(208, 22);
            this.tbsearch.TabIndex = 15;
            this.tbsearch.TextChanged += new System.EventHandler(this.tbsearch_TextChanged);
            // 
            // btsearch
            // 
            this.btsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btsearch.Location = new System.Drawing.Point(285, 732);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(110, 38);
            this.btsearch.TabIndex = 16;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 712);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Search Employee";
            // 
            // Employeemanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 799);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dataGridViewEmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb);
            this.Name = "Employeemanagement";
            this.Text = "Employeemanagement";
            this.Load += new System.EventHandler(this.Employeemanagement_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmpFN;
        private System.Windows.Forms.TextBox tbEmpCode;
        private System.Windows.Forms.TextBox tbEmpID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPassEmp;
        private System.Windows.Forms.TextBox tbAccID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUsenameEmp;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEmp;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.ComboBox cbposition;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Label label10;
    }
}