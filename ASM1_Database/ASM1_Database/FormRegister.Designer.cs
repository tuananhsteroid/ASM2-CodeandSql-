namespace ASM1_Database
{
    partial class FormRegister
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
            this.btRegister = new System.Windows.Forms.Button();
            this.lbRegister = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.btRegister);
            this.groupBox1.Controls.Add(this.lbRegister);
            this.groupBox1.Controls.Add(this.btExit);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.lbPassword);
            this.groupBox1.Controls.Add(this.tbUsename);
            this.groupBox1.Controls.Add(this.lbUsename);
            this.groupBox1.Location = new System.Drawing.Point(247, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 380);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(114, 306);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(104, 47);
            this.btRegister.TabIndex = 14;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRegister.Location = new System.Drawing.Point(187, 88);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(157, 32);
            this.lbRegister.TabIndex = 13;
            this.lbRegister.Text = "REGISTER";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(331, 307);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(97, 46);
            this.btExit.TabIndex = 12;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(159, 233);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(239, 22);
            this.tbPassword.TabIndex = 10;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(54, 239);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(67, 16);
            this.lbPassword.TabIndex = 9;
            this.lbPassword.Text = "Password";
            // 
            // tbUsename
            // 
            this.tbUsename.Location = new System.Drawing.Point(159, 173);
            this.tbUsename.Name = "tbUsename";
            this.tbUsename.Size = new System.Drawing.Size(239, 22);
            this.tbUsename.TabIndex = 8;
            // 
            // lbUsename
            // 
            this.lbUsename.AutoSize = true;
            this.lbUsename.Location = new System.Drawing.Point(54, 173);
            this.lbUsename.Name = "lbUsename";
            this.lbUsename.Size = new System.Drawing.Size(66, 16);
            this.lbUsename.TabIndex = 7;
            this.lbUsename.Text = "Usename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(278, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "WelCome To Tuan@nh BookStore ";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(985, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUsename;
        private System.Windows.Forms.Label lbUsename;
        private System.Windows.Forms.Label label3;
    }
}