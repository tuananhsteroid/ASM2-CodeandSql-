using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ASM1_Database
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        // Chuỗi kết nối đến SQL Server
        string connectionString = @"Data Source=TUANANH;Initial Catalog=DatabaseASM1;Integrated Security=True";

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;

        private void Customers_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            
        }

        private void upload_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = @"
            SELECT 
                CustomerID, 
                CustomerName, 
                PhoneNumber, 
                AddressCustomer
            FROM 
                Customers";

                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);

                dataGridViewcustomer.DataSource = dt;

                
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }



        private void dataGridViewcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                DataGridViewRow row = dataGridViewcustomer.Rows[e.RowIndex];

               
                tbname.Text = row.Cells["CustomerName"].Value.ToString();
                tbphone.Text = row.Cells["PhoneNumber"].Value.ToString();
                tbaddress.Text = row.Cells["AddressCustomer"].Value.ToString();
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewcustomer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }

            int customerId = Convert.ToInt32(dataGridViewcustomer.SelectedRows[0].Cells["CustomerID"].Value);
            string customerName = tbname.Text;
            string phoneNumber = tbphone.Text;
            string address = tbaddress.Text;

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            try
            {
                con.Open();
                string query = "UPDATE Customers SET CustomerName = @CustomerName, PhoneNumber = @PhoneNumber, " +
                    "AddressCustomer = @AddressCustomer WHERE CustomerID = @CustomerID";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@AddressCustomer", address);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);  
                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer updated successfully.");

                

                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }




        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewcustomer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            int customerId = Convert.ToInt32(dataGridViewcustomer.SelectedRows[0].Cells["CustomerID"].Value);

            try
            {
                con.Open();
                string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer deleted successfully.");

                
                ClearTextBox();

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = tbsearch.Text;

            try
            {
                con.Open();
                string query = "SELECT CustomerID, CustomerName, PhoneNumber, AddressCustomer " +
                    "FROM Customers WHERE CustomerID LIKE @SearchQuery OR CustomerName LIKE @SearchQuery";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);

                dataGridViewcustomer.DataSource = dt;

                
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void ClearTextBox()
        {
            tbname.Clear();
            tbphone.Clear();
            tbaddress.Clear();
        }

    }
}
