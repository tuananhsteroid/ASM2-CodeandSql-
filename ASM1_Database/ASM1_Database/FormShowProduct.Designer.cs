namespace ASM1_Database
{
    partial class FormShowProduct
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
            this.datagridviewshowpr = new System.Windows.Forms.DataGridView();
            this.ptShowpr = new System.Windows.Forms.PictureBox();
            this.tbDesPr = new System.Windows.Forms.TextBox();
            this.tbNamepr = new System.Windows.Forms.TextBox();
            this.tbPricePr = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btBuypr = new System.Windows.Forms.Button();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPRid = new System.Windows.Forms.TextBox();
            this.tbprsearch = new System.Windows.Forms.TextBox();
            this.btReseach = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btupload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewshowpr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptShowpr)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridviewshowpr
            // 
            this.datagridviewshowpr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewshowpr.Location = new System.Drawing.Point(12, 58);
            this.datagridviewshowpr.Name = "datagridviewshowpr";
            this.datagridviewshowpr.RowHeadersWidth = 51;
            this.datagridviewshowpr.RowTemplate.Height = 24;
            this.datagridviewshowpr.Size = new System.Drawing.Size(1022, 263);
            this.datagridviewshowpr.TabIndex = 0;
            this.datagridviewshowpr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewshowpr_CellContentClick);
            // 
            // ptShowpr
            // 
            this.ptShowpr.BackColor = System.Drawing.SystemColors.Control;
            this.ptShowpr.Location = new System.Drawing.Point(19, 22);
            this.ptShowpr.Name = "ptShowpr";
            this.ptShowpr.Size = new System.Drawing.Size(276, 240);
            this.ptShowpr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptShowpr.TabIndex = 1;
            this.ptShowpr.TabStop = false;
            // 
            // tbDesPr
            // 
            this.tbDesPr.Location = new System.Drawing.Point(362, 509);
            this.tbDesPr.Multiline = true;
            this.tbDesPr.Name = "tbDesPr";
            this.tbDesPr.Size = new System.Drawing.Size(283, 289);
            this.tbDesPr.TabIndex = 2;
            // 
            // tbNamepr
            // 
            this.tbNamepr.Location = new System.Drawing.Point(117, 329);
            this.tbNamepr.Name = "tbNamepr";
            this.tbNamepr.Size = new System.Drawing.Size(178, 22);
            this.tbNamepr.TabIndex = 3;
            // 
            // tbPricePr
            // 
            this.tbPricePr.Location = new System.Drawing.Point(117, 367);
            this.tbPricePr.Name = "tbPricePr";
            this.tbPricePr.Size = new System.Drawing.Size(178, 22);
            this.tbPricePr.TabIndex = 4;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(117, 405);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(178, 22);
            this.tbQuantity.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity to buy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // btBuypr
            // 
            this.btBuypr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btBuypr.Location = new System.Drawing.Point(873, 753);
            this.btBuypr.Name = "btBuypr";
            this.btBuypr.Size = new System.Drawing.Size(102, 43);
            this.btBuypr.TabIndex = 10;
            this.btBuypr.Text = "BUY";
            this.btBuypr.UseVisualStyleBackColor = true;
            this.btBuypr.Click += new System.EventHandler(this.btBuypr_Click);
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(17, 121);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(212, 22);
            this.tbid.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "CustomerID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Please enter your correct ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Product ID";
            // 
            // tbPRid
            // 
            this.tbPRid.Location = new System.Drawing.Point(117, 285);
            this.tbPRid.Name = "tbPRid";
            this.tbPRid.Size = new System.Drawing.Size(178, 22);
            this.tbPRid.TabIndex = 16;
            // 
            // tbprsearch
            // 
            this.tbprsearch.Location = new System.Drawing.Point(362, 393);
            this.tbprsearch.Name = "tbprsearch";
            this.tbprsearch.Size = new System.Drawing.Size(258, 22);
            this.tbprsearch.TabIndex = 18;
            // 
            // btReseach
            // 
            this.btReseach.Location = new System.Drawing.Point(667, 393);
            this.btReseach.Name = "btReseach";
            this.btReseach.Size = new System.Drawing.Size(97, 36);
            this.btReseach.TabIndex = 19;
            this.btReseach.Text = "Research";
            this.btReseach.UseVisualStyleBackColor = true;
            this.btReseach.Click += new System.EventHandler(this.btReseach_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(306, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(486, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "WelCome To Tuan@nh BookStore ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ptShowpr);
            this.groupBox1.Controls.Add(this.tbPricePr);
            this.groupBox1.Controls.Add(this.tbNamepr);
            this.groupBox1.Controls.Add(this.tbQuantity);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPRid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 456);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Research Book";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbid);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(726, 509);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 172);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // btupload
            // 
            this.btupload.Location = new System.Drawing.Point(859, 361);
            this.btupload.Name = "btupload";
            this.btupload.Size = new System.Drawing.Size(96, 42);
            this.btupload.TabIndex = 24;
            this.btupload.Text = "UpLoad";
            this.btupload.UseVisualStyleBackColor = true;
            this.btupload.Click += new System.EventHandler(this.btupload_Click);
            // 
            // FormShowProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ASM1_Database.Properties.Resources.dangki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 835);
            this.Controls.Add(this.btupload);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btReseach);
            this.Controls.Add(this.tbprsearch);
            this.Controls.Add(this.btBuypr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDesPr);
            this.Controls.Add(this.datagridviewshowpr);
            this.Name = "FormShowProduct";
            this.Text = "FormShowProduct";
            this.Load += new System.EventHandler(this.FormShowProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewshowpr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptShowpr)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridviewshowpr;
        private System.Windows.Forms.PictureBox ptShowpr;
        private System.Windows.Forms.TextBox tbDesPr;
        private System.Windows.Forms.TextBox tbNamepr;
        private System.Windows.Forms.TextBox tbPricePr;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btBuypr;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPRid;
        private System.Windows.Forms.TextBox tbprsearch;
        private System.Windows.Forms.Button btReseach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btupload;
    }
}