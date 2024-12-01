namespace ASM1_Database
{
    partial class CustomerManagement
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
            this.datagridviewCus = new System.Windows.Forms.DataGridView();
            this.btuploadCus = new System.Windows.Forms.Button();
            this.btprintbill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewCus)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridviewCus
            // 
            this.datagridviewCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewCus.Location = new System.Drawing.Point(12, 81);
            this.datagridviewCus.Name = "datagridviewCus";
            this.datagridviewCus.RowHeadersWidth = 51;
            this.datagridviewCus.RowTemplate.Height = 24;
            this.datagridviewCus.Size = new System.Drawing.Size(903, 184);
            this.datagridviewCus.TabIndex = 0;
            // 
            // btuploadCus
            // 
            this.btuploadCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btuploadCus.Location = new System.Drawing.Point(428, 296);
            this.btuploadCus.Name = "btuploadCus";
            this.btuploadCus.Size = new System.Drawing.Size(101, 41);
            this.btuploadCus.TabIndex = 1;
            this.btuploadCus.Text = "UpLoad";
            this.btuploadCus.UseVisualStyleBackColor = true;
            this.btuploadCus.Click += new System.EventHandler(this.btuploadCus_Click);
            // 
            // btprintbill
            // 
            this.btprintbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btprintbill.Location = new System.Drawing.Point(717, 345);
            this.btprintbill.Name = "btprintbill";
            this.btprintbill.Size = new System.Drawing.Size(117, 43);
            this.btprintbill.TabIndex = 2;
            this.btprintbill.Text = "Print Bill";
            this.btprintbill.UseVisualStyleBackColor = true;
            this.btprintbill.Click += new System.EventHandler(this.btprintbill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Information and customer purchase history.";
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btprintbill);
            this.Controls.Add(this.btuploadCus);
            this.Controls.Add(this.datagridviewCus);
            this.Name = "CustomerManagement";
            this.Text = "CustomerManagement";
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridviewCus;
        private System.Windows.Forms.Button btuploadCus;
        private System.Windows.Forms.Button btprintbill;
        private System.Windows.Forms.Label label1;
    }
}