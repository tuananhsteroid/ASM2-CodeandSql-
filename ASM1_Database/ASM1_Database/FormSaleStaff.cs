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
    public partial class FormSaleStaff : Form
    {
        public FormSaleStaff()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement();

            customerManagement.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductStatisticsForm productStatisticsForm = new ProductStatisticsForm();
            productStatisticsForm.Show();
        }
    }
}
