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
using Xamarin.Essentials;

namespace Project
{
    public partial class SignUp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0CRP0DE\SQLEXPRESS;Initial Catalog=tbbb;Integrated Security=True");
        public SignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustsignupnameTb.Text = "";
            CustsignupemailTb.Text = "";
            CustsignuppassTb.Text = "";
        }

        private void CustloginBtn_Click(object sender, EventArgs e)
        {
            CustomerLogin customerlog = new CustomerLogin();
            this.Hide();
            customerlog.Show();
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
                    CustsignuppassTb.UseSystemPasswordChar = false;
                    break;
                default:
                    CustsignuppassTb.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (CustsignupnameTb.Text == "" || CustsignupemailTb.Text == "" || CustsignuppassTb.Text == "")
            {
                MessageBox.Show("Please Fill All The Blank Fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                        string checkCustomername = "SELECT * FROM SignupCust WHERE customername = '"
                            + CustsignupnameTb.Text.Trim() + "'";

                        using (SqlCommand checkCustomer = new SqlCommand(checkCustomername, con))
                        {
                            SqlDataAdapter ada = new SqlDataAdapter(checkCustomer);
                            DataTable dt = new DataTable();
                            ada.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                MessageBox.Show(CustsignupnameTb.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO SignupCust (email,customername,Customerpass,Date_created) VALUES(@email,@customername,@pass,@date)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, con))
                                {
                                    cmd.Parameters.AddWithValue("@email", CustsignupemailTb.Text.Trim());
                                    cmd.Parameters.AddWithValue("@customername", CustsignupnameTb.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", CustsignuppassTb.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show(" Signed-up Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    CustomerLogin customerlogin = new CustomerLogin();
                                    this.Hide();
                                    customerlogin.Show();

                                }

                            }


                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connectiong Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }


                }
            }
        }

        private void CustsignupnameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
