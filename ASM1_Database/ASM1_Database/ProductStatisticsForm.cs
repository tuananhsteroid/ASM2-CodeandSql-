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
    public partial class ProductStatisticsForm : Form
    {
        public ProductStatisticsForm()
        {
            InitializeComponent();
        }

        // Chuỗi kết nối đến SQL Server
        string connectionString = @"Data Source=TUANANH;Initial Catalog=DatabaseASM1;Integrated Security=True";

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;


        private void ProductStatisticsForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
        }
    
       private void btUP_Click(object sender, EventArgs e)
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
                dataGridViewStaticPR.DataSource = dt;
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

        private void btsearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = tbsearch.Text.Trim(); // Lấy từ khóa tìm kiếm từ TextBox
            DateTime fromDate, toDate; // Khai báo biến ngày

            // Kiểm tra nếu các ô From Date và To Date không rỗng và là ngày hợp lệ
            if (!DateTime.TryParse(DtFormDate.Text.Trim(), out fromDate))
            {
                MessageBox.Show("Invalid From Date. Please enter a valid date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(DtToDate.Text.Trim(), out toDate))
            {
                MessageBox.Show("Invalid To Date. Please enter a valid date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chỉ so sánh phần ngày, không lấy giờ phút
            fromDate = fromDate.Date;
            toDate = toDate.Date;

            // Kiểm tra nếu From Date lớn hơn To Date
            if (fromDate > toDate)
            {
                MessageBox.Show("From Date cannot be greater than To Date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(searchKeyword))
            {
                MessageBox.Show("Please enter a search keyword.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();

                // Câu truy vấn tìm kiếm dựa trên từ khóa
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
        LEFT JOIN Products AS eea ON eea.ProductID = ea.ProductID
        WHERE 
            ea.PurchaseDate >= @FromDate AND ea.PurchaseDate <= @ToDate"; // Thêm điều kiện so sánh ngày

                // Thêm tham số vào câu lệnh SQL
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FromDate", fromDate);
                cmd.Parameters.AddWithValue("@ToDate", toDate);
                cmd.Parameters.AddWithValue("@Keyword", "%" + searchKeyword + "%");

                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);

                // Hiển thị kết quả tìm kiếm trong DataGridView
                dataGridViewStaticPR.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No results found.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Bôi xanh hàng chứa từ khóa tìm kiếm
                    HighlightSearchResults(searchKeyword);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void HighlightSearchResults(string searchKeyword)
        {
            foreach (DataGridViewRow row in dataGridViewStaticPR.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White; // Reset màu mặc định

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchKeyword.ToLower()))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen; // Bôi xanh hàng chứa kết quả
                        break;
                    }
                }
            }
        }

        private void btCalPrQuan_Click(object sender, EventArgs e)
        {
            string bookName = tbsearch.Text.Trim(); // Tên sách nhập từ TextBox
            DateTime startDate = DtFormDate.Value.Date; // Ngày bắt đầu
            DateTime endDate = DtToDate.Value.Date; // Ngày kết thúc

            if (string.IsNullOrEmpty(bookName))
            {
                MessageBox.Show("Please enter a book name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();

                // Câu truy vấn lọc dữ liệu
                string query = @"
        SELECT 
            e.CustomerID, 
            e.CustomerName, 
            e.PhoneNumber,
            e.AddressCustomer,
            ea.PurchaseID,
            ea.PurchaseDate,
            eea.ProductName,
            ea.Quantity, -- Dùng cột Quantity thay cho TotalQuantity
            ea.TotalAmount
        FROM 
            Customers AS e
        LEFT JOIN CustomerPurchaseHistory AS ea ON e.CustomerID = ea.CustomerID
        LEFT JOIN Products AS eea ON eea.ProductID = ea.ProductID
        WHERE 
            eea.ProductName LIKE @BookName AND 
            ea.PurchaseDate >= @StartDate AND 
            ea.PurchaseDate <= @EndDate";  // Thêm điều kiện cho ProductName và Date

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BookName", "%" + bookName + "%");
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);

                // Hiển thị dữ liệu trong DataGridView
                dataGridViewStaticPR.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    string productName = dt.Rows[0]["ProductName"].ToString();

                    // Hiển thị ProductID và ProductName lên Label
                    lbStaticPrName.Text = $"Product Name: {productName}";

                    // Tính tổng số sản phẩm đã bán
                    int totalQuantity = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        totalQuantity += Convert.ToInt32(row["Quantity"]); // Dùng cột Quantity thay vì TotalQuantity
                    }

                    // Hiển thị tổng số sản phẩm đã bán
                    lbStaticPrQuan.Text = $"Total Sold: {totalQuantity}";

                    // Bôi xanh các hàng chứa kết quả
                    HighlightSearchResults(bookName);
                }
                else
                {
                    MessageBox.Show("No results found for the specified book and date range.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


    }
}
