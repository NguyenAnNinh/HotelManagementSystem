namespace HotelManagementSystem
{
    partial class RegistrationForm
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
            register_signin = new Button();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            register_signup = new Button();
            register_showpass = new CheckBox();
            register_password = new TextBox();
            label3 = new Label();
            register_username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            close = new Label();
            register_cpassword = new TextBox();
            label6 = new Label();
            closeX = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 14, 28);
            panel1.Controls.Add(register_signin);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 450);
            panel1.TabIndex = 18;
            // 
            // register_signin
            // 
            register_signin.BackColor = Color.FromArgb(3, 14, 28);
            register_signin.FlatStyle = FlatStyle.Flat;
            register_signin.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_signin.ForeColor = Color.White;
            register_signin.Location = new Point(22, 386);
            register_signin.Name = "register_signin";
            register_signin.Size = new Size(254, 35);
            register_signin.TabIndex = 9;
            register_signin.Text = "Sign In";
            register_signin.UseVisualStyleBackColor = false;
            register_signin.Click += register_signin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(59, 352);
            label5.Name = "label5";
            label5.Size = new Size(171, 18);
            label5.TabIndex = 2;
            label5.Text = "Sign in your account";
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
            // register_signup
            // 
            register_signup.BackColor = Color.FromArgb(3, 14, 28);
            register_signup.FlatAppearance.BorderSize = 0;
            register_signup.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 110, 138);
            register_signup.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 110, 138);
            register_signup.FlatStyle = FlatStyle.Flat;
            register_signup.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_signup.ForeColor = Color.White;
            register_signup.Location = new Point(345, 375);
            register_signup.Name = "register_signup";
            register_signup.Size = new Size(177, 35);
            register_signup.TabIndex = 17;
            register_signup.Text = "Sign Up";
            register_signup.UseVisualStyleBackColor = false;
            register_signup.Click += register_signup_Click;
            // 
            // register_showpass
            // 
            register_showpass.AutoSize = true;
            register_showpass.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_showpass.Location = new Point(308, 315);
            register_showpass.Name = "register_showpass";
            register_showpass.Size = new Size(120, 18);
            register_showpass.TabIndex = 16;
            register_showpass.Text = "Show Password";
            register_showpass.UseVisualStyleBackColor = true;
            register_showpass.CheckedChanged += register_showpass_CheckedChanged;
            // 
            // register_password
            // 
            register_password.BorderStyle = BorderStyle.FixedSingle;
            register_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_password.Location = new Point(308, 214);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(265, 29);
            register_password.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(308, 196);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // register_username
            // 
            register_username.BorderStyle = BorderStyle.FixedSingle;
            register_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_username.Location = new Point(308, 152);
            register_username.Name = "register_username";
            register_username.Size = new Size(265, 29);
            register_username.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(308, 134);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 12;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(376, 65);
            label1.Name = "label1";
            label1.Size = new Size(122, 22);
            label1.TabIndex = 11;
            label1.Text = "Registration";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(675, 9);
            close.Name = "close";
            close.Size = new Size(15, 15);
            close.TabIndex = 10;
            close.Text = "X";
            // 
            // register_cpassword
            // 
            register_cpassword.BorderStyle = BorderStyle.FixedSingle;
            register_cpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_cpassword.Location = new Point(308, 280);
            register_cpassword.Name = "register_cpassword";
            register_cpassword.PasswordChar = '*';
            register_cpassword.Size = new Size(265, 29);
            register_cpassword.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(308, 262);
            label6.Name = "label6";
            label6.Size = new Size(126, 15);
            label6.TabIndex = 19;
            label6.Text = "Confirm Password";
            // 
            // closeX
            // 
            closeX.AutoSize = true;
            closeX.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeX.Location = new Point(564, 9);
            closeX.Name = "closeX";
            closeX.Size = new Size(15, 15);
            closeX.TabIndex = 21;
            closeX.Text = "X";
            closeX.Click += closeX_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(591, 450);
            Controls.Add(closeX);
            Controls.Add(register_cpassword);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(register_signup);
            Controls.Add(register_showpass);
            Controls.Add(register_password);
            Controls.Add(label3);
            Controls.Add(register_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button register_signin;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Button register_signup;
        private CheckBox register_showpass;
        private TextBox register_password;
        private Label label3;
        private TextBox register_username;
        private Label label2;
        private Label label1;
        private Label close;
        private TextBox register_cpassword;
        private Label label6;
        private Label closeX;
    }
}