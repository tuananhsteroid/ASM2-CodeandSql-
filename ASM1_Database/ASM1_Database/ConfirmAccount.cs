using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM1_Database
{
    public partial class ConfirmAccount : Form
    {
        public ConfirmAccount()
        {
            InitializeComponent();
        }

        private void btyes_Click(object sender, EventArgs e)
        {
            FormInfor formInfor = new FormInfor();
            this.Hide();
            formInfor.ShowDialog();
            this.Close();
        }

        private void btno_Click(object sender, EventArgs e)
        {
            FormCofirmID form2 = new FormCofirmID();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
    }
}
