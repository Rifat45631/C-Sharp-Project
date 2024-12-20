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
    public partial class Showcase : Form
    {
        public Showcase()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            CustomerLogin cuslog = new CustomerLogin();
            this.Hide();
            cuslog.Show();
        }

        private void guna2CircleButton10_Click(object sender, EventArgs e)
        {
            Hosting ho = new Hosting();
            this.Hide();
            ho.Show();
        }

        private void guna2CircleButton14_Click(object sender, EventArgs e)
        {
            GiveFeedBacks giveFeedBacks = new GiveFeedBacks();
            this.Hide();
            giveFeedBacks.Show();
        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {

        }
        int count = 0;
        private void NextBtn_Click(object sender, EventArgs e)
        {

            if (count < 21)
            {
                count++;
                UpdateImageAndLabel();
            }
            else
            {
                MessageBox.Show("End of PicturesNo more pictures available.", "Information Message.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
                UpdateImageAndLabel();
            }
            else
            {
                MessageBox.Show("Beginning of Pictures, No more previous pictures available.", "Information Message.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Showcase_Load(object sender, EventArgs e)
        {
            count = 0;
            UpdateImageAndLabel();
        }
        private void UpdateImageAndLabel()
        {
            CountLbl.Text = (count + 1).ToString();
            pictureBox2.Image = imageList1.Images[count];
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RoleSelection rolecust = new RoleSelection();
            this.Hide();
            rolecust.Show();
        }
    }
}
