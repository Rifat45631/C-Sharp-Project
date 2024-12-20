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
    public partial class Venues : Form
    {
        public Venues()
        {
            InitializeComponent();
            ShowVenue();
        }
        private void ShowVenue()
        {
            con.Open();
            string Query = "Select * from VenueTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VenueDGV.DataSource = ds.Tables[0];



            con.Close();
        }

        private void Clear()
        {
            VNameTb.Text = "";
            VPhoneTb.Text = "";
            VCapacityTb.Text = "";
            VAddressTb.Text = "";
            VManagerTb.Text = "";


        }


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0CRP0DE\SQLEXPRESS;Initial Catalog=tbbb;Integrated Security=True");

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (VAddressTb.Text == "" || VNameTb.Text == "" || VPhoneTb.Text == "" || VCapacityTb.Text == "" || VManagerTb.Text == "")
            {
                MessageBox.Show("Missing Information.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into VenueTbl(VName,VCapacity,VAddress,VManager,VPhone)values(@VN,@VC,@VA,@VM,@Vp)", con);
                    cmd.Parameters.AddWithValue("@VN", VNameTb.Text);
                    cmd.Parameters.AddWithValue("@VC", VCapacityTb.Text);
                    cmd.Parameters.AddWithValue("@VA", VAddressTb.Text);
                    cmd.Parameters.AddWithValue("@VM", VManagerTb.Text);
                    cmd.Parameters.AddWithValue("@VP", VPhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Venue Added.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    con.Close();


                    ShowVenue();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int key = 0;
        private void VenueDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VNameTb.Text = VenueDGV.SelectedRows[0].Cells[1].Value.ToString();
            VCapacityTb.Text = VenueDGV.SelectedRows[0].Cells[2].Value.ToString();
            VAddressTb.Text = VenueDGV.SelectedRows[0].Cells[3].Value.ToString();
            VManagerTb.Text = VenueDGV.SelectedRows[0].Cells[4].Value.ToString();
            VPhoneTb.Text = VenueDGV.SelectedRows[0].Cells[5].Value.ToString();

            if (VNameTb.Text == "")
            {
                key = 0;
            }

            else
            {
                key = Convert.ToInt32(VenueDGV.SelectedRows[0].Cells[0].Value.ToString());

            }




        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Venue.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from VenueTbl Where VID=@Vkey", con);
                    cmd.Parameters.AddWithValue("@Vkey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Venue Deleted.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    con.Close();


                    ShowVenue();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }





        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            if (VAddressTb.Text == "" || VNameTb.Text == "" || VPhoneTb.Text == "" || VCapacityTb.Text == "" || VManagerTb.Text == "")
            {
                MessageBox.Show("Missing Information.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update VenueTbl Set VName=@VN,VCapacity=@VC,VAddress=@VA,VManager=@VM,VPhone=@Vp where VID=@Vkey", con);
                    cmd.Parameters.AddWithValue("@VN", VNameTb.Text);
                    cmd.Parameters.AddWithValue("@VC", VCapacityTb.Text);
                    cmd.Parameters.AddWithValue("@VA", VAddressTb.Text);
                    cmd.Parameters.AddWithValue("@VM", VManagerTb.Text);
                    cmd.Parameters.AddWithValue("@VP", VPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Vkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Venue Updated.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    con.Close();


                    ShowVenue();
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

        private void guna2CircleButton16_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton17_Click(object sender, EventArgs e)
        {
            Events obj = new Events();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton21_Click(object sender, EventArgs e)
        {
            FeedBacks obj = new FeedBacks();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton19_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton18_Click(object sender, EventArgs e)
        {
            Pictures obj = new Pictures();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton15_Click(object sender, EventArgs e)
        {
            RoleSelection rs = new RoleSelection();
            rs.Show();
            this.Hide();
        }

        private void guna2CircleButton20_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            OperationsCenter op = new OperationsCenter();
            op.Show();
            this.Hide();
        }
    }
}
