using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ASM1_Database
{
    public partial class Employeemanagement : Form
    {
        // Chuỗi kết nối đến SQL Server
        string connectionString = @"Data Source=TUANANH;Initial Catalog=DatabaseASM1;Integrated Security=True";

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;

        public Employeemanagement()
        {
            InitializeComponent();
        }

        private void Employeemanagement_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
        }



        private void btUpload_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Tạo câu lệnh SQL kết hợp giữa bảng EmployeeAccounts và Employees
                string query = @"
            SELECT 
                e.EmployeeID, 
                e.EmployeeCode, 
                e.EmployeeName, 
                e.Position, 
                ea.AccountID, 
                ea.UserName, 
                ea.Password
            FROM 
                Employees e
            INNER JOIN 
                EmployeeAccounts ea ON e.EmployeeID = ea.AccountID";

                
                cmd = new SqlCommand(query, con);

                
                adt = new SqlDataAdapter(cmd);

                
                dt = new DataTable();
                adt.Fill(dt);

               
                dataGridViewEmp.DataSource = dt;
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



        private void btReturn_Click(object sender, EventArgs e)
        {
            Manage_Table manageTable = new Manage_Table();
            this.Hide();
            manageTable.ShowDialog();
            this.Close();
        }



        private void dataGridViewEmp_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấp vào một hàng hợp lệ
            if (e.RowIndex >= 0) // Đảm bảo rằng không nhấp vào tiêu đề
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridViewEmp.Rows[e.RowIndex];

                // Gán dữ liệu từ hàng được chọn vào các TextBox
                tbEmpID.Text = selectedRow.Cells["EmployeeID"].Value?.ToString();      // EmployeeID
                tbEmpCode.Text = selectedRow.Cells["EmployeeCode"].Value?.ToString(); // EmployeeCode
                tbEmpFN.Text = selectedRow.Cells["EmployeeName"].Value?.ToString();   // EmployeeName
                cbposition.Text = selectedRow.Cells["Position"].Value?.ToString(); // Position

                tbAccID.Text = selectedRow.Cells["AccountID"].Value?.ToString();      // AccountID
                tbUsenameEmp.Text = selectedRow.Cells["UserName"].Value?.ToString();  // UserName
                tbPassEmp.Text = selectedRow.Cells["Password"].Value?.ToString();     // Password
            }


        }




        private void btAdd_Click_1(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string employeeID = tbEmpID.Text;
            string employeeCode = tbEmpCode.Text;
            string employeeName = tbEmpFN.Text;
            string position = cbposition.Text;

            string accountID = tbAccID.Text;
            string username = tbUsenameEmp.Text;
            string password = tbPassEmp.Text;

            // Kiểm tra các trường nhập liệu
            string[] values = { employeeID, employeeCode, employeeName, position, accountID, username, password };
            string[] fieldNames = { "Employee ID", "Employee Code", "Full Name", "Position", "Account ID", "Username", "Password" };

            for (int i = 0; i < values.Length; i++)
            {
                if (string.IsNullOrEmpty(values[i]))
                {
                    MessageBox.Show(fieldNames[i] + " is required.");
                    return;
                }
            }

            // Kiểm tra xem thông tin có trùng khớp với hàng hiện tại trong DataGridView hay không
            foreach (DataGridViewRow row in dataGridViewEmp.Rows)
            {
                if (row.Cells["EmployeeID"].Value?.ToString() == employeeID &&
                    row.Cells["EmployeeCode"].Value?.ToString() == employeeCode &&
                    row.Cells["EmployeeName"].Value?.ToString() == employeeName &&
                    row.Cells["Position"].Value?.ToString() == position &&
                    row.Cells["AccountID"].Value?.ToString() == accountID &&
                    row.Cells["UserName"].Value?.ToString() == username &&
                    row.Cells["Password"].Value?.ToString() == password)
                {
                    MessageBox.Show("No changes detected. Please update the information before adding.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // Kiểm tra trùng lặp AccountID và EmployeeID
            if (IsAccountIDExists(accountID))
            {
                MessageBox.Show("AccountID already exists. Please use a different AccountID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsEmployeeIDExists(employeeID))
            {
                MessageBox.Show("EmployeeID already exists. Please use a different EmployeeID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra trùng lặp EmployeeCode
            if (IsEmployeeCodeExists(employeeCode))
            {
                MessageBox.Show("EmployeeCode already exists. Please use a different EmployeeCode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm mới vào cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    // Thêm vào bảng EmployeeAccounts
                    string query1 = "INSERT INTO EmployeeAccounts (AccountID, UserName, Password) " +
                        "VALUES (@AccountID, @Username, @Password)";
                    using (SqlCommand command = new SqlCommand(query1, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@AccountID", accountID);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int result1 = command.ExecuteNonQuery();
                        if (result1 <= 0)
                        {
                            throw new Exception("Failed to insert into EmployeeAccounts.");
                        }
                    }

                    // Thêm vào bảng Employees
                    string query2 = "INSERT INTO Employees (EmployeeID, EmployeeCode, EmployeeName, Position) " +
                        "VALUES (@EmployeeID, @EmployeeCode, @EmployeeName, @Position)";
                    using (SqlCommand command = new SqlCommand(query2, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);
                        command.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                        command.Parameters.AddWithValue("@EmployeeName", employeeName);
                        command.Parameters.AddWithValue("@Position", position);

                        int result2 = command.ExecuteNonQuery();
                        if (result2 <= 0)
                        {
                            throw new Exception("Failed to insert into Employees.");
                        }
                    }

                    // Commit giao dịch
                    transaction.Commit();
                    MessageBox.Show("Employee added successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại dữ liệu
                    btUpload_Click(sender, e);

                    // Xóa dữ liệu trong các TextBox
                    ClearInputFields(tbEmpID, tbEmpCode, tbEmpFN, cbposition,  tbAccID, tbUsenameEmp, tbPassEmp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Phương thức kiểm tra xem AccountID đã tồn tại trong cơ sở dữ liệu chưa
        private bool IsAccountIDExists(string accountID)
        {
            string query = "SELECT COUNT(*) FROM EmployeeAccounts WHERE AccountID = @AccountID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountID", accountID);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Phương thức kiểm tra xem EmployeeID đã tồn tại trong cơ sở dữ liệu chưa
        private bool IsEmployeeIDExists(string employeeID)
        {
            string query = "SELECT COUNT(*) FROM Employees WHERE EmployeeID = @EmployeeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Phương thức kiểm tra xem EmployeeCode đã tồn tại trong cơ sở dữ liệu chưa
        private bool IsEmployeeCodeExists(string employeeCode)
        {
            string query = "SELECT COUNT(*) FROM Employees WHERE EmployeeCode = @EmployeeCode";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }


        private void btEdit_Click(object sender, EventArgs e)
        {
                // Lấy thông tin từ các TextBox
                string employeeID = tbEmpID.Text;
                string employeeCode = tbEmpCode.Text;
                string employeeName = tbEmpFN.Text;
                string position = cbposition.Text;

                string accountID = tbAccID.Text;
                string username = tbUsenameEmp.Text;
                string password = tbPassEmp.Text;

            // Kiểm tra các trường nhập liệu
            if (string.IsNullOrEmpty(employeeID) || string.IsNullOrEmpty(employeeCode) || 
                string.IsNullOrEmpty(employeeName) || string.IsNullOrEmpty(position) ||
                string.IsNullOrEmpty(accountID) || string.IsNullOrEmpty(username) || 
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields before updating.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem EmployeeID và AccountID có tồn tại không trước khi cập nhật
            if (!IsEmployeeIDExists(employeeID))
            {
                MessageBox.Show("EmployeeID does not exist. Update operation cannot proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsAccountIDExists(accountID))
            {
                MessageBox.Show("AccountID does not exist. Update operation cannot proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thực hiện cập nhật dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    // Cập nhật bảng EmployeeAccounts
                    string updateAccountQuery = @"
                        UPDATE EmployeeAccounts 
                        SET UserName = @UserName, Password = @Password 
                        WHERE AccountID = @AccountID";
                    using (SqlCommand cmdAccount = new SqlCommand(updateAccountQuery, connection, transaction))
                    {
                        cmdAccount.Parameters.AddWithValue("@UserName", username);
                        cmdAccount.Parameters.AddWithValue("@Password", password);
                        cmdAccount.Parameters.AddWithValue("@AccountID", accountID);

                        int result1 = cmdAccount.ExecuteNonQuery();
                        if (result1 <= 0)
                        {
                            throw new Exception("Failed to update EmployeeAccounts.");
                        }
                    }

                    // Cập nhật bảng Employees
                    string updateEmployeeQuery = @"
                        UPDATE Employees 
                        SET EmployeeCode = @EmployeeCode, 
                            EmployeeName = @EmployeeName, 
                            Position = @Position 
                        WHERE EmployeeID = @EmployeeID";
                    using (SqlCommand cmdEmployee = new SqlCommand(updateEmployeeQuery, connection, transaction))
                    {
                        cmdEmployee.Parameters.AddWithValue("@EmployeeCode", employeeCode);
                        cmdEmployee.Parameters.AddWithValue("@EmployeeName", employeeName);
                        cmdEmployee.Parameters.AddWithValue("@Position", position);
                        cmdEmployee.Parameters.AddWithValue("@EmployeeID", employeeID);
                        
                        int result2 = cmdEmployee.ExecuteNonQuery();
                        if (result2 <= 0)
                        {
                            throw new Exception("Failed to update Employees.");
                        }
                    }

                    // Commit giao dịch nếu tất cả các câu lệnh đều thành công
                    transaction.Commit();
                    MessageBox.Show("Employee information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa dữ liệu trong các TextBox
                    ClearInputFields(tbEmpID, tbEmpCode, tbEmpFN, cbposition, tbAccID, tbUsenameEmp, tbPassEmp);


                    // Tải lại dữ liệu lên DataGridView
                    btUpload_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btDelete_Click(object sender, EventArgs e)
{
        // Lấy EmployeeID và AccountID từ TextBox
        if (!int.TryParse(tbEmpID.Text.Trim(), out int employeeID))
        {
            MessageBox.Show("Invalid Employee ID. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!int.TryParse(tbAccID.Text.Trim(), out int accountID))
        {
            MessageBox.Show("Invalid Account ID. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Hiển thị hộp thoại xác nhận
        DialogResult confirm = MessageBox.Show("Are you sure you want to delete this employee and their account?",
                                               "Confirmation",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
        if (confirm != DialogResult.Yes)
        {
            return; // Người dùng chọn "No"
        }

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
        try
        {
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();

            
            string deleteAccountQuery = "DELETE FROM EmployeeAccounts WHERE AccountID = @AccountID";
            using (SqlCommand cmdAccount = new SqlCommand(deleteAccountQuery, connection, transaction))
            {
                cmdAccount.Parameters.AddWithValue("@AccountID", accountID);
                cmdAccount.ExecuteNonQuery();
            }

            
            string deleteEmployeeQuery = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
            using (SqlCommand cmdEmployee = new SqlCommand(deleteEmployeeQuery, connection, transaction))
            {
                cmdEmployee.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmdEmployee.ExecuteNonQuery();
            }

            // Commit transaction
            transaction.Commit();
            MessageBox.Show("Employee and their account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields
            ClearInputFields(tbEmpID, tbEmpCode, tbEmpFN, cbposition, tbAccID, tbUsenameEmp, tbPassEmp);

            // Reload data
            btUpload_Click(sender, e);
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred while deleting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}



        // Hàm xóa dữ liệu trong các TextBox
        private void ClearInputFields(params Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();  // Xóa nội dung của TextBox
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;  // Đặt lại ComboBox
                }
            }
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
                    e.EmployeeID, 
                    e.EmployeeCode, 
                    e.EmployeeName, 
                    e.Position, 
                    ea.AccountID, 
                    ea.UserName, 
                    ea.Password
                FROM 
                    Employees e
                INNER JOIN 
                    EmployeeAccounts ea ON e.EmployeeID = ea.AccountID
                WHERE 
                    e.EmployeeCode LIKE @Keyword OR
                    e.EmployeeName LIKE @Keyword OR
                    e.Position LIKE @Keyword OR
                    ea.UserName LIKE @Keyword";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Keyword", "%" + searchKeyword + "%");

                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);

                // Hiển thị kết quả tìm kiếm trong DataGridView
                dataGridViewEmp.DataSource = dt;

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
            foreach (DataGridViewRow row in dataGridViewEmp.Rows)
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

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
