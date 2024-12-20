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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class FeedBacks : Form
    {
        public FeedBacks()
        {
            InitializeComponent();
            Showfeedback();
            GetEvent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Showfeedback()
        {
            con.Open();
            string Query = "Select * from FeedBackTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FeedBackDGV.DataSource = ds.Tables[0];
            con.Close();
        }



        private void Clear()
        {
            EvNameTb.Text = "";
            HospitalityCb.SelectedIndex = -1;
            PunctualityCb.SelectedIndex = -1;
            VenueCb.SelectedIndex = -1;

        }


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0CRP0DE\SQLEXPRESS;Initial Catalog=tbbb;Integrated Security=True");


        private void GetEvent()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Select EvId from EventTbl", con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EvId", typeof(int));
            dt.Load(Rdr);
            EvIdCb.ValueMember = "EvId";
            EvIdCb.DataSource = dt;
            con.Close();

        }

        private void GetEventName()
        {
            con.Open();
            string Query = "Select * from EventTbl where EvId= " + EvIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EvNameTb.Text = dr["EvName"].ToString();

            }

            con.Close();
        }




        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (EvNameTb.Text == "" || VenueCb.SelectedIndex == -1 || HospitalityCb.SelectedIndex == -1 || PunctualityCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int Overall = (HospitalityCb.SelectedIndex + VenueCb.SelectedIndex + PunctualityCb.SelectedIndex + 3) / 3;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into FeedBackTbl(EvId,EVName,Venue,Punctuality,Hospitality,OverAll)values(@EI,@EN,@V,@P,@H,@O)", con);
                    cmd.Parameters.AddWithValue("@EI", EvIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@EN", EvNameTb.Text);
                    cmd.Parameters.AddWithValue("@V", VenueCb.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@P", PunctualityCb.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@H", HospitalityCb.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@O", Overall);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("FeedBack Submited.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    con.Close();


                    Showfeedback();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EvIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetEventName();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void HospitalityCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Clear();

        }








        private void EvNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton23_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton24_Click(object sender, EventArgs e)
        {
            Events obj = new Events();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton27_Click(object sender, EventArgs e)
        {
            Venues obj = new Venues();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton26_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton25_Click(object sender, EventArgs e)
        {
            Pictures obj = new Pictures();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton22_Click(object sender, EventArgs e)
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
