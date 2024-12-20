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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            ShowCustomers();
        }

        private void ShowCustomers()
        {
            con.Open();
            string Query = "Select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];



            con.Close();
        }

        private void Clear()
        {
            CustNameTb.Text = "";
            CustPhoneTb.Text = "";


        }


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0CRP0DE\SQLEXPRESS;Initial Catalog=tbbb;Integrated Security=True");

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CustNameTb.Text == "" || CustPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into CustomerTbl(CustName,CustPhone)values(@CN,@CP)", con);
                    cmd.Parameters.AddWithValue("@CN", CustNameTb.Text);
                    cmd.Parameters.AddWithValue("@CP", CustPhoneTb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    con.Close();


                    ShowCustomers();
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
            if (CustNameTb.Text == "" || CustPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update CustomerTbl Set CustName=@CN,CustPhone=@CP where CustId=@Ckey", con);
                    cmd.Parameters.AddWithValue("@CN", CustNameTb.Text);
                    cmd.Parameters.AddWithValue("@CP", CustPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Ckey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Updated.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    con.Close();


                    ShowCustomers();
                    Clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustNameTb.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustPhoneTb.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();


            if (CustNameTb.Text == "")
            {
                key = 0;
            }

            else
            {
                key = Convert.ToInt32(CustomerDGV.SelectedRows[0].Cells[0].Value.ToString());

            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Customer.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from CustomerTbl Where CustId=@Ckey", con);
                    cmd.Parameters.AddWithValue("@Ckey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    con.Close();


                    ShowCustomers();
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

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {
            Events obj = new Events();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            Venues obj = new Venues();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            FeedBacks obj = new FeedBacks();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            Pictures obj = new Pictures();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            RoleSelection rs = new RoleSelection();
            rs.Show();
            this.Hide();
        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {

            OperationsCenter op = new OperationsCenter();
            op.Show();
            this.Hide();
        }
    }
}
