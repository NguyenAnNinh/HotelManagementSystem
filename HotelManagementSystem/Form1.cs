using System.Data;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public partial class Form1 : Form
    {
        private string conect = @"Data Source=BOSSLOVE\MSSQLSERVER1;Initial Catalog=hotel;Integrated Security=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_registerbtn_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();

            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conect))
                {
                    connect.Open();

                    string selectData = "SELECT * FROM users WHERE (username = @usern AND password = @pass) AND status = 'Active'";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            MessageBox.Show("Đăng nhập thành công", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            string selectRole = "SELECT role FROM users WHERE username = @usern AND password = @pass";

                            using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                getRole.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                                getRole.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                                string userRole = getRole.ExecuteScalar() as string;

                                if (userRole == "Admin")
                                {
                                    AdminMainForm Formadmin = new AdminMainForm();
                                    Formadmin.Show();

                                    this.Hide();
                                }
                                else if (userRole == "Staff")
                                {
                                    staffMainForm staffForm = new staffMainForm();
                                    staffForm.Show();

                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Vai trò không hợp lệ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }
    }
}
