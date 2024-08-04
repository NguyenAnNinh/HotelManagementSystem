using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;

namespace HotelManagementSystem
{
    public partial class admin_rooms : UserControl
    {
        private String conect = @"Data Source=BOSSLOVE\MSSQLSERVER1;Initial Catalog=hotel;Integrated Security=True;TrustServerCertificate=True";

        public admin_rooms()
        {
            InitializeComponent();

            displayRoomData();
        }

        public void refreshData()
        {
            if(InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }
            displayRoomData();
        }

        public void displayRoomData()
        {
            roomsData rData = new roomsData();
            List<roomsData> listD = rData.roomsDataList(); // Gọi hàm roomsDataList để lấy dữ liệu

            dataGridView1.DataSource = listD; // Gán dữ liệu cho DataGridView
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public bool isEmpty()
        {
            if (string.IsNullOrEmpty(rooms_roomid.Text) || string.IsNullOrEmpty(rooms_roomname.Text) ||
                rooms_type.SelectedIndex == -1 || string.IsNullOrEmpty(rooms_price.Text) ||
                    rooms_status.SelectedIndex == -1 || rooms_picture.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void rooms_addBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(conect))
                    {
                        connect.Open();

                        string checkRoomID = "SELECT room_id FROM rooms WHERE room_id = @roomid";
                        using (SqlCommand CheckRID = new SqlCommand(checkRoomID, connect))
                        {
                            CheckRID.Parameters.AddWithValue("@roomid", rooms_roomid.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(CheckRID);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0) // Sửa lại điều kiện kiểm tra
                            {
                                MessageBox.Show(rooms_roomid.Text.Trim() + " đã tồn tại", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO rooms (room_id, type, room_name, price, image_path, status, date_register)" +
                                    "VALUES(@roomid, @type, @name, @price, @path, @status, @date_reg)";

                                string path = Path.Combine(@"C:\Users\Admin\source\repos\HotelManagementSystem\HotelManagementSystem\room_directory\" +
                                    rooms_roomid.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(rooms_picture.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@roomid", rooms_roomid.Text.Trim());
                                    cmd.Parameters.AddWithValue("@type", rooms_type.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@name", rooms_roomname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@price", rooms_price.Text.Trim());

                                    cmd.Parameters.AddWithValue("@path", path); // Sài dành cho ảnh

                                    cmd.Parameters.AddWithValue("@status", rooms_status.SelectedItem.ToString());

                                    DateTime today = DateTime.Today;
                                    cmd.Parameters.AddWithValue("@date_reg", today);

                                    cmd.ExecuteNonQuery(); // Thực thi lệnh SQL

                                    clearFields();
                                    displayRoomData();
                                }

                                MessageBox.Show("Thêm phòng thành công", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong :3", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rooms_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                string imagePath = "";

                file.Filter = "Image Files (*.jpg; *.png) | *.jpg; *.png";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    imagePath = file.FileName;
                    rooms_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rooms_updateBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Vui lòng chọn một item", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn cập nhật theo ID: " + id + " không ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(conect))
                        {
                            connect.Open();

                            string updateData = "UPDATE rooms SET room_id = @roomid, type = @type, room_name = @room_name, price = @price" +
                                ", status = @status , date_update = @date_update WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@roomid", rooms_roomid.Text.Trim());
                                cmd.Parameters.AddWithValue("@type", rooms_type.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@room_name", rooms_roomname.Text.Trim());
                                cmd.Parameters.AddWithValue("@price", rooms_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", rooms_status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date_update", today);
                                cmd.Parameters.AddWithValue("@id", id);


                                cmd.ExecuteNonQuery();

                                clearFields();
                                displayRoomData();

                                MessageBox.Show("Cập nhật thành công", "Infomation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong :3", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int id;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id = (int)row.Cells[0].Value;
                rooms_roomid.Text = row.Cells[1].Value.ToString();
                rooms_type.Text = row.Cells[2].Value.ToString();
                rooms_roomname.Text = row.Cells[3].Value.ToString();
                rooms_price.Text = row.Cells[4].Value.ToString();

                rooms_picture.ImageLocation = row.Cells[5].Value.ToString();

                rooms_status.Text = row.Cells[6].Value.ToString();

            }
        }

        public void clearFields()
        {
            rooms_roomid.Text = "";
            rooms_type.SelectedIndex = -1;
            rooms_roomname.Text = "";
            rooms_price.Text = "";
            rooms_picture.Image = null;
            rooms_status.SelectedIndex = -1;
        }
        private void rooms_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void rooms_deleteBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Vui lòng chọn một item", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa theo ID: " + id + " không ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(conect))
                        {
                            connect.Open();

                            string updateData = "UPDATE rooms SET date_delete = @delete WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@delete", today);
                                cmd.Parameters.AddWithValue("@id", id);


                                cmd.ExecuteNonQuery();

                                clearFields();
                                displayRoomData();

                                MessageBox.Show("Xóa thành công", "Infomation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong :3", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
