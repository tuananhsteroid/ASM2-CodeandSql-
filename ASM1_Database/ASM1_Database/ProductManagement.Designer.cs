namespace ASM1_Database
{
    partial class ProductManagement
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
            this.datagridviewpr = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbprcode = new System.Windows.Forms.TextBox();
            this.tbprprice = new System.Windows.Forms.TextBox();
            this.tbprquantity = new System.Windows.Forms.TextBox();
            this.tbdescriptions = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ptimage = new System.Windows.Forms.PictureBox();
            this.btpradd = new System.Windows.Forms.Button();
            this.btpredit = new System.Windows.Forms.Button();
            this.btprdelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btuploadpr = new System.Windows.Forms.Button();
            this.tbprname = new System.Windows.Forms.TextBox();
            this.btimage = new System.Windows.Forms.Button();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.btsearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbprID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewpr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptimage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridviewpr
            // 
            this.datagridviewpr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewpr.Location = new System.Drawing.Point(12, 120);
            this.datagridviewpr.Name = "datagridviewpr";
            this.datagridviewpr.RowHeadersWidth = 51;
            this.datagridviewpr.RowTemplate.Height = 24;
            this.datagridviewpr.Size = new System.Drawing.Size(1007, 216);
            this.datagridviewpr.TabIndex = 0;
            this.datagridviewpr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewpr_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table Product Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(18, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(394, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descriptions";
            // 
            // tbprcode
            // 
            this.tbprcode.Location = new System.Drawing.Point(152, 357);
            this.tbprcode.Name = "tbprcode";
            this.tbprcode.Size = new System.Drawing.Size(144, 22);
            this.tbprcode.TabIndex = 7;
            // 
            // tbprprice
            // 
            this.tbprprice.Location = new System.Drawing.Point(152, 446);
            this.tbprprice.Name = "tbprprice";
            this.tbprprice.Size = new System.Drawing.Size(144, 22);
            this.tbprprice.TabIndex = 9;
            // 
            // tbprquantity
            // 
            this.tbprquantity.Location = new System.Drawing.Point(152, 490);
            this.tbprquantity.Name = "tbprquantity";
            this.tbprquantity.Size = new System.Drawing.Size(144, 22);
            this.tbprquantity.TabIndex = 10;
            // 
            // tbdescriptions
            // 
            this.tbdescriptions.Location = new System.Drawing.Point(386, 599);
            this.tbdescriptions.Multiline = true;
            this.tbdescriptions.Name = "tbdescriptions";
            this.tbdescriptions.Size = new System.Drawing.Size(256, 255);
            this.tbdescriptions.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(22, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sell price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(18, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Product Name";
            // 
            // ptimage
            // 
            this.ptimage.BackColor = System.Drawing.Color.Silver;
            this.ptimage.Location = new System.Drawing.Point(17, 33);
            this.ptimage.Name = "ptimage";
            this.ptimage.Size = new System.Drawing.Size(279, 251);
            this.ptimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptimage.TabIndex = 14;
            this.ptimage.TabStop = false;
            // 
            // btpradd
            // 
            this.btpradd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btpradd.Location = new System.Drawing.Point(794, 550);
            this.btpradd.Name = "btpradd";
            this.btpradd.Size = new System.Drawing.Size(94, 42);
            this.btpradd.TabIndex = 20;
            this.btpradd.Text = "Add";
            this.btpradd.UseVisualStyleBackColor = true;
            this.btpradd.Click += new System.EventHandler(this.btpradd_Click);
            // 
            // btpredit
            // 
            this.btpredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btpredit.Location = new System.Drawing.Point(794, 639);
            this.btpredit.Name = "btpredit";
            this.btpredit.Size = new System.Drawing.Size(94, 42);
            this.btpredit.TabIndex = 21;
            this.btpredit.Text = "Edit";
            this.btpredit.UseVisualStyleBackColor = true;
            this.btpredit.Click += new System.EventHandler(this.btpredit_Click);
            // 
            // btprdelete
            // 
            this.btprdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btprdelete.Location = new System.Drawing.Point(794, 728);
            this.btprdelete.Name = "btprdelete";
            this.btprdelete.Size = new System.Drawing.Size(94, 42);
            this.btprdelete.TabIndex = 22;
            this.btprdelete.Text = "Delete";
            this.btprdelete.UseVisualStyleBackColor = true;
            this.btprdelete.Click += new System.EventHandler(this.btprdelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(18, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Inventory Quantity";
            // 
            // btuploadpr
            // 
            this.btuploadpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btuploadpr.Location = new System.Drawing.Point(469, 375);
            this.btuploadpr.Name = "btuploadpr";
            this.btuploadpr.Size = new System.Drawing.Size(123, 42);
            this.btuploadpr.TabIndex = 25;
            this.btuploadpr.Text = "Upload data";
            this.btuploadpr.UseVisualStyleBackColor = true;
            this.btuploadpr.Click += new System.EventHandler(this.btuploadpr_Click);
            // 
            // tbprname
            // 
            this.tbprname.Location = new System.Drawing.Point(152, 402);
            this.tbprname.Name = "tbprname";
            this.tbprname.Size = new System.Drawing.Size(144, 22);
            this.tbprname.TabIndex = 26;
            // 
            // btimage
            // 
            this.btimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btimage.Location = new System.Drawing.Point(783, 805);
            this.btimage.Name = "btimage";
            this.btimage.Size = new System.Drawing.Size(116, 56);
            this.btimage.TabIndex = 19;
            this.btimage.Text = "Add Image";
            this.btimage.UseVisualStyleBackColor = true;
            this.btimage.Click += new System.EventHandler(this.btimage_Click);
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(469, 487);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(244, 22);
            this.tbsearch.TabIndex = 27;
            // 
            // btsearch
            // 
            this.btsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btsearch.Location = new System.Drawing.Point(794, 476);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(94, 42);
            this.btsearch.TabIndex = 28;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(18, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "ProductID";
            // 
            // tbprID
            // 
            this.tbprID.Location = new System.Drawing.Point(152, 310);
            this.tbprID.Name = "tbprID";
            this.tbprID.Size = new System.Drawing.Size(144, 22);
            this.tbprID.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(328, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(486, 32);
            this.label8.TabIndex = 32;
            this.label8.Text = "WelCome To Tuan@nh BookStore ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ptimage);
            this.groupBox1.Controls.Add(this.tbprname);
            this.groupBox1.Controls.Add(this.tbprID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbprcode);
            this.groupBox1.Controls.Add(this.tbprprice);
            this.groupBox1.Controls.Add(this.tbprquantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(18, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 524);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ASM1_Database.Properties.Resources.dangki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 889);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.btuploadpr);
            this.Controls.Add(this.btprdelete);
            this.Controls.Add(this.btpredit);
            this.Controls.Add(this.btpradd);
            this.Controls.Add(this.btimage);
            this.Controls.Add(this.tbdescriptions);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridviewpr);
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewpr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptimage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridviewpr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbprcode;
        private System.Windows.Forms.TextBox tbprprice;
        private System.Windows.Forms.TextBox tbprquantity;
        private System.Windows.Forms.TextBox tbdescriptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptimage;
        private System.Windows.Forms.Button btpradd;
        private System.Windows.Forms.Button btpredit;
        private System.Windows.Forms.Button btprdelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btuploadpr;
        private System.Windows.Forms.TextBox tbprname;
        private System.Windows.Forms.Button btimage;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbprID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}