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
    public partial class CustomerManagement : Form
    {
        public CustomerManagement()
        {
            InitializeComponent();
        }

        // Chuỗi kết nối đến SQL Server
        string connectionString = @"Data Source=TUANANH;Initial Catalog=DatabaseASM1;Integrated Security=True";

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;

        
        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
        }

        private void btuploadCus_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Câu truy vấn chỉ lấy dữ liệu từ bảng Products
                string query = @"
                SELECT 
                    e.CustomerID, 
                    e.CustomerName, 
                    e.PhoneNumber,
                    e.AddressCustomer,
                    ea.PurchaseID,
                    ea.PurchaseDate,
                    eea.ProductName,
                    ea.Quantity,
                    ea.TotalAmount
                FROM 
                    Customers AS e
                LEFT JOIN CustomerPurchaseHistory AS ea ON e.CustomerID = ea.CustomerID
                LEFT JOIN Products AS eea ON eea.ProductID = ea.ProductID";


                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);

                // Gán dữ liệu cho DataGridView
                datagridviewCus.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Đảm bảo đóng kết nối sau khi sử dụng
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btprintbill_Click(object sender, EventArgs e)
        {
            
                if (datagridviewCus.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = datagridviewCus.SelectedRows[0];

                    string customerID = selectedRow.Cells["CustomerID"].Value?.ToString();
                    string customerName = selectedRow.Cells["CustomerName"].Value?.ToString();
                    string Phone = selectedRow.Cells["PhoneNumber"].Value?.ToString();
                    string Address = selectedRow.Cells["AddressCustomer"].Value?.ToString();
                    string PurchaseID = selectedRow.Cells["PurchaseID"].Value?.ToString();
                    string PurchaseDate = selectedRow.Cells["PurchaseDate"].Value?.ToString();
                    string productName = selectedRow.Cells["ProductName"].Value?.ToString();
                    int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value ?? 0);
                    decimal totalAmount = Convert.ToDecimal(selectedRow.Cells["TotalAmount"].Value ?? 0);

                    // Mở FormBill và truyền dữ liệu
                    FormPrintBill billForm = new FormPrintBill();
                    billForm.SetBillDetails(customerID, customerName, Phone, Address, PurchaseID, PurchaseDate, productName, quantity, totalAmount);

                    // Hiển thị FormBill
                    billForm.ShowDialog();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Please select a row to view the bill!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }
    }
}
