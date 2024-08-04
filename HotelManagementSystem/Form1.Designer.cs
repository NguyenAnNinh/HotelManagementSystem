namespace HotelManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            close = new Label();
            label1 = new Label();
            label2 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            label3 = new Label();
            login_showpass = new CheckBox();
            login_btn = new Button();
            panel1 = new Panel();
            login_registerbtn = new Button();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(564, 9);
            close.Name = "close";
            close.Size = new Size(15, 15);
            close.TabIndex = 1;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 92);
            label1.Name = "label1";
            label1.Size = new Size(198, 22);
            label1.TabIndex = 2;
            label1.Text = "Welcome back, User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(313, 161);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // login_username
            // 
            login_username.BorderStyle = BorderStyle.FixedSingle;
            login_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(313, 179);
            login_username.Name = "login_username";
            login_username.Size = new Size(265, 29);
            login_username.TabIndex = 4;
            // 
            // login_password
            // 
            login_password.BorderStyle = BorderStyle.FixedSingle;
            login_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(313, 241);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(265, 29);
            login_password.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(313, 223);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // login_showpass
            // 
            login_showpass.AutoSize = true;
            login_showpass.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showpass.Location = new Point(313, 276);
            login_showpass.Name = "login_showpass";
            login_showpass.Size = new Size(120, 18);
            login_showpass.TabIndex = 7;
            login_showpass.Text = "Show Password";
            login_showpass.UseVisualStyleBackColor = true;
            login_showpass.CheckedChanged += login_showpass_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(3, 14, 28);
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 110, 138);
            login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 110, 138);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(350, 352);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(177, 35);
            login_btn.TabIndex = 8;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 14, 28);
            panel1.Controls.Add(login_registerbtn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 450);
            panel1.TabIndex = 9;
            // 
            // login_registerbtn
            // 
            login_registerbtn.BackColor = Color.FromArgb(3, 14, 28);
            login_registerbtn.FlatStyle = FlatStyle.Flat;
            login_registerbtn.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_registerbtn.ForeColor = Color.White;
            login_registerbtn.Location = new Point(22, 386);
            login_registerbtn.Name = "login_registerbtn";
            login_registerbtn.Size = new Size(254, 35);
            login_registerbtn.TabIndex = 9;
            login_registerbtn.Text = "Register";
            login_registerbtn.UseVisualStyleBackColor = false;
            login_registerbtn.Click += login_registerbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(59, 352);
            label5.Name = "label5";
            label5.Size = new Size(170, 18);
            label5.TabIndex = 2;
            label5.Text = "Create new account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 161);
            label4.Name = "label4";
            label4.Size = new Size(254, 22);
            label4.TabIndex = 1;
            label4.Text = "Hotel Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_hotel_80;
            pictureBox1.Location = new Point(101, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(591, 450);
            Controls.Add(panel1);
            Controls.Add(login_btn);
            Controls.Add(login_showpass);
            Controls.Add(login_password);
            Controls.Add(label3);
            Controls.Add(login_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label close;
        private Label label1;
        private Label label2;
        private TextBox login_username;
        private TextBox login_password;
        private Label label3;
        private CheckBox login_showpass;
        private Button login_btn;
        private Panel panel1;
        private Button login_registerbtn;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
