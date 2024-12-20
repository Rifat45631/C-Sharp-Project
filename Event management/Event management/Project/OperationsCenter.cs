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
    public partial class OperationsCenter : Form
    {
        public OperationsCenter()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            if (ExNexRbtn.Checked)
            {
                Customer custom = new Customer();
                this.Hide();
                custom.Show();
            }

            if (ClDyRbtn.Checked)
            {
                HostedEventRecords hostrec = new HostedEventRecords();
                this.Hide();
                hostrec.Show();
            }

            if (ExNexRbtn.Checked == false && ClDyRbtn.Checked == false)
            {
                MessageBox.Show("Kindly choose your operation..", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            RoleSelection rs = new RoleSelection();
            rs.Show();
            this.Hide();
        }
    }
}
