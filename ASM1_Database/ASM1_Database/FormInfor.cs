using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM1_Database
{
    public partial class FormInfor : Form
    {
        public FormInfor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = tbID.Text;
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string address = tbAddress.Text;

            // Kiểm tra các trường nhập liệu trước khi thực thi câu lệnh SQL
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your Name", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please enter your Phone Number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter your Address", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter your ID", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Chuỗi kết nối đến SQL Server
            string connectionString = @"Data Source=TUANANH;Initial Catalog=DatabaseASM1;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;

                try
                {
                    connection.Open();

                    
                    
                    transaction = connection.BeginTransaction();

                    // Chèn dữ liệu vào bảng Customers
                    string insertCustomerQuery = "INSERT INTO Customers ( CustomerID, CustomerName, PhoneNumber, AddressCustomer) VALUES (@ID, @Name, @Phone, @Address)";
                    using (SqlCommand insertCommand = new SqlCommand(insertCustomerQuery, connection, transaction))
                    {
                        insertCommand.Parameters.AddWithValue("@ID", id);
                        insertCommand.Parameters.AddWithValue("@Name", name);
                        insertCommand.Parameters.AddWithValue("@Phone", phone);
                        insertCommand.Parameters.AddWithValue("@Address", address);

                        int result = insertCommand.ExecuteNonQuery();
                        if (result <= 0)
                        {
                            throw new Exception("Failed to insert customer record.");
                        }

                        
                    }

                    string Query = "INSERT INTO CustomerPurchaseHistory ( CustomerID) VALUES (@Id)";
                    using (SqlCommand insertCommand = new SqlCommand(Query, connection, transaction))
                    {
                        insertCommand.Parameters.AddWithValue("@Id", id);
                        

                        int result = insertCommand.ExecuteNonQuery();
                        if (result <= 0)
                        {
                            throw new Exception("Failed to insert customer record.");
                        }


                    }

                    
                    // Commit giao dịch nếu không có lỗi
                    transaction.Commit();
                    MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormShowProduct formShowProduct = new FormShowProduct();
                    this.Hide();
                    formShowProduct.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Rollback giao dịch nếu có lỗi
                    transaction?.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }




    }
}
