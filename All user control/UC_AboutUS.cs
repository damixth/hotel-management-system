using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.All_user_control
{
    public partial class UC_AboutUS : UserControl
    {
        public UC_AboutUS()
        {
            InitializeComponent();
            vScrollBar1.Maximum = Math.Max(0, panel2.Height - this.Height);
            vScrollBar1.LargeChange = 10;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel2.Location = new Point(panel2.Location.X, -vScrollBar1.Value);
        }

        public void UpdateScrollbar()
        {
            vScrollBar1.Maximum = Math.Max(0, panel2.Height - this.Height);
        }
    }
}
