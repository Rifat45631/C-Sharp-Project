using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CountEvents();
            CountCustomers();
            CountVenues();
            CountExcellent();
            CountGood();
            CountOK();
            CountBad();
        }


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0CRP0DE\SQLEXPRESS;Initial Catalog=tbbb;Integrated Security=True");
        private void CountEvents()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)from EventTbl ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EventLbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }


        private void CountCustomers()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)from CustomerTbl ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CustLbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void CountVenues()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)from VenueTbl ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            VenueLbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }


        private void CountExcellent()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from FeedBackTbl where OverAll = " + 4 + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ExcellentLbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }




        private void CountGood()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)from FeedBackTbl where OverAll = " + 3 + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GoodLbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }




        private void CountOK()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)from FeedBackTbl where OverAll = " + 2 + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OkLbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }


        private void CountBad()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)from FeedBackTbl where OverAll = " + 1 + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BadLbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }




        private void Dashboard_Load(object sender, EventArgs e)
        {

        }



        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton30_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton31_Click(object sender, EventArgs e)
        {
            Events obj = new Events();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton34_Click(object sender, EventArgs e)
        {
            Venues obj = new Venues();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton35_Click(object sender, EventArgs e)
        {
            FeedBacks obj = new FeedBacks();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton32_Click(object sender, EventArgs e)
        {
            Pictures obj = new Pictures();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton29_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton33_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            RoleSelection rs = new RoleSelection();
            rs.Show();
            this.Hide();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            OperationsCenter op = new OperationsCenter();
            op.Show();
            this.Hide();
        }
    }
}
