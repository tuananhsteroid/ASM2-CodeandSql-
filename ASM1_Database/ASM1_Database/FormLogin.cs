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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ASM1_Database
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            CbMenuRole.SelectedIndexChanged += new EventHandler(CbMenuRole_SelectedIndexChanged);
        }
        private void CbMenuRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbMenuRole.SelectedItem.ToString() == "Employee" || CbMenuRole.SelectedItem.ToString() == "Manager")
            {
                btRegister.Enabled = false; // Vô hiệu hóa nút Register
            }
            else
            {
                btRegister.Enabled = true; // Kích hoạt lại nút Register
            }

            if (CbMenuRole.SelectedItem.ToString() == "Manager" || CbMenuRole.SelectedItem.ToString() == "Customer")
            {
                cbemp.Enabled = false;
            }
            else
            {
                cbemp.Enabled = true;
            }
        }


        private void btLogin_Click(object sender, EventArgs e)
        {
            string Username = tbUsename.Text.Trim();
            string Password = tbPassword.Text.Trim();
            string Role = CbMenuRole.SelectedItem?.ToString().Trim();
            string Position = cbemp.SelectedItem?.ToString().Trim();

            string connectionString = @"Data Source=TUANANH;Initial Catalog=DatabaseASM1;Integrated Security=True";

            if (String.IsNullOrEmpty(Username))
            {
                MessageBox.Show("Please enter Username", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter Password", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Role == null)
            {
                MessageBox.Show("Please select Role", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Role == "Employee" && Position == null)
            {
                MessageBox.Show("Please select Position", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query;
            if (Role == "Manager")
            {
                query = "SELECT * FROM ManagerView WHERE UseName = @Username AND Passwords = @Password";
            }
            else if (Role == "Customer")
            {
                query = "SELECT * FROM CustomersAccounts WHERE UseName = @Username AND Passwords = @Password";
            }
            else if (Role == "Employee")
            {
                query = @"
                SELECT e.EmployeeID, e.EmployeeCode, e.EmployeeName, e.Position, 
                       ea.AccountID, ea.UserName, ea.Password
                FROM Employees e
                INNER JOIN EmployeeAccounts ea ON e.EmployeeID = ea.AccountID
                WHERE ea.UserName = @Username AND ea.Password = @Password AND e.Position = @Position";
            }
            else
            {
                MessageBox.Show("Invalid Role", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        if (Role == "Employee")
                        {
                            command.Parameters.AddWithValue("@Position", Position);
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Login successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (Role == "Manager")
                                {
                                    this.Hide();
                                    new Manage_Table().ShowDialog();
                                }
                                else if (Role == "Employee" && (Position == "Sales staff" || Position == "Warehouse staff"))
                                {
                                    if (cbemp.SelectedItem.ToString() == "Sales staff")
                                    {
                                        FormSaleStaff formSaleStaff = new FormSaleStaff();
                                        this.Hide();
                                        formSaleStaff.ShowDialog();
                                        this.Close();
                                    }
                                    else
                                    {
                                        ProductManagement productManagement = new ProductManagement();
                                        this.Hide(); productManagement.ShowDialog(); this.Close();
                                    }
                                }
                                else if (Role == "Customer")
                                {
                                    this.Hide();
                                    new ConfirmAccount().ShowDialog();
                                }
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Username, Password, or Role is invalid", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void btRegister_Click(object sender, EventArgs e)
        {

            FormRegister FormRegister = new FormRegister();

            this.Hide();
            FormRegister.ShowDialog();
            this.Close();
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


    }
}