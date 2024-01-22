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
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        String query;

        public UC_Employee()
        {
            InitializeComponent();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxId();
        }


        public void getMaxId()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSet.Text = (num + 1).ToString();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String username = txtUsername.Text;
                String password = txtPassword.Text;

                query = "insert into employee (ename,mobile,gender,emailid,username,pass) values('" + name + "'," + mobile + ",'" + gender + "','" + email + "','" + username + "','" + password + "')";
                fn.setData(query, "Employee Registered.");

                clearAll();
                getMaxId();
            }
            else
            {
                MessageBox.Show("Fill all fields!!", "Warning..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            txtEmail.Clear();
            txtName.Clear();
            txtGender.SelectedIndex = -1;
            txtMobile.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        public void setEmployeeRecord(DataGridView dataGridView)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dataGridView.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "Confirmation..!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid = " + txtId.Text + "";
                    fn.setData(query, "Deleted Record!");
                    tabEmployee_SelectedIndexChanged(this, null);
                }
            }
            else
            {
                MessageBox.Show("Provide and ID!!", "Warning..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                setEmployeeRecord(dataGridView1);
            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                setEmployeeRecord(dataGridView2);
            }
        }
    }
}
