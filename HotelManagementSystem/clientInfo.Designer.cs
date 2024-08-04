namespace HotelManagementSystem
{
    partial class clientInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            closeX = new Label();
            label2 = new Label();
            panel2 = new Panel();
            client_clearBtn = new Button();
            client_bookBtn = new Button();
            client_gender = new ComboBox();
            label9 = new Label();
            client_address = new TextBox();
            label8 = new Label();
            client_email = new TextBox();
            label7 = new Label();
            client_contact = new TextBox();
            label6 = new Label();
            client_fullname = new TextBox();
            label5 = new Label();
            client_bookid = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 14, 28);
            panel1.Controls.Add(closeX);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 38);
            panel1.TabIndex = 4;
            // 
            // closeX
            // 
            closeX.AutoSize = true;
            closeX.BackColor = Color.Transparent;
            closeX.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeX.ForeColor = Color.White;
            closeX.Location = new Point(725, 9);
            closeX.Name = "closeX";
            closeX.Size = new Size(18, 18);
            closeX.TabIndex = 4;
            closeX.Text = "X";
            closeX.Click += closeX_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(150, 17);
            label2.TabIndex = 3;
            label2.Text = "Client's Information";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(client_clearBtn);
            panel2.Controls.Add(client_bookBtn);
            panel2.Controls.Add(client_gender);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(client_address);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(client_email);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(client_contact);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(client_fullname);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(client_bookid);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(732, 383);
            panel2.TabIndex = 5;
            // 
            // client_clearBtn
            // 
            client_clearBtn.BackColor = Color.FromArgb(3, 14, 28);
            client_clearBtn.FlatAppearance.BorderSize = 0;
            client_clearBtn.FlatStyle = FlatStyle.Flat;
            client_clearBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            client_clearBtn.ForeColor = Color.White;
            client_clearBtn.Location = new Point(432, 288);
            client_clearBtn.Name = "client_clearBtn";
            client_clearBtn.Size = new Size(260, 31);
            client_clearBtn.TabIndex = 23;
            client_clearBtn.Text = "Clear";
            client_clearBtn.UseVisualStyleBackColor = false;
            client_clearBtn.Click += client_clearBtn_Click;
            // 
            // client_bookBtn
            // 
            client_bookBtn.BackColor = Color.FromArgb(3, 14, 28);
            client_bookBtn.FlatAppearance.BorderSize = 0;
            client_bookBtn.FlatStyle = FlatStyle.Flat;
            client_bookBtn.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            client_bookBtn.ForeColor = Color.White;
            client_bookBtn.Location = new Point(81, 288);
            client_bookBtn.Name = "client_bookBtn";
            client_bookBtn.Size = new Size(260, 31);
            client_bookBtn.TabIndex = 22;
            client_bookBtn.Text = "Book Now";
            client_bookBtn.UseVisualStyleBackColor = false;
            client_bookBtn.Click += Rooms_addBtn_Click;
            // 
            // client_gender
            // 
            client_gender.FormattingEnabled = true;
            client_gender.Items.AddRange(new object[] { "Male", "Female" });
            client_gender.Location = new Point(461, 83);
            client_gender.Name = "client_gender";
            client_gender.Size = new Size(219, 23);
            client_gender.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(407, 86);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 10;
            label9.Text = "Gender:";
            // 
            // client_address
            // 
            client_address.BorderStyle = BorderStyle.FixedSingle;
            client_address.Location = new Point(461, 140);
            client_address.Multiline = true;
            client_address.Name = "client_address";
            client_address.Size = new Size(219, 68);
            client_address.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(399, 142);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 8;
            label8.Text = "Address:";
            // 
            // client_email
            // 
            client_email.BorderStyle = BorderStyle.FixedSingle;
            client_email.Location = new Point(107, 136);
            client_email.Name = "client_email";
            client_email.Size = new Size(219, 23);
            client_email.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 138);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 6;
            label7.Text = "Email Address:";
            // 
            // client_contact
            // 
            client_contact.BorderStyle = BorderStyle.FixedSingle;
            client_contact.Location = new Point(107, 184);
            client_contact.Name = "client_contact";
            client_contact.Size = new Size(219, 23);
            client_contact.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(4, 186);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 4;
            label6.Text = "Contact Number:";
            // 
            // client_fullname
            // 
            client_fullname.BorderStyle = BorderStyle.FixedSingle;
            client_fullname.Location = new Point(107, 89);
            client_fullname.Name = "client_fullname";
            client_fullname.Size = new Size(219, 23);
            client_fullname.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 91);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 2;
            label5.Text = "Full Name:";
            // 
            // client_bookid
            // 
            client_bookid.AutoSize = true;
            client_bookid.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            client_bookid.Location = new Point(107, 35);
            client_bookid.Name = "client_bookid";
            client_bookid.Size = new Size(56, 15);
            client_bookid.TabIndex = 1;
            client_bookid.Text = "Book ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 35);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 0;
            label3.Text = "Book ID:";
            // 
            // clientInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "clientInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "clientInfo";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label closeX;
        private Panel panel2;
        private Label label9;
        private TextBox client_address;
        private Label label8;
        private TextBox client_email;
        private Label label7;
        private TextBox client_contact;
        private Label label6;
        private TextBox client_fullname;
        private Label label5;
        private Label client_bookid;
        private Label label3;
        private ComboBox client_gender;
        private Button client_clearBtn;
        private Button client_bookBtn;
    }
}