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
    public partial class CustomerLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0CRP0DE\SQLEXPRESS;Initial Catalog=tbbb;Integrated Security=True");
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RoleSelection rolecust = new RoleSelection();
            this.Hide();
            rolecust.Show();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passcheck_CheckedChanged(object sender, EventArgs e)
        {
            bool status = passcheck.Checked;
            switch (status)
            {
                case true:
                    CustloginpassTb.UseSystemPasswordChar = false;
                    break;
                default:
                    CustloginpassTb.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustloginnameTb.Text = "";
            CustloginpassTb.Text = "";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (CustloginnameTb.Text == "" || CustloginpassTb.Text == "")
            {
                MessageBox.Show("Enter Both: UserName & Password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if(con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();


                        string TakeData = "SELECT * FROM SignupCust WHERE customername=@custname  AND Customerpass =@pass";
                        using (SqlCommand cmd= new SqlCommand(TakeData, con))
                        {
                            cmd.Parameters.AddWithValue("@custname", CustloginnameTb.Text);
                            cmd.Parameters.AddWithValue("@pass", CustloginpassTb.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);


                            if(dt.Rows.Count >= 1)
                            {
                                Hosting hosting = new Hosting();
                                this.Hide();
                                hosting.Show();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect CustomerName or Password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }





                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally 
                    {
                    con.Close();
                    }
                }
            }
            
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            this.Hide();
            sign.Show();
        }
    }
}
