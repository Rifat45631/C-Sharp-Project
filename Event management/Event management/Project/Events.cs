using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project
{
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
            ShowEvents();
            GetVenue();
            GetCustomer();

        }

        private void ShowEvents()
        {
            con.Open();
            string Query = "Select * from EventTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EventDGV.DataSource = ds.Tables[0];
            con.Close();
        }



        private void Clear()
        {
            EvNameTb.Text = "";
            CustNameTb.Text = "";
            EvDurationTb.Text = "";
            StatusCb.SelectedIndex = -1;
            VenueNameTb.Text = "";


        }


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0CRP0DE\SQLEXPRESS;Initial Catalog=tbbb;Integrated Security=True");


        private void GetCustomer()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Select CustId from CustomerTbl", con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(int));
            dt.Load(Rdr);
            CustIdCb.ValueMember = "CustId";
            CustIdCb.DataSource = dt;
            con.Close();

        }

        private void GetCustmerName()
        {
            con.Open();
            string Query = "Select * from CustomerTbl where CustId= " + CustIdCb.SelectedValue.ToString() + "";


            /* for removing the warning from the upper line we can use:

             string Query = "Select * from CustomerTbl where CustId = ";

//(01:Check if CustIdCb.SelectedValue is not null before appending its string representation)
if (CustIdCb.SelectedValue != null)
{
    Query += CustIdCb.SelectedValue.ToString();
}
else
{
    //(02: Handle the case when CustIdCb.SelectedValue is null (e.g., provide a default value)
    Query += "DEFAULT_VALUE"; // Replace "DEFAULT_VALUE" with an appropriate default value or handle as needed
}
            */



            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CustNameTb.Text = dr["CustName"].ToString();

            }

            con.Close();
        }






        private void GetVenue()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Select VId from VenueTbl", con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("VId", typeof(int));
            dt.Load(Rdr);
            EVIdCb.ValueMember = "VId";
            EVIdCb.DataSource = dt;
            con.Close();

        }

        private void GetVenueName()
        {
            con.Open();
            string Query = "Select * from VenueTbl where VId= " + EVIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                VenueNameTb.Text = dr["VName"].ToString();

            }

            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (EvNameTb.Text == "" || VenueNameTb.Text == "" || CustNameTb.Text == "" || EvDurationTb.Text == "" || StatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into EventTbl(EVName,EVDate,VenueId,EVVenue,EVDuration,EVCustId,EVCustName,EVStatus)values(@EN,@ED,@VI,@EV,@EDU,@ECI,@ECN,@ES)", con);
                    cmd.Parameters.AddWithValue("@EN", EvNameTb.Text);
                    cmd.Parameters.AddWithValue("@ED", EvDate.Value.Date);
                    cmd.Parameters.AddWithValue("@VI", EVIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@EV", VenueNameTb.Text);
                    cmd.Parameters.AddWithValue("@EDU", EvDurationTb.Text);
                    cmd.Parameters.AddWithValue("@ECI", CustIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@ECN", CustNameTb.Text);
                    cmd.Parameters.AddWithValue("@ES", StatusCb.SelectedItem.ToString());


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Added.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    con.Close();


                    ShowEvents();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EVIdCb_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void EVIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetVenueName();
        }

        private void CustIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCustmerName();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (EvNameTb.Text == "" || VenueNameTb.Text == "" || CustNameTb.Text == "" || EvDurationTb.Text == "" || StatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update EventTbl Set EVName=@EN ,EVDate=@ED ,VenueId=@VI ,EVVenue=@EV ,EVDuration=@EDU ,EVCustId=@ECI ,EVCustName=@ECN ,EVStatus=@ES where EvId=@Ekey", con);
                    cmd.Parameters.AddWithValue("@EN", EvNameTb.Text);
                    cmd.Parameters.AddWithValue("@ED", EvDate.Value.Date);
                    cmd.Parameters.AddWithValue("@VI", EVIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@EV", VenueNameTb.Text);
                    cmd.Parameters.AddWithValue("@EDU", EvDurationTb.Text);
                    cmd.Parameters.AddWithValue("@ECI", CustIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@ECN", CustNameTb.Text);
                    cmd.Parameters.AddWithValue("@ES", StatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Ekey", key);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Event Updated.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    con.Close();


                    ShowEvents();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int key = 0;
        private void EventDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EvNameTb.Text = EventDGV.SelectedRows[0].Cells[1].Value.ToString();
            EvDate.Text = EventDGV.SelectedRows[0].Cells[2].Value.ToString();
            EVIdCb.Text = EventDGV.SelectedRows[0].Cells[3].Value.ToString();
            VenueNameTb.Text = EventDGV.SelectedRows[0].Cells[4].Value.ToString();
            EvDurationTb.Text = EventDGV.SelectedRows[0].Cells[5].Value.ToString();
            CustIdCb.Text = EventDGV.SelectedRows[0].Cells[6].Value.ToString();
            CustNameTb.Text = EventDGV.SelectedRows[0].Cells[7].Value.ToString();
            StatusCb.Text = EventDGV.SelectedRows[0].Cells[8].Value.ToString();

            if (EvNameTb.Text == "")
            {
                key = 0;
            }

            else
            {
                key = Convert.ToInt32(EventDGV.SelectedRows[0].Cells[0].Value.ToString());

            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Event.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from EventTbl Where EVID=@Ekey", con);
                    cmd.Parameters.AddWithValue("@Ekey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Deleted.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    con.Close();


                    ShowEvents();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }



        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton13_Click(object sender, EventArgs e)
        {
            Venues obj = new Venues();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton14_Click(object sender, EventArgs e)
        {
            FeedBacks obj = new FeedBacks();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton12_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton11_Click(object sender, EventArgs e)
        {
            Pictures obj = new Pictures();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            RoleSelection rs = new RoleSelection();
            rs.Show();
            this.Hide();
        }

        private void EvDate_ValueChanged(object sender, EventArgs e)
        {
            if (EvDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Please select a date equal to or previous than today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EvDate.Value = DateTime.Today;
                return;
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            OperationsCenter op = new OperationsCenter();
            op.Show();
            this.Hide();
        }
    }
}

