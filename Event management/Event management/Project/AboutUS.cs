﻿using System;
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
    public partial class AboutUS : Form
    {
        public AboutUS()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            RoleSelection roleSelection = new RoleSelection();
            roleSelection.Show();
            this.Hide();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
