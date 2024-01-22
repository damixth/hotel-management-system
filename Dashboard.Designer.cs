namespace HotelManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            MovingPanel = new Panel();
            btnCusRegister = new Button();
            btnCusDetails = new Button();
            btnEmployee = new Button();
            btnRoomDetails = new Button();
            btnAboutUs = new Button();
            panel2 = new Panel();
            uC_Employee1 = new All_user_control.UC_Employee();
            uC_Aboutus1 = new All_user_control.UC_AboutUS();
            uC_AddRoom1 = new All_user_control.UC_AddRoom();
            btnExit = new Button();
            btnMinimize = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(MovingPanel);
            panel1.Controls.Add(btnCusRegister);
            panel1.Controls.Add(btnCusDetails);
            panel1.Controls.Add(btnEmployee);
            panel1.Controls.Add(btnRoomDetails);
            panel1.Controls.Add(btnAboutUs);
            panel1.Location = new Point(68, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1249, 130);
            panel1.TabIndex = 0;
            // 
            // MovingPanel
            // 
            MovingPanel.BackColor = Color.FromArgb(128, 128, 255);
            MovingPanel.Location = new Point(-1, 105);
            MovingPanel.Name = "MovingPanel";
            MovingPanel.Size = new Size(239, 5);
            MovingPanel.TabIndex = 0;
            // 
            // btnCusRegister
            // 
            btnCusRegister.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCusRegister.ForeColor = Color.DarkSlateGray;
            btnCusRegister.Image = (Image)resources.GetObject("btnCusRegister.Image");
            btnCusRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnCusRegister.Location = new Point(987, 25);
            btnCusRegister.Name = "btnCusRegister";
            btnCusRegister.Size = new Size(261, 85);
            btnCusRegister.TabIndex = 4;
            btnCusRegister.Text = "Registration";
            btnCusRegister.UseVisualStyleBackColor = true;
            btnCusRegister.Click += button7_Click;
            // 
            // btnCusDetails
            // 
            btnCusDetails.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCusDetails.ForeColor = Color.DarkSlateGray;
            btnCusDetails.Image = (Image)resources.GetObject("btnCusDetails.Image");
            btnCusDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnCusDetails.Location = new Point(738, 25);
            btnCusDetails.Name = "btnCusDetails";
            btnCusDetails.Size = new Size(253, 85);
            btnCusDetails.TabIndex = 3;
            btnCusDetails.Text = "Customer Details";
            btnCusDetails.UseVisualStyleBackColor = true;
            btnCusDetails.Click += btnCusDetails_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployee.ForeColor = Color.DarkSlateGray;
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(491, 25);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(251, 85);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "Employee Details";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnRoomDetails
            // 
            btnRoomDetails.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoomDetails.ForeColor = Color.DarkSlateGray;
            btnRoomDetails.Image = (Image)resources.GetObject("btnRoomDetails.Image");
            btnRoomDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoomDetails.Location = new Point(237, 25);
            btnRoomDetails.Name = "btnRoomDetails";
            btnRoomDetails.Size = new Size(258, 85);
            btnRoomDetails.TabIndex = 1;
            btnRoomDetails.Text = "Room Details";
            btnRoomDetails.UseVisualStyleBackColor = true;
            btnRoomDetails.Click += btnRoomDetails_Click;
            // 
            // btnAboutUs
            // 
            btnAboutUs.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAboutUs.ForeColor = Color.DarkSlateGray;
            btnAboutUs.Image = (Image)resources.GetObject("btnAboutUs.Image");
            btnAboutUs.ImageAlign = ContentAlignment.MiddleLeft;
            btnAboutUs.Location = new Point(-1, 25);
            btnAboutUs.Name = "btnAboutUs";
            btnAboutUs.Size = new Size(244, 85);
            btnAboutUs.TabIndex = 0;
            btnAboutUs.Text = "About Us";
            btnAboutUs.UseVisualStyleBackColor = true;
            btnAboutUs.Click += btnAboutUs_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(uC_Employee1);
            panel2.Controls.Add(uC_Aboutus1);
            panel2.Controls.Add(uC_AddRoom1);
            panel2.Location = new Point(20, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(1297, 553);
            panel2.TabIndex = 1;
            // 
            // uC_Employee1
            // 
            uC_Employee1.BackColor = Color.Silver;
            uC_Employee1.BackgroundImage = (Image)resources.GetObject("uC_Employee1.BackgroundImage");
            uC_Employee1.BackgroundImageLayout = ImageLayout.Center;
            uC_Employee1.Location = new Point(3, 3);
            uC_Employee1.Name = "uC_Employee1";
            uC_Employee1.Size = new Size(1342, 590);
            uC_Employee1.TabIndex = 2;
            // 
            // uC_Aboutus1
            // 
            uC_Aboutus1.Location = new Point(3, 3);
            uC_Aboutus1.Name = "uC_Aboutus1";
            uC_Aboutus1.Size = new Size(1297, 1085);
            uC_Aboutus1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            uC_AddRoom1.BackColor = Color.White;
            uC_AddRoom1.BackgroundImage = (Image)resources.GetObject("uC_AddRoom1.BackgroundImage");
            uC_AddRoom1.Location = new Point(3, 3);
            uC_AddRoom1.Name = "uC_AddRoom1";
            uC_AddRoom1.Size = new Size(1291, 550);
            uC_AddRoom1.TabIndex = 0;
            uC_AddRoom1.Visible = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.Location = new Point(1, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(29, 30);
            btnExit.TabIndex = 2;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BackgroundImage = (Image)resources.GetObject("btnMinimize.BackgroundImage");
            btnMinimize.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinimize.Location = new Point(1, 37);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(29, 30);
            btnMinimize.TabIndex = 3;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1329, 788);
            Controls.Add(btnMinimize);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnExit;
        private Button btnMinimize;
        private Button btnAboutUs;
        private Button btnEmployee;
        private Button btnRoomDetails;
        private Button btnCusRegister;
        private Button btnCusDetails;
        private Panel MovingPanel;
        private All_user_control.UC_AddRoom uC_AddRoom1;
        private All_user_control.UC_AboutUS uC_Aboutus1;
        private All_user_control.UC_Employee uC_Employee1;
    }
}