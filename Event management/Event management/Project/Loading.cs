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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            pbar.Value = 0;

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbar.Value += 1;
            pbar.Text = pbar.Value.ToString() + '%';
            if (pbar.Value == 100)
            {

                timer1.Enabled = false;
                RoleSelection roleselect = new RoleSelection();
                this.Hide();
                roleselect.Show();
            }
           
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            
        }
    }
}
