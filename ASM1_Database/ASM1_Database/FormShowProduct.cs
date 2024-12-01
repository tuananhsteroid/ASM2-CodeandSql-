using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;  // Đảm bảo sử dụng System.Drawing cho Image
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM1_Database
{
    public partial class FormShowProduct : Form
    {
        public FormShowProduct()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=TUANANH;Initial Catalog=DatabaseASM1;Integrated Security=True";

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;

        private void btupload_Click(object sender, EventArgs e)
        {
            try
            {
                
                con.Open();

                // Câu truy vấn lấy dữ liệu từ bảng Products
                string query = @"
                SELECT 
                ProductID,
                ProductCode, 
                ProductName, 
                SellingPrice, 
                InventoryQuantity, 
                Descriptions,
                ImagesProduct 
                FROM 
                Products";

                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);

                
                datagridviewshowpr.DataSource = dt;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
               
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void FormShowProduct_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            
        }

       
        private void datagridviewshowpr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = datagridviewshowpr.Rows[e.RowIndex];

                // Gán thông tin sản phẩm vào các TextBox
                tbPRid.Text = selectedRow.Cells["ProductID"].Value?.ToString();
                tbNamepr.Text = selectedRow.Cells["ProductName"].Value?.ToString();
                tbPricePr.Text = selectedRow.Cells["SellingPrice"].Value?.ToString();
                tbDesPr.Text = selectedRow.Cells["Descriptions"].Value?.ToString();

                // Lấy dữ liệu ảnh từ cột
                byte[] imageBytes = selectedRow.Cells["ImagesProduct"].Value as byte[];

                // Kiểm tra nếu ảnh tồn tại trong cơ sở dữ liệu
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        ptShowpr.Image = Image.FromStream(ms); // Hiển thị ảnh trong PictureBox
                    }
                }
                else
                {
                    ptShowpr.Image = null; // Nếu không có ảnh, xóa ảnh trong PictureBox
                }
            }
        }

        private void btBuypr_Click(object sender, EventArgs e)
        {
            string productId = tbPRid.Text;
            string ID = tbid.Text;
            string priceText = tbPricePr.Text;
            string quantityText = tbQuantity.Text;

            if (string.IsNullOrEmpty(priceText) || !decimal.TryParse(priceText, out decimal price) || price <= 0)
            {
                MessageBox.Show("Invalid price. Please select a product.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(quantityText) || !int.TryParse(quantityText, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please enter your ID.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkInventoryQuery = "SELECT InventoryQuantity FROM Products WHERE ProductID = @ProductID";
                    using (SqlCommand checkCmd = new SqlCommand(checkInventoryQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@ProductID", productId);

                        object result = checkCmd.ExecuteScalar();
                        if (result == null || !int.TryParse(result.ToString(), out int currentInventory))
                        {
                            MessageBox.Show("Product not found or inventory data is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (currentInventory < quantity)
                        {
                            MessageBox.Show("Not enough stock available. Please reduce the quantity.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string insertHistoryQuery = @"
                        INSERT INTO CustomerPurchaseHistory (ProductID, CustomerID, PurchaseDate, Quantity, TotalAmount) 
                        VALUES (@ProductID, @CustomerID, @PurchaseDate, @Quantity, @TotalAmount)";
                    using (SqlCommand insertCmd = new SqlCommand(insertHistoryQuery, connection))
                    {
                        decimal totalAmount = price * quantity;
                        insertCmd.Parameters.AddWithValue("@ProductID", productId);
                        insertCmd.Parameters.AddWithValue("@CustomerID", ID);
                        insertCmd.Parameters.AddWithValue("@PurchaseDate", DateTime.Now);
                        insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                        insertCmd.Parameters.AddWithValue("@TotalAmount", totalAmount);

                        int insertResult = insertCmd.ExecuteNonQuery();
                        if (insertResult > 0)
                        {
                            string updateInventoryQuery = @"
                        UPDATE Products 
                        SET InventoryQuantity = InventoryQuantity - @Quantity 
                        WHERE ProductID = @ProductID";
                            using (SqlCommand updateCmd = new SqlCommand(updateInventoryQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@Quantity", quantity);
                                updateCmd.Parameters.AddWithValue("@ProductID", productId);

                                int updateResult = updateCmd.ExecuteNonQuery();
                                if (updateResult > 0)
                                {
                                    MessageBox.Show($"Purchase successful! Total: {totalAmount:C}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ClearInputFields();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update inventory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("Purchase failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database connection error. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("SQL Error: " + ex.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("General Error: " + ex.ToString());
                }
            }
        }





        // Hàm ClearInputFields để xóa các ô TextBox và PictureBox
        private void ClearInputFields()
        {
            tbPRid.Clear();
            tbNamepr.Clear();
            tbPricePr.Clear();
            tbDesPr.Clear();
            tbQuantity.Clear();
            
            tbid.Clear();
            ptShowpr.Image = null; // Xóa ảnh trong PictureBox
        }

        private void btReseach_Click(object sender, EventArgs e)
        {
            string searchKeyword = tbprsearch.Text.Trim(); // Lấy từ khóa tìm kiếm từ TextBox

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
                ProductID,
                ProductCode, 
                ProductName, 
                SellingPrice, 
                InventoryQuantity, 
                Descriptions,
                ImagesProduct 
                FROM 
                Products";


                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Keyword", "%" + searchKeyword + "%");

                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);

                // Hiển thị kết quả tìm kiếm trong DataGridView
                datagridviewshowpr.DataSource = dt;

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

        // Hàm bôi xanh các hàng chứa kết quả tìm kiếm
        private void HighlightSearchResults(string searchKeyword)
        {
            foreach (DataGridViewRow row in datagridviewshowpr.Rows)
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

        
    }
}
