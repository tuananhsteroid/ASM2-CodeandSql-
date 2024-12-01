using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ASM1_Database
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult check_Exit = MessageBox.Show("Do you want to exit?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check_Exit == DialogResult.Yes)
            {
                this.Close();
            }
        }



        // ...

        private void btRegister_Click(object sender, EventArgs e)
        {
            string Username = tbUsename.Text;
            string Passwords = tbPassword.Text;

            // Kiểm tra xem tên đăng nhập có trống không
            if (string.IsNullOrEmpty(Username))
            {
                MessageBox.Show("Please enter your Username", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem mật khẩu có trống không
            else if (string.IsNullOrEmpty(Passwords))
            {
                MessageBox.Show("Please enter your Password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra độ dài mật khẩu và yêu cầu có ít nhất một chữ cái và một số
            if (Passwords.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var passwordPattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$";
            if (!Regex.IsMatch(Passwords, passwordPattern))
            {
                MessageBox.Show("Password must contain at least one letter and one number.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=TUANANH;Initial Catalog=DatabaseASM1;Integrated Security=True";

            // Câu truy vấn SQL để chèn dữ liệu vào bảng CustomersAccounts
            string queryInsertCustomerAccount = "INSERT INTO CustomersAccounts (UseName, Passwords) VALUES (@UseName, @Passwords)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Bắt đầu một giao dịch để đảm bảo tính toàn vẹn dữ liệu
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Chèn dữ liệu vào bảng CustomersAccounts
                            using (SqlCommand cmd = new SqlCommand(queryInsertCustomerAccount, connection, transaction))
                            {
                                cmd.Parameters.Add("@UseName", SqlDbType.NVarChar).Value = Username;
                                cmd.Parameters.Add("@Passwords", SqlDbType.NVarChar).Value = Passwords;

                                cmd.ExecuteNonQuery();
                            }

                            // Cam kết giao dịch nếu mọi thứ thành công
                            transaction.Commit();
                            MessageBox.Show("Register successful!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Điều hướng đến form đăng nhập
                            FormLogin formLogin = new FormLogin();
                            this.Hide();
                            formLogin.ShowDialog();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            // Rollback giao dịch nếu có lỗi xảy ra
                            transaction.Rollback();
                            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }







        private void FormRegister_Load(object sender, EventArgs e)
        {
            // Code xử lý khi form load (nếu cần)
        }
    }
}
