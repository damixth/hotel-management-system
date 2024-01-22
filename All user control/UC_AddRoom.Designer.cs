namespace HotelManagementSystem.All_user_control
{
    partial class UC_AddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddRoom));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtRoomNumber = new TextBox();
            txtPrice = new TextBox();
            txtType = new ComboBox();
            txtBed = new ComboBox();
            btnAddRoom = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 1;
            label1.Text = "Add Room";
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(663, 345);
            dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(799, 69);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 3;
            label2.Text = "Room Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(799, 146);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Room Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(799, 221);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 5;
            label4.Text = "Bed";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(799, 299);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 6;
            label5.Text = "Price";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomNumber.Location = new Point(799, 93);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(272, 27);
            txtRoomNumber.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(799, 324);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(272, 27);
            txtPrice.TabIndex = 8;
            // 
            // txtType
            // 
            txtType.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtType.FormattingEnabled = true;
            txtType.Items.AddRange(new object[] { "AC", "Non-AC" });
            txtType.Location = new Point(799, 170);
            txtType.Name = "txtType";
            txtType.Size = new Size(272, 28);
            txtType.TabIndex = 9;
            // 
            // txtBed
            // 
            txtBed.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBed.FormattingEnabled = true;
            txtBed.Items.AddRange(new object[] { "Single", "Double", "Triple", "Family", "Deluxe" });
            txtBed.Location = new Point(799, 243);
            txtBed.Name = "txtBed";
            txtBed.Size = new Size(272, 28);
            txtBed.TabIndex = 10;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.FromArgb(192, 192, 255);
            btnAddRoom.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddRoom.Location = new Point(963, 394);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(108, 27);
            btnAddRoom.TabIndex = 11;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(141, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // UC_AddRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(pictureBox1);
            Controls.Add(btnAddRoom);
            Controls.Add(txtBed);
            Controls.Add(txtType);
            Controls.Add(txtPrice);
            Controls.Add(txtRoomNumber);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "UC_AddRoom";
            Size = new Size(1213, 583);
            Load += UC_AddRoom_Load;
            Enter += UC_AddRoom_Enter;
            Leave += UC_AddRoom_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRoomNumber;
        private TextBox txtPrice;
        private ComboBox txtType;
        private ComboBox txtBed;
        private Button btnAddRoom;
        private PictureBox pictureBox1;
    }
}
