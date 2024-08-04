namespace HotelManagementSystem
{
    partial class staffMainForm
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
            label2 = new Label();
            close = new Label();
            panel2 = new Panel();
            logout_btn = new Button();
            customers_btn = new Button();
            bookroom_btn = new Button();
            dashboard_btn = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            admin_dashboard1 = new admin_dashboard();
            staff_bookRoom1 = new staff_bookRoom();
            admin_customers1 = new admin_customers();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 14, 28);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 38);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(200, 17);
            label2.TabIndex = 3;
            label2.Text = "Hotel Management System";
            // 
            // close
            // 
            close.AutoSize = true;
            close.BackColor = Color.Transparent;
            close.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.ForeColor = Color.White;
            close.Location = new Point(872, 9);
            close.Name = "close";
            close.Size = new Size(18, 18);
            close.TabIndex = 1;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 110, 138);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(customers_btn);
            panel2.Controls.Add(bookroom_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 606);
            panel2.TabIndex = 4;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.FromArgb(52, 110, 138);
            logout_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            logout_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.White;
            logout_btn.Location = new Point(12, 554);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(191, 40);
            logout_btn.TabIndex = 8;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // customers_btn
            // 
            customers_btn.BackColor = Color.FromArgb(52, 110, 138);
            customers_btn.FlatAppearance.BorderSize = 0;
            customers_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            customers_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            customers_btn.FlatStyle = FlatStyle.Flat;
            customers_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customers_btn.ForeColor = Color.White;
            customers_btn.Location = new Point(12, 295);
            customers_btn.Name = "customers_btn";
            customers_btn.Size = new Size(191, 40);
            customers_btn.TabIndex = 6;
            customers_btn.Text = "Customers";
            customers_btn.UseVisualStyleBackColor = false;
            customers_btn.Click += customers_btn_Click;
            // 
            // bookroom_btn
            // 
            bookroom_btn.BackColor = Color.FromArgb(52, 110, 138);
            bookroom_btn.FlatAppearance.BorderSize = 0;
            bookroom_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            bookroom_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            bookroom_btn.FlatStyle = FlatStyle.Flat;
            bookroom_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookroom_btn.ForeColor = Color.White;
            bookroom_btn.Location = new Point(12, 249);
            bookroom_btn.Name = "bookroom_btn";
            bookroom_btn.Size = new Size(191, 40);
            bookroom_btn.TabIndex = 5;
            bookroom_btn.Text = "Book Room";
            bookroom_btn.UseVisualStyleBackColor = false;
            bookroom_btn.Click += bookroom_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.FromArgb(52, 110, 138);
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 14, 28);
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 14, 28);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(12, 203);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(191, 40);
            dashboard_btn.TabIndex = 4;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(46, 117);
            label4.Name = "label4";
            label4.Size = new Size(123, 18);
            label4.TabIndex = 3;
            label4.Text = "Welcome User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_hotel_80;
            pictureBox1.Location = new Point(69, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(admin_dashboard1);
            panel3.Controls.Add(staff_bookRoom1);
            panel3.Controls.Add(admin_customers1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(214, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(688, 606);
            panel3.TabIndex = 5;
            // 
            // admin_dashboard1
            // 
            admin_dashboard1.Location = new Point(0, 0);
            admin_dashboard1.Name = "admin_dashboard1";
            admin_dashboard1.Size = new Size(688, 606);
            admin_dashboard1.TabIndex = 4;
            // 
            // staff_bookRoom1
            // 
            staff_bookRoom1.Location = new Point(0, 0);
            staff_bookRoom1.Name = "staff_bookRoom1";
            staff_bookRoom1.Size = new Size(688, 606);
            staff_bookRoom1.TabIndex = 4;
            // 
            // admin_customers1
            // 
            admin_customers1.Location = new Point(0, 0);
            admin_customers1.Name = "admin_customers1";
            admin_customers1.Size = new Size(688, 606);
            admin_customers1.TabIndex = 0;
            // 
            // staffMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 644);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "staffMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "staffMainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label close;
        private Panel panel2;
        private Button logout_btn;
        private Button customers_btn;
        private Button bookroom_btn;
        private Button dashboard_btn;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel3;
        private admin_dashboard admin_dashboard1;
        private staff_bookRoom staff_bookRoom1;
        private admin_customers admin_customers1;
    }
}