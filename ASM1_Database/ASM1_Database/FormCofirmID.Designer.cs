namespace ASM1_Database
{
    partial class FormCofirmID
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.btenter = new System.Windows.Forms.Button();
            this.btreturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(131, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "If you already have information, please enter CustomerID to confirm.";
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(285, 208);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(158, 22);
            this.tbCustomerID.TabIndex = 1;
            // 
            // btenter
            // 
            this.btenter.Location = new System.Drawing.Point(247, 263);
            this.btenter.Name = "btenter";
            this.btenter.Size = new System.Drawing.Size(93, 30);
            this.btenter.TabIndex = 2;
            this.btenter.Text = "Enter";
            this.btenter.UseVisualStyleBackColor = true;
            this.btenter.Click += new System.EventHandler(this.btenter_Click);
            // 
            // btreturn
            // 
            this.btreturn.Location = new System.Drawing.Point(397, 263);
            this.btreturn.Name = "btreturn";
            this.btreturn.Size = new System.Drawing.Size(93, 30);
            this.btreturn.TabIndex = 3;
            this.btreturn.Text = "Return";
            this.btreturn.UseVisualStyleBackColor = true;
            this.btreturn.Click += new System.EventHandler(this.btreturn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(128, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "WelCome To Tuan@nh BookStore ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 373);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btreturn);
            this.Controls.Add(this.btenter);
            this.Controls.Add(this.tbCustomerID);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.Button btenter;
        private System.Windows.Forms.Button btreturn;
        private System.Windows.Forms.Label label3;
    }
}