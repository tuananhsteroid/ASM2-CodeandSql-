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
    public partial class FormRevenue : Form
    {
        public FormRevenue()
        {
            InitializeComponent();
        }

        // Chuỗi kết nối đến SQL Server
        string connectionString = @"Data Source=TUANANH;Initial Catalog=DatabaseASM1;Integrated Security=True";

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;


        private void FormRevenue_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
        }






        private void btUpdata_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // The query to fetch data from the Products table
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

                // Assign the data to the DataGridView
                dataGridViewRevenue.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Show an error message if an exception occurs
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed after usage
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void cbRevebue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRevebue.SelectedItem.ToString() == "Calculate Total Revenue by Customer ID")
            {
                tbselectID.Enabled = true; 
            }
            else 
            {
                tbselectID.Enabled = false; 
            }

            if(cbRevebue.SelectedItem.ToString() == "Calculate Total Revenue by Day")
            {
                tbFromdate.Enabled = true;
                tbTodate.Enabled = true;
            }
            else
            {
                tbFromdate.Enabled = false;
                tbTodate.Enabled = false;
            }

            if(cbRevebue.SelectedItem.ToString() == "Calculate Total Revenue")
            {
                tbselectID.Enabled=false;
                tbTodate.Enabled=false;
                tbFromdate.Enabled=false;
            }


        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalRevenue = 0;

                // Lấy loại tính toán từ ComboBox
                string selectedOption = cbRevebue.SelectedItem.ToString();

                if (selectedOption == "Calculate Total Revenue by Day")
                {
                    // Lấy ngày bắt đầu và kết thúc
                    DateTime startDate = DateTime.Parse(tbFromdate.Text);
                    DateTime endDate = DateTime.Parse(tbTodate.Text);

                    // Lọc DataGridView theo khoảng thời gian
                    foreach (DataGridViewRow row in dataGridViewRevenue.Rows)
                    {
                        if (row.Cells["PurchaseDate"].Value != null)
                        {
                            DateTime purchaseDate = DateTime.Parse(row.Cells["PurchaseDate"].Value.ToString());
                            if (purchaseDate >= startDate && purchaseDate <= endDate)
                            {
                                row.DefaultCellStyle.BackColor = Color.LightGreen; // Bôi xanh
                                totalRevenue += Convert.ToDecimal(row.Cells["TotalAmount"].Value);
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.White; // Xóa màu
                            }
                        }
                    }
                }
                else if (selectedOption == "Calculate Total Revenue by Customer ID")
                {
                    // Lấy CustomerID cần tính
                    string customerId = tbselectID.Text; // Dùng txtStartDate để nhập ID

                    // Lọc DataGridView theo CustomerID
                    foreach (DataGridViewRow row in dataGridViewRevenue.Rows)
                    {
                        if (row.Cells["CustomerID"].Value != null &&
                            row.Cells["CustomerID"].Value.ToString() == customerId)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGreen; // Bôi xanh
                            totalRevenue += Convert.ToDecimal(row.Cells["TotalAmount"].Value);
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.White; // Xóa màu
                        }
                    }
                }
                else if (selectedOption == "Calculate Total Revenue")
                {
                    // Tính tổng tất cả các dòng
                    foreach (DataGridViewRow row in dataGridViewRevenue.Rows)
                    {
                        if (row.Cells["TotalAmount"].Value != null)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGreen; // Bôi xanh
                            totalRevenue += Convert.ToDecimal(row.Cells["TotalAmount"].Value);
                        }
                    }
                }

                // Hiển thị doanh thu và lợi nhuận
                lbTotalRevenue.Text = $"Total Revenue: {totalRevenue:C}";
                lbProfit.Text = $"Profit (25%): {totalRevenue * 0.25m:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Table manage_Table = new Manage_Table();
            this.Hide();
            manage_Table.ShowDialog();
            this.Close();
        }
    }
}
