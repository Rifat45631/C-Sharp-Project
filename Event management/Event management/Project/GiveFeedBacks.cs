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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class GiveFeedBacks : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-0CRP0DE\\SQLEXPRESS;Initial Catalog=tbbb;Integrated Security=True";
        public GiveFeedBacks()
        {
            InitializeComponent();

        }



        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            CustomerLogin cuslog = new CustomerLogin();
            this.Hide();
            cuslog.Show();
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            if (EVTb.Text == "" || VNTb.Text == "" || CUTb.Text == "" || VCb.SelectedIndex < 0 || HCb.SelectedIndex < 0 || PCb.SelectedIndex < 0)
            {
                MessageBox.Show("Kindly fill up all the fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {

                try
                {
                    string customerName = CUTb.Text;
                    string eventName = EVTb.Text;
                    string venueName = VNTb.Text;
                    DateTime dateTimeValue = DatePick.Value;
                    string venueComboBoxValue = VCb.Text;
                    string punctualityComboBoxValue = PCb.Text;
                    string hospitalityComboBoxValue = HCb.Text;


                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(
                            "INSERT INTO GivenFeedbacks (CustomerName, EventName, VenueName, DateTimePickerValue, VenueComboBoxValue, PunctualityComboBoxValue, HospitalityComboBoxValue, Checked) " +
                            "VALUES (@CustomerName, @EventName, @VenueName, @DateTimePickerValue, @VenueComboBoxValue, @PunctualityComboBoxValue, @HospitalityComboBoxValue, 0)", connection))
                        {
                            command.Parameters.AddWithValue("@CustomerName", customerName);
                            command.Parameters.AddWithValue("@EventName", eventName);
                            command.Parameters.AddWithValue("@VenueName", venueName);
                            command.Parameters.AddWithValue("@DateTimePickerValue", dateTimeValue);
                            command.Parameters.AddWithValue("@VenueComboBoxValue", venueComboBoxValue);
                            command.Parameters.AddWithValue("@PunctualityComboBoxValue", punctualityComboBoxValue);
                            command.Parameters.AddWithValue("@HospitalityComboBoxValue", hospitalityComboBoxValue);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Feedback submitted successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error submitting feedback. Please try again.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void guna2CircleButton10_Click(object sender, EventArgs e)
        {
            Hosting ho = new Hosting();
            this.Hide();
            ho.Show();
        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {
            Showcase show = new Showcase();
            this.Hide();
            show.Show();
        }

        private void DatePick_ValueChanged(object sender, EventArgs e)
        {

            if (DatePick.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Please select a date equal to or previous than today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DatePick.Value = DateTime.Today;
                return;
            }
        }

        private void guna2CircleButton14_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RoleSelection rolecust = new RoleSelection();
            this.Hide();
            rolecust.Show();
        }
    }
}

