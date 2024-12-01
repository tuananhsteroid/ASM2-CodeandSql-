using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM1_Database
{
    public partial class FormCofirmID : Form
    {
        public FormCofirmID()
        {
            InitializeComponent();
        }

        private void btenter_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=TUANANH;Initial Catalog=DatabaseASM1;Integrated Security=True";
            string customerID = tbCustomerID.Text; // Giả sử TextBox nhập ID có tên tbCustomerID

            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Please enter your Customer ID.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Truy vấn kiểm tra CustomerID
                    string checkQuery = "SELECT COUNT(*) FROM Customers WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(checkQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerID);

                        // Lấy số lượng bản ghi trùng CustomerID
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            // ID tồn tại, tiếp tục thực hiện thao tác
                            MessageBox.Show("Customer ID found. Proceeding with purchase.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Gọi hàm thực hiện thao tác mua hàng
                            PerformPurchase(customerID);
                        }
                        else
                        {
                            // ID không tồn tại
                            MessageBox.Show("Customer ID does not exist. Please check again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        FormShowProduct formShowProduct = new FormShowProduct();
                        this.Hide();
                        formShowProduct.ShowDialog();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // Hàm thực hiện mua hàng (ví dụ)
        private void PerformPurchase(string customerID)
        {
            // Thêm thông tin mua hàng vào cơ sở dữ liệu
            MessageBox.Show($"Performing purchase for Customer ID: {customerID}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btreturn_Click(object sender, EventArgs e)
        {
            ConfirmAccount confirmAccount = new ConfirmAccount();
            this.Hide();
            confirmAccount.ShowDialog();
            this.Close();
        }
    }
}
