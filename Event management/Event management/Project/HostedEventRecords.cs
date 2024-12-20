using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class HostedEventRecords : Form
    {
        public HostedEventRecords()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0CRP0DE\SQLEXPRESS;Initial Catalog=tbbb;Integrated Security=True");
            con.Open();
            string query = "SELECT * FROM HostedEvents";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void guna2CircleButton14_Click(object sender, EventArgs e)
        {
            FeedbackRecords fbrs = new FeedbackRecords();
            fbrs.Show();
            this.Hide();
        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {
            LoggedCustomers logcust = new LoggedCustomers();
            logcust.Show();
            this.Hide();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

            OperationsCenter op = new OperationsCenter();
            op.Show();
            this.Hide();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            RoleSelection rs = new RoleSelection();
            this.Hide();
            rs.Show();
        }
    }

}