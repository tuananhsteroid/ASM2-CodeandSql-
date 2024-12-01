namespace ASM1_Database
{
    partial class ConfirmAccount
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
            this.btyes = new System.Windows.Forms.Button();
            this.btno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(174, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Is this your first time shopping here?";
            // 
            // btyes
            // 
            this.btyes.Location = new System.Drawing.Point(196, 138);
            this.btyes.Name = "btyes";
            this.btyes.Size = new System.Drawing.Size(84, 51);
            this.btyes.TabIndex = 1;
            this.btyes.Text = "Yes";
            this.btyes.UseVisualStyleBackColor = true;
            this.btyes.Click += new System.EventHandler(this.btyes_Click);
            // 
            // btno
            // 
            this.btno.Location = new System.Drawing.Point(380, 138);
            this.btno.Name = "btno";
            this.btno.Size = new System.Drawing.Size(84, 51);
            this.btno.TabIndex = 2;
            this.btno.Text = "No";
            this.btno.UseVisualStyleBackColor = true;
            this.btno.Click += new System.EventHandler(this.btno_Click);
            // 
            // ConfirmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 330);
            this.Controls.Add(this.btno);
            this.Controls.Add(this.btyes);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btyes;
        private System.Windows.Forms.Button btno;
    }
}