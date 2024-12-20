using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;

namespace Project
{
    public partial class Hosting : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-0CRP0DE\\SQLEXPRESS;Initial Catalog=tbbb;Integrated Security=True";


        public Hosting()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HostBtn_Click(object sender, EventArgs e)
        {
            if (CnameTb.Text == "" || PhoneTb.Text == "" || EnameTb.Text == "" || VnameTb.Text == "" || Attendee.Text == "" || EdurationTb.Text == "")
            {
                MessageBox.Show("Kindly fill up all the fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string customerName = CnameTb.Text;
                string eventName = EnameTb.Text;
                string venueName = VnameTb.Text;
                int attendeeCount = int.Parse(Attendee.Text);
                string contactNumber = PhoneTb.Text;
                string timeSpan = EdurationTb.Text;
                DateTime eventDate = EDate.Value;


                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();


                    string query = "INSERT INTO HostedEvents (CustomerName, EventName, VenueName, AttendeeCount, ContactNumber, TimeSpan, EventDate, Checked) " +
                                   "VALUES (@CustomerName, @EventName, @VenueName, @AttendeeCount, @ContactNumber, @TimeSpan, @EventDate, 0)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@EventName", eventName);
                        command.Parameters.AddWithValue("@VenueName", venueName);
                        command.Parameters.AddWithValue("@AttendeeCount", attendeeCount);
                        command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        command.Parameters.AddWithValue("@TimeSpan", timeSpan);
                        command.Parameters.AddWithValue("@EventDate", eventDate);

                        command.ExecuteNonQuery();
                    }
                }


                MessageBox.Show("We will reach you within 24 hours. " +
                    "Thank You.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                ClearFormFields();
            }
        }

        private void ClearFormFields()
        {
            CnameTb.Text = "";
            EnameTb.Text = "";
            VnameTb.Text = "";
            Attendee.Text = "";
            PhoneTb.Text = "";
            EdurationTb.Text = "";
            EDate.Value = DateTime.Now;
        }



        private void EDate_ValueChanged(object sender, EventArgs e)
        {
            if (EDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Please select a date equal to or previous than today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EDate.Value = DateTime.Today;
                return;
            }
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            CustomerLogin cuslog = new CustomerLogin();
            this.Hide();
            cuslog.Show();
        }

        private void guna2CircleButton12_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton14_Click(object sender, EventArgs e)
        {
            GiveFeedBacks giveFeedBacks = new GiveFeedBacks();
            this.Hide();
            giveFeedBacks.Show();
        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {
            Showcase show = new Showcase();
            this.Hide();
            show.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RoleSelection rolecust = new RoleSelection();
            this.Hide();
            rolecust.Show();
        }
    }
}
