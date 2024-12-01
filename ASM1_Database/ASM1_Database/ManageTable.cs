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
    public partial class Manage_Table : Form
    {
        public Manage_Table()
        {
            InitializeComponent();
        }

        private void btCustomer_Click(object sender, EventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement();
            
            customerManagement.Show();
            
        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            Employeemanagement employeemanagement = new Employeemanagement();
            this.Hide();
            employeemanagement.ShowDialog();
            this.Close();

        }

        private void btProduct_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            
            productManagement.Show();
            
        }

        private void btRevenue_Click(object sender, EventArgs e)
        {
            FormRevenue revenue = new FormRevenue();
            this.Hide();
            revenue.ShowDialog();
            this.Close();
        }

        private void btStaticPr_Click(object sender, EventArgs e)
        {
            ProductStatisticsForm productStatisticsForm = new ProductStatisticsForm();
            productStatisticsForm.Show();
        }

        private void btCus_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }
    }
}
