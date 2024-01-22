namespace HotelManagementSystem.All_user_control
{
    partial class UC_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Employee));
            label1 = new Label();
            tabEmployee = new TabControl();
            tabPage1 = new TabPage();
            btnRegister = new Button();
            txtPassword = new TextBox();
            label9 = new Label();
            txtUsername = new TextBox();
            label8 = new Label();
            txtGender = new ComboBox();
            txtEmail = new TextBox();
            txtMobile = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            labelToSet = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            tabPage3 = new TabPage();
            dataGridView2 = new DataGridView();
            btnDelete = new Button();
            txtId = new TextBox();
            label11 = new Label();
            tabEmployee.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 2;
            label1.Text = "Employee Details";
            // 
            // tabEmployee
            // 
            tabEmployee.Controls.Add(tabPage1);
            tabEmployee.Controls.Add(tabPage2);
            tabEmployee.Controls.Add(tabPage3);
            tabEmployee.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabEmployee.Location = new Point(30, 90);
            tabEmployee.Name = "tabEmployee";
            tabEmployee.SelectedIndex = 0;
            tabEmployee.Size = new Size(1140, 440);
            tabEmployee.TabIndex = 3;
            tabEmployee.SelectedIndexChanged += tabEmployee_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRegister);
            tabPage1.Controls.Add(txtPassword);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txtUsername);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(txtGender);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtMobile);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(labelToSet);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1132, 407);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Employee Registration";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(802, 315);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(96, 36);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(647, 201);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(327, 27);
            txtPassword.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(646, 171);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 13;
            label9.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(647, 128);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Username";
            txtUsername.Size = new Size(327, 27);
            txtUsername.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(646, 98);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 11;
            label8.Text = "Username";
            // 
            // txtGender
            // 
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            txtGender.Location = new Point(57, 257);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(327, 28);
            txtGender.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(57, 324);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter Email";
            txtEmail.Size = new Size(327, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(57, 194);
            txtMobile.Name = "txtMobile";
            txtMobile.PlaceholderText = "Enter Contact Number";
            txtMobile.Size = new Size(327, 27);
            txtMobile.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(57, 128);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter Full Name";
            txtName.Size = new Size(327, 27);
            txtName.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 301);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 5;
            label7.Text = "Email Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 234);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 4;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 171);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 3;
            label5.Text = "Mobile Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 98);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // labelToSet
            // 
            labelToSet.AutoSize = true;
            labelToSet.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelToSet.ForeColor = Color.Red;
            labelToSet.Location = new Point(100, 26);
            labelToSet.Name = "labelToSet";
            labelToSet.Size = new Size(74, 32);
            labelToSet.TabIndex = 1;
            labelToSet.Text = "------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 36);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 0;
            label2.Text = "ID - ";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1132, 407);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Employee Details";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1090, 322);
            dataGridView1.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(549, 22);
            label10.Name = "label10";
            label10.Size = new Size(156, 25);
            label10.TabIndex = 0;
            label10.Text = "Employee Details";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(btnDelete);
            tabPage3.Controls.Add(txtId);
            tabPage3.Controls.Add(label11);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1132, 407);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Delete Employee";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(17, 118);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1095, 269);
            dataGridView2.TabIndex = 17;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(738, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 36);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.Location = new Point(400, 35);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Enter ID";
            txtId.Size = new Size(278, 29);
            txtId.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(332, 38);
            label11.Name = "label11";
            label11.Size = new Size(25, 21);
            label11.TabIndex = 1;
            label11.Text = "ID";
            // 
            // UC_Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(tabEmployee);
            Controls.Add(label1);
            Name = "UC_Employee";
            Size = new Size(1342, 583);
            Load += UC_Employee_Load;
            Leave += UC_Employee_Leave;
            tabEmployee.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabEmployee;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label labelToSet;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtMobile;
        private TextBox txtName;
        private ComboBox txtGender;
        private Button btnRegister;
        private TextBox txtPassword;
        private Label label9;
        private TextBox txtUsername;
        private Label label8;
        private DataGridView dataGridView1;
        private Label label10;
        private Button btnDelete;
        private TextBox txtId;
        private Label label11;
        private DataGridView dataGridView2;
    }
}
