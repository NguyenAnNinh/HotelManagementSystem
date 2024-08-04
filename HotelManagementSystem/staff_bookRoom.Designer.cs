namespace HotelManagementSystem
{
    partial class staff_bookRoom
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel5 = new Panel();
            panel7 = new Panel();
            bookroom_imageview = new PictureBox();
            panel4 = new Panel();
            bookroom_regprice = new Label();
            label3 = new Label();
            bookroom_bookBtn = new Button();
            bookroom_clearBtn = new Button();
            bookroom_scheduleBtn = new Button();
            bookroom_total = new Label();
            label15 = new Label();
            bookroom_to = new DateTimePicker();
            bookroom_from = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            bookroom_roomtype = new Label();
            label11 = new Label();
            bookroom_roomname = new Label();
            label9 = new Label();
            bookroom_status = new Label();
            label7 = new Label();
            bookroom_roomid = new Label();
            label1 = new Label();
            panel6 = new Panel();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookroom_imageview).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(6, 352);
            panel5.Name = "panel5";
            panel5.Size = new Size(386, 245);
            panel5.TabIndex = 13;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonFace;
            panel7.Controls.Add(bookroom_imageview);
            panel7.Location = new Point(13, 14);
            panel7.Name = "panel7";
            panel7.Size = new Size(359, 218);
            panel7.TabIndex = 0;
            // 
            // bookroom_imageview
            // 
            bookroom_imageview.Location = new Point(0, 0);
            bookroom_imageview.Name = "bookroom_imageview";
            bookroom_imageview.Size = new Size(359, 218);
            bookroom_imageview.SizeMode = PictureBoxSizeMode.StretchImage;
            bookroom_imageview.TabIndex = 0;
            bookroom_imageview.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(bookroom_regprice);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(bookroom_bookBtn);
            panel4.Controls.Add(bookroom_clearBtn);
            panel4.Controls.Add(bookroom_scheduleBtn);
            panel4.Controls.Add(bookroom_total);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(bookroom_to);
            panel4.Controls.Add(bookroom_from);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(bookroom_roomtype);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(bookroom_roomname);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(bookroom_status);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(bookroom_roomid);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(398, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(284, 588);
            panel4.TabIndex = 12;
            // 
            // bookroom_regprice
            // 
            bookroom_regprice.AutoSize = true;
            bookroom_regprice.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookroom_regprice.Location = new Point(100, 145);
            bookroom_regprice.Name = "bookroom_regprice";
            bookroom_regprice.Size = new Size(28, 14);
            bookroom_regprice.TabIndex = 23;
            bookroom_regprice.Text = "0.00";
            bookroom_regprice.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 145);
            label3.Name = "label3";
            label3.Size = new Size(88, 14);
            label3.TabIndex = 22;
            label3.Text = "Regular Price ($):";
            // 
            // bookroom_bookBtn
            // 
            bookroom_bookBtn.BackColor = Color.FromArgb(3, 14, 28);
            bookroom_bookBtn.FlatAppearance.BorderSize = 0;
            bookroom_bookBtn.FlatStyle = FlatStyle.Flat;
            bookroom_bookBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookroom_bookBtn.ForeColor = Color.White;
            bookroom_bookBtn.Location = new Point(15, 451);
            bookroom_bookBtn.Name = "bookroom_bookBtn";
            bookroom_bookBtn.Size = new Size(260, 31);
            bookroom_bookBtn.TabIndex = 21;
            bookroom_bookBtn.Text = "Book";
            bookroom_bookBtn.UseVisualStyleBackColor = false;
            bookroom_bookBtn.Click += bookroom_bookBtn_Click;
            // 
            // bookroom_clearBtn
            // 
            bookroom_clearBtn.BackColor = Color.FromArgb(3, 14, 28);
            bookroom_clearBtn.FlatAppearance.BorderSize = 0;
            bookroom_clearBtn.FlatStyle = FlatStyle.Flat;
            bookroom_clearBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookroom_clearBtn.ForeColor = Color.White;
            bookroom_clearBtn.Location = new Point(15, 530);
            bookroom_clearBtn.Name = "bookroom_clearBtn";
            bookroom_clearBtn.Size = new Size(260, 31);
            bookroom_clearBtn.TabIndex = 19;
            bookroom_clearBtn.Text = "Clear";
            bookroom_clearBtn.UseVisualStyleBackColor = false;
            bookroom_clearBtn.Click += bookroom_clearBtn_Click;
            // 
            // bookroom_scheduleBtn
            // 
            bookroom_scheduleBtn.BackColor = Color.FromArgb(3, 14, 28);
            bookroom_scheduleBtn.FlatAppearance.BorderSize = 0;
            bookroom_scheduleBtn.FlatStyle = FlatStyle.Flat;
            bookroom_scheduleBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookroom_scheduleBtn.ForeColor = Color.White;
            bookroom_scheduleBtn.Location = new Point(15, 273);
            bookroom_scheduleBtn.Name = "bookroom_scheduleBtn";
            bookroom_scheduleBtn.Size = new Size(260, 31);
            bookroom_scheduleBtn.TabIndex = 18;
            bookroom_scheduleBtn.Text = "Schedule Now";
            bookroom_scheduleBtn.UseVisualStyleBackColor = false;
            bookroom_scheduleBtn.Click += bookroom_scheduleBtn_Click;
            // 
            // bookroom_total
            // 
            bookroom_total.AutoSize = true;
            bookroom_total.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookroom_total.Location = new Point(149, 343);
            bookroom_total.Name = "bookroom_total";
            bookroom_total.Size = new Size(36, 17);
            bookroom_total.TabIndex = 13;
            bookroom_total.Text = "0.00";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(41, 343);
            label15.Name = "label15";
            label15.Size = new Size(102, 17);
            label15.TabIndex = 12;
            label15.Text = "Total Price($):";
            // 
            // bookroom_to
            // 
            bookroom_to.Font = new Font("Times New Roman", 8.25F);
            bookroom_to.Location = new Point(81, 224);
            bookroom_to.Name = "bookroom_to";
            bookroom_to.Size = new Size(200, 20);
            bookroom_to.TabIndex = 11;
            // 
            // bookroom_from
            // 
            bookroom_from.Font = new Font("Times New Roman", 8.25F);
            bookroom_from.Location = new Point(81, 193);
            bookroom_from.Name = "bookroom_from";
            bookroom_from.Size = new Size(200, 20);
            bookroom_from.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(3, 199);
            label13.Name = "label13";
            label13.Size = new Size(74, 14);
            label13.TabIndex = 9;
            label13.Text = "From Schedule";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(15, 230);
            label12.Name = "label12";
            label12.Size = new Size(62, 14);
            label12.TabIndex = 8;
            label12.Text = "To Schedule";
            // 
            // bookroom_roomtype
            // 
            bookroom_roomtype.AutoSize = true;
            bookroom_roomtype.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookroom_roomtype.Location = new Point(100, 55);
            bookroom_roomtype.Name = "bookroom_roomtype";
            bookroom_roomtype.Size = new Size(47, 14);
            bookroom_roomtype.TabIndex = 7;
            bookroom_roomtype.Text = "----------";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(29, 55);
            label11.Name = "label11";
            label11.Size = new Size(65, 14);
            label11.TabIndex = 6;
            label11.Text = "Room Type:";
            // 
            // bookroom_roomname
            // 
            bookroom_roomname.AutoSize = true;
            bookroom_roomname.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookroom_roomname.Location = new Point(100, 82);
            bookroom_roomname.Name = "bookroom_roomname";
            bookroom_roomname.Size = new Size(47, 14);
            bookroom_roomname.TabIndex = 5;
            bookroom_roomname.Text = "----------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(26, 82);
            label9.Name = "label9";
            label9.Size = new Size(68, 14);
            label9.TabIndex = 4;
            label9.Text = "Room Name:";
            // 
            // bookroom_status
            // 
            bookroom_status.AutoSize = true;
            bookroom_status.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookroom_status.Location = new Point(100, 114);
            bookroom_status.Name = "bookroom_status";
            bookroom_status.Size = new Size(47, 14);
            bookroom_status.TabIndex = 3;
            bookroom_status.Text = "----------";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(57, 114);
            label7.Name = "label7";
            label7.Size = new Size(37, 14);
            label7.TabIndex = 2;
            label7.Text = "Status:";
            // 
            // bookroom_roomid
            // 
            bookroom_roomid.AutoSize = true;
            bookroom_roomid.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookroom_roomid.Location = new Point(100, 25);
            bookroom_roomid.Name = "bookroom_roomid";
            bookroom_roomid.Size = new Size(47, 14);
            bookroom_roomid.TabIndex = 1;
            bookroom_roomid.Text = "----------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 25);
            label1.Name = "label1";
            label1.Size = new Size(53, 14);
            label1.TabIndex = 0;
            label1.Text = "Room ID:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dataGridView1);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(6, 9);
            panel6.Name = "panel6";
            panel6.Size = new Size(386, 337);
            panel6.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(3, 14, 28);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(13, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(359, 291);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label5.Location = new Point(13, 11);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 15;
            label5.Text = "Available Rooms";
            // 
            // staff_bookRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Name = "staff_bookRoom";
            Size = new Size(688, 606);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bookroom_imageview).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Panel panel7;
        private PictureBox bookroom_imageview;
        private Panel panel4;
        private Button bookroom_bookBtn;
        private Button bookroom_clearBtn;
        private Button bookroom_scheduleBtn;
        private Label bookroom_total;
        private Label label15;
        private DateTimePicker bookroom_to;
        private DateTimePicker bookroom_from;
        private Label label13;
        private Label label12;
        private Label bookroom_roomtype;
        private Label label11;
        private Label bookroom_roomname;
        private Label label9;
        private Label bookroom_status;
        private Label label7;
        private Label bookroom_roomid;
        private Label label1;
        private Panel panel6;
        private DataGridView dataGridView1;
        private Label label5;
        private Label bookroom_regprice;
        private Label label3;
    }
}
