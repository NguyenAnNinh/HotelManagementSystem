namespace HotelManagementSystem
{
    partial class admin_adduser
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
            adduser_clearBtn = new Button();
            adduser_deleteBtn = new Button();
            adduser_updateBtn = new Button();
            adduser_addBtn = new Button();
            adduser_status = new ComboBox();
            adduser_role = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            adduser_password = new TextBox();
            label2 = new Label();
            adduser_username = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(adduser_clearBtn);
            panel1.Controls.Add(adduser_deleteBtn);
            panel1.Controls.Add(adduser_updateBtn);
            panel1.Controls.Add(adduser_addBtn);
            panel1.Controls.Add(adduser_status);
            panel1.Controls.Add(adduser_role);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(adduser_password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(adduser_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 581);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // adduser_clearBtn
            // 
            adduser_clearBtn.BackColor = Color.FromArgb(3, 14, 28);
            adduser_clearBtn.FlatAppearance.BorderSize = 0;
            adduser_clearBtn.FlatStyle = FlatStyle.Flat;
            adduser_clearBtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adduser_clearBtn.ForeColor = Color.White;
            adduser_clearBtn.Location = new Point(14, 481);
            adduser_clearBtn.Name = "adduser_clearBtn";
            adduser_clearBtn.Size = new Size(172, 34);
            adduser_clearBtn.TabIndex = 12;
            adduser_clearBtn.Text = "Clear";
            adduser_clearBtn.UseVisualStyleBackColor = false;
            adduser_clearBtn.Click += adduser_clearBtn_Click;
            // 
            // adduser_deleteBtn
            // 
            adduser_deleteBtn.BackColor = Color.FromArgb(3, 14, 28);
            adduser_deleteBtn.FlatAppearance.BorderSize = 0;
            adduser_deleteBtn.FlatStyle = FlatStyle.Flat;
            adduser_deleteBtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adduser_deleteBtn.ForeColor = Color.White;
            adduser_deleteBtn.Location = new Point(14, 441);
            adduser_deleteBtn.Name = "adduser_deleteBtn";
            adduser_deleteBtn.Size = new Size(172, 34);
            adduser_deleteBtn.TabIndex = 11;
            adduser_deleteBtn.Text = "Delete";
            adduser_deleteBtn.UseVisualStyleBackColor = false;
            adduser_deleteBtn.Click += adduser_deleteBtn_Click;
            // 
            // adduser_updateBtn
            // 
            adduser_updateBtn.BackColor = Color.FromArgb(3, 14, 28);
            adduser_updateBtn.FlatAppearance.BorderSize = 0;
            adduser_updateBtn.FlatStyle = FlatStyle.Flat;
            adduser_updateBtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adduser_updateBtn.ForeColor = Color.White;
            adduser_updateBtn.Location = new Point(14, 381);
            adduser_updateBtn.Name = "adduser_updateBtn";
            adduser_updateBtn.Size = new Size(172, 34);
            adduser_updateBtn.TabIndex = 10;
            adduser_updateBtn.Text = "Update";
            adduser_updateBtn.UseVisualStyleBackColor = false;
            adduser_updateBtn.Click += adduser_updateBtn_Click;
            // 
            // adduser_addBtn
            // 
            adduser_addBtn.BackColor = Color.FromArgb(3, 14, 28);
            adduser_addBtn.FlatAppearance.BorderSize = 0;
            adduser_addBtn.FlatStyle = FlatStyle.Flat;
            adduser_addBtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adduser_addBtn.ForeColor = Color.White;
            adduser_addBtn.Location = new Point(14, 341);
            adduser_addBtn.Name = "adduser_addBtn";
            adduser_addBtn.Size = new Size(172, 34);
            adduser_addBtn.TabIndex = 9;
            adduser_addBtn.Text = "Add";
            adduser_addBtn.UseVisualStyleBackColor = false;
            adduser_addBtn.Click += adduser_addBtn_Click;
            // 
            // adduser_status
            // 
            adduser_status.FormattingEnabled = true;
            adduser_status.Items.AddRange(new object[] { "Active", "Inactive" });
            adduser_status.Location = new Point(14, 263);
            adduser_status.Name = "adduser_status";
            adduser_status.Size = new Size(172, 23);
            adduser_status.TabIndex = 8;
            // 
            // adduser_role
            // 
            adduser_role.FormattingEnabled = true;
            adduser_role.Items.AddRange(new object[] { "Admin", "Staff" });
            adduser_role.Location = new Point(14, 192);
            adduser_role.Name = "adduser_role";
            adduser_role.Size = new Size(172, 23);
            adduser_role.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label4.Location = new Point(14, 241);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label3.Location = new Point(14, 172);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Role";
            // 
            // adduser_password
            // 
            adduser_password.BorderStyle = BorderStyle.FixedSingle;
            adduser_password.Location = new Point(14, 125);
            adduser_password.Name = "adduser_password";
            adduser_password.Size = new Size(172, 23);
            adduser_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label2.Location = new Point(14, 104);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // adduser_username
            // 
            adduser_username.BorderStyle = BorderStyle.FixedSingle;
            adduser_username.Location = new Point(14, 58);
            adduser_username.Name = "adduser_username";
            adduser_username.Size = new Size(172, 23);
            adduser_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label1.Location = new Point(14, 37);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(228, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 581);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label5.Location = new Point(12, 10);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 13;
            label5.Text = "User's Data";
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
            dataGridView1.Location = new Point(12, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(420, 525);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // admin_adduser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "admin_adduser";
            Size = new Size(688, 606);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox adduser_username;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox adduser_password;
        private Label label2;
        private Button adduser_addBtn;
        private ComboBox adduser_status;
        private ComboBox adduser_role;
        private Button adduser_clearBtn;
        private Button adduser_deleteBtn;
        private Button adduser_updateBtn;
        private DataGridView dataGridView1;
        private Label label5;
    }
}
