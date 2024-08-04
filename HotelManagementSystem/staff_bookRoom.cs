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

namespace HotelManagementSystem
{
    public partial class staff_bookRoom : UserControl
    {
        public staff_bookRoom()
        {
            InitializeComponent();


            displayRooms();
        }

        public void refreshData()
        {
            if(InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }
            displayRooms();
        }

        public void displayRooms()
        {
            roomsData rData = new roomsData();

            List<roomsData> listData = rData.roomsDataList();

            dataGridView1.DataSource = listData;
        }

        private int getID = 0;

        private decimal regprice = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                bookroom_roomid.Text = row.Cells[1].Value.ToString();
                bookroom_roomtype.Text = row.Cells[2].Value.ToString();
                bookroom_roomname.Text = row.Cells[3].Value.ToString();
                bookroom_regprice.Text = (Convert.ToInt32(row.Cells[4].Value)).ToString("0.00");

                regprice = Convert.ToDecimal(row.Cells[4].Value);

                bookroom_imageview.ImageLocation = row.Cells[5].Value.ToString();

                bookroom_status.Text = row.Cells[6].Value.ToString();
            }
        }

        private void bookroom_scheduleBtn_Click(object sender, EventArgs e)
        {
            DateTime fromDate = bookroom_from.Value;
            DateTime toDate = bookroom_to.Value;

            TimeSpan countDays = toDate - fromDate;

            int days = countDays.Days;

            decimal totalPrice = (days * regprice);

            if (totalPrice < 0)
            {
                MessageBox.Show("Something went wrong :3", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                bookroom_total.Text = "0.00";
            }
            else
            {
                bookroom_total.Text = (days * regprice).ToString("0.00");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bookroom_bookBtn_Click(object sender, EventArgs e)
        {
            if (regprice == 0 || bookroom_total.Text == "0.00")
            {
                MessageBox.Show("Vui lòng điền thông tin chính xác", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bookroom_status.Text != "Active")
            {
                MessageBox.Show("Phòng không có sẵn", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                hotelData.roomID = bookroom_roomid.Text;
                hotelData.fromDate = bookroom_from.Value;
                hotelData.toDate = bookroom_to.Value;
                hotelData.price = bookroom_total.Text;

                Form formbg = new Form();

                try
                {
                    using (clientInfo ciForm = new clientInfo())
                    {
                        ciForm.Owner = formbg;
                        ciForm.ShowDialog();

                        formbg.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    formbg.Dispose();
                }
            }
        }

        public void clearFields()
        {
            bookroom_roomid.Text = "----------";
            bookroom_roomtype.Text = "----------";
            bookroom_roomname.Text = "----------";
            bookroom_status.Text = "----------";
            bookroom_total.Text = "0.00";
            bookroom_regprice.Text = "0.00";

            bookroom_imageview.Image = null;
        }

        private void bookroom_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
