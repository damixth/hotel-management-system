using HotelManagementSystem.All_user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCusRegister.Left;
        }

        private void btnRoomDetails_Click(object sender, EventArgs e)
        {
            MakeOtherUserControlsInvisible();
            MovingPanel.Left = btnRoomDetails.Left;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            MakeOtherUserControlsInvisible();
            MovingPanel.Left = btnAboutUs.Left;
            uC_Aboutus1.Visible = true;
            uC_Aboutus1.BringToFront();

            uC_Aboutus1.UpdateScrollbar();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            MakeOtherUserControlsInvisible();
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
            MovingPanel.Left = btnEmployee.Left;
        }

        private void btnCusDetails_Click(object sender, EventArgs e)
        {
            MakeOtherUserControlsInvisible();
            MovingPanel.Left = btnCusDetails.Left;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Employee1.Visible = false;
            uC_AddRoom1.Visible = false;
            uC_Aboutus1.Visible = false;
            btnAboutUs.PerformClick();
        }

        public void MakeOtherUserControlsInvisible()
        {
            foreach (Control control in Controls)
            {
                if (control is UserControl userControl && userControl != uC_Employee1)
                {
                    userControl.Visible = false;
                }
            }
        }
    }
}
