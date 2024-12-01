namespace ASM1_Database
{
    partial class FormLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbemp = new System.Windows.Forms.ComboBox();
            this.lbMenuRole = new System.Windows.Forms.Label();
            this.CbMenuRole = new System.Windows.Forms.ComboBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUsename = new System.Windows.Forms.TextBox();
            this.lbUsename = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbemp);
            this.groupBox1.Controls.Add(this.lbMenuRole);
            this.groupBox1.Controls.Add(this.CbMenuRole);
            this.groupBox1.Controls.Add(this.btRegister);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btExit);
            this.groupBox1.Controls.Add(this.btLogin);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.lbPassword);
            this.groupBox1.Controls.Add(this.tbUsename);
            this.groupBox1.Controls.Add(this.lbUsename);
            this.groupBox1.Location = new System.Drawing.Point(178, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 342);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Position";
            // 
            // cbemp
            // 
            this.cbemp.FormattingEnabled = true;
            this.cbemp.Items.AddRange(new object[] {
            "Sales staff",
            "",
            "Warehouse staff"});
            this.cbemp.Location = new System.Drawing.Point(478, 256);
            this.cbemp.Name = "cbemp";
            this.cbemp.Size = new System.Drawing.Size(138, 24);
            this.cbemp.TabIndex = 17;
            // 
            // lbMenuRole
            // 
            this.lbMenuRole.AutoSize = true;
            this.lbMenuRole.Location = new System.Drawing.Point(507, 121);
            this.lbMenuRole.Name = "lbMenuRole";
            this.lbMenuRole.Size = new System.Drawing.Size(69, 16);
            this.lbMenuRole.TabIndex = 16;
            this.lbMenuRole.Text = "MenuRole";
            // 
            // CbMenuRole
            // 
            this.CbMenuRole.FormattingEnabled = true;
            this.CbMenuRole.Items.AddRange(new object[] {
            "Customer",
            "Employee",
            "Manager"});
            this.CbMenuRole.Location = new System.Drawing.Point(467, 152);
            this.CbMenuRole.Name = "CbMenuRole";
            this.CbMenuRole.Size = new System.Drawing.Size(149, 24);
            this.CbMenuRole.TabIndex = 15;
            this.CbMenuRole.SelectedIndexChanged += new System.EventHandler(this.CbMenuRole_SelectedIndexChanged);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(183, 264);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(104, 47);
            this.btRegister.TabIndex = 14;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(292, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "LOGIN";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(337, 264);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(97, 46);
            this.btExit.TabIndex = 12;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(43, 264);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(104, 47);
            this.btLogin.TabIndex = 11;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(154, 197);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(239, 22);
            this.tbPassword.TabIndex = 10;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(39, 203);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(67, 16);
            this.lbPassword.TabIndex = 9;
            this.lbPassword.Text = "Password";
            // 
            // tbUsename
            // 
            this.tbUsename.Location = new System.Drawing.Point(154, 115);
            this.tbUsename.Name = "tbUsename";
            this.tbUsename.Size = new System.Drawing.Size(239, 22);
            this.tbUsename.TabIndex = 8;
            // 
            // lbUsename
            // 
            this.lbUsename.AutoSize = true;
            this.lbUsename.Location = new System.Drawing.Point(40, 121);
            this.lbUsename.Name = "lbUsename";
            this.lbUsename.Size = new System.Drawing.Size(66, 16);
            this.lbUsename.TabIndex = 7;
            this.lbUsename.Text = "Usename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(275, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "WelCome To Tuan@nh BookStore ";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ASM1_Database.Properties.Resources.dangki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(987, 579);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUsename;
        private System.Windows.Forms.Label lbUsename;
        private System.Windows.Forms.ComboBox CbMenuRole;
        private System.Windows.Forms.Label lbMenuRole;
        private System.Windows.Forms.ComboBox cbemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}