using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public partial class admin_adduser : UserControl
    {
        private String conect = @"Data Source=BOSSLOVE\MSSQLSERVER1;Initial Catalog=hotel;Integrated Security=True;TrustServerCertificate=True";
        public admin_adduser()
        {
            InitializeComponent();

            displayData();
        }

        public void refreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayData();
        }

        public void displayData()
        {
            usersData uData = new usersData();
            dataGridView1.DataSource = uData.listUsersData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adduser_addBtn_Click(object sender, EventArgs e)
        {
            if (adduser_username.Text == "" || adduser_password.Text == "" || adduser_role.SelectedIndex == -1 || adduser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conect))
                {
                    connect.Open();

                    string checkUsern = "SELECT username FROM users WHERE username = @usern";

                    using (SqlCommand checkU = new SqlCommand(checkUsern, connect))
                    {
                        checkU.Parameters.AddWithValue("@usern", adduser_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkU);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            string tempUsern = adduser_username.Text.Substring(0, 1).ToUpper() + adduser_username.Text.Substring(1);

                            MessageBox.Show($"{tempUsern} đã tồn tại", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (adduser_password.Text.Length < 8)
                        {
                            MessageBox.Show("Vui lòng nhập đủ các kí tự", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (username, password, role, status, date_register)" + "VALUES(@usern, @pass, @role, @status, @date)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", adduser_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", adduser_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", adduser_role.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@status", adduser_status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;

                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Thêm thành công", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }


        public void clearFields()
        {
            adduser_username.Text = "";
            adduser_password.Text = "";
            adduser_role.SelectedIndex = -1;
            adduser_status.SelectedIndex = -1;
        }

        private void adduser_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void adduser_updateBtn_Click(object sender, EventArgs e)
        {
            if (adduser_username.Text == "" || adduser_password.Text == "" || adduser_role.SelectedIndex == -1 || adduser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn cập nhật theo ID" + getID + "không?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conect))
                    {
                        connect.Open();

                        string updateData = "UPDATE users SET password = @pass, role = @role, status = @status WHERE username = @usern";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@pass", adduser_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", adduser_role.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@status", adduser_status.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@usern", adduser_username.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayData();

                            MessageBox.Show("Cập nhật thành công", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
        }

        private int getID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                adduser_username.Text = row.Cells[1].Value.ToString();
                adduser_password.Text = row.Cells[2].Value.ToString();
                adduser_role.Text = row.Cells[3].Value.ToString();
                adduser_status.Text = row.Cells[4].Value.ToString();
            }
        }

        private void adduser_deleteBtn_Click(object sender, EventArgs e)
        {
            if (adduser_username.Text == "" || adduser_password.Text == "" || adduser_role.SelectedIndex == -1 || adduser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa theo ID" + getID + "không?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conect))
                    {
                        connect.Open();

                        string updateData = "DELETE FROM users WHERE username = @usern";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", adduser_username.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayData();

                            MessageBox.Show("Xóa thành công", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
        }
    }
}
