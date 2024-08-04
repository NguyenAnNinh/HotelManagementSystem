namespace HotelManagementSystem
{
    partial class admin_rooms
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
            panel1 = new Panel();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            rooms_clearBtn = new Button();
            rooms_deleteBtn = new Button();
            rooms_updateBtn = new Button();
            rooms_addBtn = new Button();
            rooms_importBtn = new Button();
            panel3 = new Panel();
            rooms_picture = new PictureBox();
            rooms_status = new ComboBox();
            label6 = new Label();
            rooms_roomname = new TextBox();
            label4 = new Label();
            rooms_price = new TextBox();
            label3 = new Label();
            rooms_type = new ComboBox();
            label2 = new Label();
            rooms_roomid = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rooms_picture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(19, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 273);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label5.Location = new Point(14, 10);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 14;
            label5.Text = "Room's Data";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dataGridView1.Location = new Point(14, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(622, 220);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(rooms_clearBtn);
            panel2.Controls.Add(rooms_deleteBtn);
            panel2.Controls.Add(rooms_updateBtn);
            panel2.Controls.Add(rooms_addBtn);
            panel2.Controls.Add(rooms_importBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(rooms_status);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(rooms_roomname);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(rooms_price);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(rooms_type);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(rooms_roomid);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(19, 309);
            panel2.Name = "panel2";
            panel2.Size = new Size(649, 283);
            panel2.TabIndex = 1;
            // 
            // rooms_clearBtn
            // 
            rooms_clearBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_clearBtn.FlatAppearance.BorderSize = 0;
            rooms_clearBtn.FlatStyle = FlatStyle.Flat;
            rooms_clearBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_clearBtn.ForeColor = Color.White;
            rooms_clearBtn.Location = new Point(397, 224);
            rooms_clearBtn.Name = "rooms_clearBtn";
            rooms_clearBtn.Size = new Size(117, 42);
            rooms_clearBtn.TabIndex = 16;
            rooms_clearBtn.Text = "Clear";
            rooms_clearBtn.UseVisualStyleBackColor = false;
            rooms_clearBtn.Click += rooms_clearBtn_Click;
            // 
            // rooms_deleteBtn
            // 
            rooms_deleteBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_deleteBtn.FlatAppearance.BorderSize = 0;
            rooms_deleteBtn.FlatStyle = FlatStyle.Flat;
            rooms_deleteBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_deleteBtn.ForeColor = Color.White;
            rooms_deleteBtn.Location = new Point(274, 224);
            rooms_deleteBtn.Name = "rooms_deleteBtn";
            rooms_deleteBtn.Size = new Size(117, 42);
            rooms_deleteBtn.TabIndex = 15;
            rooms_deleteBtn.Text = "Delete";
            rooms_deleteBtn.UseVisualStyleBackColor = false;
            rooms_deleteBtn.Click += rooms_deleteBtn_Click;
            // 
            // rooms_updateBtn
            // 
            rooms_updateBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_updateBtn.FlatAppearance.BorderSize = 0;
            rooms_updateBtn.FlatStyle = FlatStyle.Flat;
            rooms_updateBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_updateBtn.ForeColor = Color.White;
            rooms_updateBtn.Location = new Point(151, 224);
            rooms_updateBtn.Name = "rooms_updateBtn";
            rooms_updateBtn.Size = new Size(117, 42);
            rooms_updateBtn.TabIndex = 14;
            rooms_updateBtn.Text = "Update";
            rooms_updateBtn.UseVisualStyleBackColor = false;
            rooms_updateBtn.Click += rooms_updateBtn_Click;
            // 
            // rooms_addBtn
            // 
            rooms_addBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_addBtn.FlatAppearance.BorderSize = 0;
            rooms_addBtn.FlatStyle = FlatStyle.Flat;
            rooms_addBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_addBtn.ForeColor = Color.White;
            rooms_addBtn.Location = new Point(28, 224);
            rooms_addBtn.Name = "rooms_addBtn";
            rooms_addBtn.Size = new Size(117, 42);
            rooms_addBtn.TabIndex = 13;
            rooms_addBtn.Text = "Add";
            rooms_addBtn.UseVisualStyleBackColor = false;
            rooms_addBtn.Click += rooms_addBtn_Click;
            // 
            // rooms_importBtn
            // 
            rooms_importBtn.BackColor = Color.FromArgb(3, 14, 28);
            rooms_importBtn.FlatAppearance.BorderSize = 0;
            rooms_importBtn.FlatStyle = FlatStyle.Flat;
            rooms_importBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_importBtn.ForeColor = Color.White;
            rooms_importBtn.Location = new Point(551, 132);
            rooms_importBtn.Name = "rooms_importBtn";
            rooms_importBtn.Size = new Size(85, 29);
            rooms_importBtn.TabIndex = 12;
            rooms_importBtn.Text = "Import";
            rooms_importBtn.UseVisualStyleBackColor = false;
            rooms_importBtn.Click += rooms_importBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(rooms_picture);
            panel3.Location = new Point(551, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(85, 100);
            panel3.TabIndex = 11;
            // 
            // rooms_picture
            // 
            rooms_picture.Location = new Point(0, 0);
            rooms_picture.Name = "rooms_picture";
            rooms_picture.Size = new Size(85, 100);
            rooms_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            rooms_picture.TabIndex = 0;
            rooms_picture.TabStop = false;
            // 
            // rooms_status
            // 
            rooms_status.FormattingEnabled = true;
            rooms_status.Items.AddRange(new object[] { "Active", "Inactive", "Occupied" });
            rooms_status.Location = new Point(351, 66);
            rooms_status.Name = "rooms_status";
            rooms_status.Size = new Size(168, 23);
            rooms_status.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(298, 69);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 9;
            label6.Text = "Status";
            // 
            // rooms_roomname
            // 
            rooms_roomname.BorderStyle = BorderStyle.FixedSingle;
            rooms_roomname.Location = new Point(95, 107);
            rooms_roomname.Name = "rooms_roomname";
            rooms_roomname.Size = new Size(168, 23);
            rooms_roomname.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 109);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 7;
            label4.Text = "Room Name";
            // 
            // rooms_price
            // 
            rooms_price.BorderStyle = BorderStyle.FixedSingle;
            rooms_price.Location = new Point(351, 26);
            rooms_price.Name = "rooms_price";
            rooms_price.Size = new Size(141, 23);
            rooms_price.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(284, 29);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "Price ($)";
            // 
            // rooms_type
            // 
            rooms_type.FormattingEnabled = true;
            rooms_type.Items.AddRange(new object[] { "Single Room", "Double Room" });
            rooms_type.Location = new Point(95, 66);
            rooms_type.Name = "rooms_type";
            rooms_type.Size = new Size(168, 23);
            rooms_type.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 69);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "Type";
            label2.Click += label2_Click;
            // 
            // rooms_roomid
            // 
            rooms_roomid.BorderStyle = BorderStyle.FixedSingle;
            rooms_roomid.Location = new Point(95, 26);
            rooms_roomid.Name = "rooms_roomid";
            rooms_roomid.Size = new Size(147, 23);
            rooms_roomid.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 29);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Room ID";
            // 
            // admin_rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "admin_rooms";
            Size = new Size(688, 606);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rooms_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox rooms_roomid;
        private Label label1;
        private ComboBox rooms_type;
        private Label label2;
        private ComboBox rooms_status;
        private Label label6;
        private TextBox rooms_roomname;
        private Label label4;
        private TextBox rooms_price;
        private Label label3;
        private Button rooms_importBtn;
        private Panel panel3;
        private PictureBox rooms_picture;
        private Button rooms_clearBtn;
        private Button rooms_deleteBtn;
        private Button rooms_updateBtn;
        private Button rooms_addBtn;
    }
}
