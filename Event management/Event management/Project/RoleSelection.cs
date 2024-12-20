using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class RoleSelection : Form
    {
        public RoleSelection()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            if (AdminRbtn.Checked)
            {
                Login log = new Login();
                this.Hide();
                log.Show();
            }

            if (CustRbtn.Checked)
            {
                CustomerLogin custlog = new CustomerLogin();
                this.Hide();
                custlog.Show();
            }

            if (AdminRbtn.Checked == false && CustRbtn.Checked == false)
            {
                MessageBox.Show("Kindly select your role.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminRbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            AboutUS about = new AboutUS();
            about.Show();   
            this.Hide();
        }
    }
}
