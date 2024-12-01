using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ASM1_Database
{
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        // Chuỗi kết nối đến SQL Server
        string connectionString = @"Data Source=TUANANH;Initial Catalog=DatabaseASM1;Integrated Security=True";

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
        }

        private void btuploadpr_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Câu truy vấn chỉ lấy dữ liệu từ bảng Products
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

                // Gán dữ liệu cho DataGridView
                datagridviewpr.DataSource = dt;
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


        private void datagridviewpr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = datagridviewpr.Rows[e.RowIndex];

                tbprID.Text = selectedRow.Cells["ProductID"].Value?.ToString();
                tbprcode.Text = selectedRow.Cells["ProductCode"].Value?.ToString();
                tbprname.Text = selectedRow.Cells["ProductName"].Value?.ToString();
                tbprprice.Text = selectedRow.Cells["SellingPrice"].Value?.ToString();
                tbprquantity.Text = selectedRow.Cells["InventoryQuantity"].Value?.ToString();
                tbdescriptions.Text = selectedRow.Cells["Descriptions"].Value?.ToString();

                // Lấy dữ liệu ảnh từ cột
                byte[] imageBytes = selectedRow.Cells["ImagesProduct"].Value as byte[];

                // Kiểm tra nếu ảnh tồn tại trong cơ sở dữ liệu
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        ptimage.Image = Image.FromStream(ms); // Hiển thị ảnh trong PictureBox
                    }
                }
                else
                {
                    ptimage.Image = null; // Nếu không có ảnh, xóa ảnh trong PictureBox
                }
            }
        }


        private void btpradd_Click(object sender, EventArgs e)
        {
            string productId = tbprID.Text;
            string productCode = tbprcode.Text;
            string productName = tbprname.Text;
            string price = tbprprice.Text;
            string prquantity = tbprquantity.Text;
            string prdescription = tbdescriptions.Text;

            byte[] imageBytes = ptimage.Tag as byte[];  // Kiểm tra ảnh từ Tag
            if (imageBytes == null && ptimage.Image != null)  // Nếu ảnh trong PictureBox, lưu dưới dạng byte[]
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    ptimage.Image.Save(ms, ImageFormat.Png);
                    imageBytes = ms.ToArray();
                }
            }

            string[] values = { productId, productCode, productName, price, prquantity, prdescription };
            string[] fieldNames = { "ProductId", "Product Code", "Product Name", "Price", "Quantity", "Description" };

            // Kiểm tra trường nhập liệu
            for (int i = 0; i < values.Length; i++)
            {
                if (string.IsNullOrEmpty(values[i]))
                {
                    MessageBox.Show($"{fieldNames[i]} is required.");
                    return;
                }
            }

            // Kiểm tra kiểu dữ liệu Price và Quantity
            decimal parsedPrice;
            int parsedQuantity;
            int parsedProductId;

            if (!decimal.TryParse(price, out parsedPrice))
            {
                MessageBox.Show("Price must be a valid decimal.");
                return;
            }

            if (!int.TryParse(prquantity, out parsedQuantity))
            {
                MessageBox.Show("Quantity must be a valid integer.");
                return;
            }

            if (!int.TryParse(productId, out parsedProductId))
            {
                MessageBox.Show("Please, ProductID is of int data type.");
                return;
            }

            // Kiểm tra trùng ProductCode trong DataGridView
            foreach (DataGridViewRow row in datagridviewpr.Rows)
            {
                if (row.Cells["ProductCode"].Value?.ToString() == productCode)
                {
                    MessageBox.Show("This ProductCode already exists in the table.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (row.Cells["ProductID"].Value?.ToString() == productId)
                {
                    MessageBox.Show("This ProductID already exists in the table.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            // Kiểm tra trùng ProductCode trong cơ sở dữ liệu
            if (IsProductCodeExists(productCode))
            {
                MessageBox.Show("ProductCode already exists in the database. Please use a different ProductCode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsProductCodeExists(productId))
            {
                MessageBox.Show("ProductId already exists in the database. Please use a different ProductCode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm sản phẩm vào cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string query = @"
                    INSERT INTO Products 
                    (ProductID, ProductCode, ProductName, SellingPrice, InventoryQuantity, Descriptions, ImagesProduct) 
                    VALUES 
                    (@ProductId, @ProductCode, @ProductName, @SellingPrice, @InventoryQuantity, @Descriptions, @ImagesProduct)";

                    using (SqlCommand command = new SqlCommand(query, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@ProductId", productId);
                        command.Parameters.AddWithValue("@ProductCode", productCode);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@SellingPrice", parsedPrice);  // Đảm bảo giá trị đúng kiểu
                        command.Parameters.AddWithValue("@InventoryQuantity", parsedQuantity);  // Đảm bảo kiểu int
                        command.Parameters.AddWithValue("@Descriptions", prdescription);
                        command.Parameters.AddWithValue("@ImagesProduct", imageBytes);

                        int result = command.ExecuteNonQuery();
                        if (result <= 0)
                        {
                            throw new Exception("Failed to insert into the Products table.");
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Product added successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh DataGridView
                    btuploadpr_Click(sender, e);

                    // Clear input fields
                    ClearInputFields(tbprID, tbprcode, tbprname, tbprprice, tbprquantity, tbdescriptions);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// kiểm tra xem đã có ProductCode và ProductID trong dữ liệu tránh trùng
        private bool IsProductCodeExists(string productcode)
        {
            string query = "SELECT COUNT(*) FROM Products WHERE ProductCode = @ProductCode";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductCode", productcode);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        private bool IsProductIDExists(string productId)
        {
            string query = "SELECT COUNT(*) FROM Products WHERE ProductCode = @ProductCode";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductCode", productId);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }


        private void btpredit_Click(object sender, EventArgs e)
        {
            if (datagridviewpr.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string productId = tbprID.Text;
            string productCode = tbprcode.Text;
            string productName = tbprname.Text;
            string price = tbprprice.Text;
            string prquantity = tbprquantity.Text;
            string prdescription = tbdescriptions.Text;

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(productId) || string.IsNullOrEmpty(productCode) || string.IsNullOrEmpty(productName) ||
                string.IsNullOrEmpty(price) || string.IsNullOrEmpty(prquantity))
            {
                MessageBox.Show("All fields except image are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giá trị số
            decimal parsedPrice;
            if (!decimal.TryParse(price, out parsedPrice))
            {
                MessageBox.Show("Price must be a valid decimal number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int parsedQuantity;
            if (!int.TryParse(prquantity, out parsedQuantity))
            {
                MessageBox.Show("Quantity must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu ảnh từ PictureBox
            byte[] productImage = null;
            if (ptimage.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    ptimage.Image.Save(ms, ptimage.Image.RawFormat);
                    productImage = ms.ToArray();
                }
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                    UPDATE Products 
                    SET 
                        ProductID = @ProductId,
                        ProductName = @ProductName,
                        SellingPrice = @SellingPrice,
                        InventoryQuantity = @InventoryQuantity,
                        Descriptions = @Descriptions,
                        ImagesProduct = @ImagesProduct
                    WHERE ProductCode = @ProductCode";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ProductId", productId);
                        command.Parameters.AddWithValue("@ProductCode", productCode);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@SellingPrice", parsedPrice);
                        command.Parameters.AddWithValue("@InventoryQuantity", parsedQuantity);
                        command.Parameters.AddWithValue("@Descriptions", prdescription);
                        command.Parameters.AddWithValue("@ImagesProduct", (object)productImage ?? DBNull.Value); // Nếu không có ảnh, lưu NULL

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btuploadpr_Click(sender, e); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                ClearInputFields(tbprID, tbprcode, tbprname, tbprprice, tbprquantity, tbdescriptions);
                ptimage.Image = null; // Clear image
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btprdelete_Click(object sender, EventArgs e)
        {
            if (datagridviewpr.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productCode = tbprcode.Text;

            // Xác nhận xóa
            var confirmation = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Products WHERE ProductCode = @ProductCode";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductCode", productCode);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btuploadpr_Click(sender, e); // Refresh DataGridView
                            ClearInputFields(tbprcode, tbprname, tbprprice, tbprquantity, tbdescriptions); // Clear input fields
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the product. Please check if the product exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        

        private void btimage_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại chọn ảnh
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Chỉ hiển thị file ảnh
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select a Product Image";

                // Mở hộp thoại
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn file ảnh được chọn
                    string selectedFilePath = openFileDialog.FileName;

                    try
                    {
                        // Hiển thị ảnh trong PictureBox
                        ptimage.Image = Image.FromFile(selectedFilePath);

                        // Lưu đường dẫn vào PictureBox.Tag để tái sử dụng nếu cần
                        ptimage.Tag = selectedFilePath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void ClearInputFields(params TextBox[] textBoxes)
        {
            foreach (var tb in textBoxes)
            {
                tb.Clear();
            }
            ptimage.Image = null;
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = tbsearch.Text.Trim(); // Lấy từ khóa tìm kiếm từ TextBox

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
                Products
                WHERE
                    ProductID LIKE @Keyword OR
                    ProductCode LIKE @Keyword OR
                    ProductName LIKE @Keyword OR
                    SellingPrice LIKE @Keyword OR
                    Descriptions LIKE @Keyword";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Keyword", "%" + searchKeyword + "%");

                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);

                // Hiển thị kết quả tìm kiếm trong DataGridView
                datagridviewpr.DataSource = dt;

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
            foreach (DataGridViewRow row in datagridviewpr.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White; // Reset màu mặc định

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchKeyword.ToLower()))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen; // Bôi xanh hàng chứa kết quả
                        break; // Nếu tìm thấy từ khóa trong hàng, ngừng kiểm tra các ô còn lại
                    }
                }
            }
        }
    }
}
