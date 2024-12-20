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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class Pictures : Form
    {
        public Pictures()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0CRP0DE\SQLEXPRESS;Initial Catalog=tbbb;Integrated Security=True");

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton37_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton38_Click(object sender, EventArgs e)
        {
            Events obj = new Events();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton41_Click(object sender, EventArgs e)
        {
            Venues obj = new Venues();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton42_Click(object sender, EventArgs e)
        {
            FeedBacks obj = new FeedBacks();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton40_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void guna2CircleButton36_Click(object sender, EventArgs e)
        {
            RoleSelection rs = new RoleSelection();
            rs.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (EVDATE.Value.Date > DateTime.Now.Date)
            {

                MessageBox.Show("Please select a date equal to or previous than today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EVDATE.Value = DateTime.Today;
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "ALL IMAGE FILE (*.*) | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PICTURE.Image = new Bitmap(ofd.FileName);
            }

        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            if (EVID.Text == "" || EVNAME.Text == "" || PICTURE.Image == null)
            {
                MessageBox.Show("Missing Information.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert Into Pics(EvId,EvName,EvDate,Image)Values (@EvId,@EvName,@EvDate,@Image) ", conn);
                cmd.Parameters.AddWithValue("@EvId", EVID.Text); // Corrected parameter name
                cmd.Parameters.AddWithValue("@EvName", EVNAME.Text);
                cmd.Parameters.AddWithValue("@EvDate", EVDATE.Value.Date);

                using (MemoryStream memstr = new MemoryStream())
                {
                    PICTURE.Image.Save(memstr, PICTURE.Image.RawFormat);
                    cmd.Parameters.AddWithValue("@Image", memstr.ToArray());
                }

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                load_data();
            }
        }
        private void load_data()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Pics order by No asc", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            DGV.RowTemplate.Height = 100;
            DGV.DataSource = dt;
            DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
            pic1 = (DataGridViewImageColumn)DGV.Columns[4];
            pic1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            conn.Close();
        }

        private void Pictures_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void DGV_Click(object sender, EventArgs e)
        {
            id1.Text = DGV.CurrentRow.Cells[0].Value.ToString();
            EVID.Text = DGV.CurrentRow.Cells[1].Value.ToString(); ;
            EVNAME.Text = DGV.CurrentRow.Cells[2].Value.ToString(); ;
            EVDATE.Text = DGV.CurrentRow.Cells[3].Value.ToString();

            byte[] imageBytes = (byte[])DGV.CurrentRow.Cells[4].Value;

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                PICTURE.Image = Image.FromStream(ms);
            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {

            if (EVID.Text == "" || EVNAME.Text == "" || PICTURE.Image == null)
            {
                MessageBox.Show("Missing Information.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update Pics Set EvId=@EvId ,EvName=@EvName ,EvDate=@EvDate ,Image= @Image where No=@No", conn);
                cmd.Parameters.AddWithValue("EvId", EVID.Text);
                cmd.Parameters.AddWithValue("EvName", EVNAME.Text);
                cmd.Parameters.AddWithValue("EvDate", EVDATE.Value.Date);
                cmd.Parameters.AddWithValue("No", id1.Text);
                MemoryStream memstr = new MemoryStream();
                PICTURE.Image.Save(memstr, PICTURE.Image.RawFormat);
                cmd.Parameters.AddWithValue("Image", memstr.ToArray());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                load_data();
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {

            if (EVID.Text == "" || EVNAME.Text == "" || PICTURE.Image == null)
            {
                MessageBox.Show("Missing Information.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from Pics where No=@No", conn);
                cmd.Parameters.AddWithValue("No", id1.Text);
                cmd.ExecuteNonQuery();
                EVID.Text = "";
                EVNAME.Text = "";
                EVDATE.Value = DateTime.Today;
                id1.Text = "";
                PICTURE.Image = null;
                MessageBox.Show("Data Deleted successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                load_data();
            }

        }

        private void RESET_Click(object sender, EventArgs e)
        {
            EVID.Text = string.Empty;
            EVNAME.Text = string.Empty;
            EVDATE.Value = DateTime.Today;
            PICTURE.Image = null;
        }

        private void PICTURE_Click(object sender, EventArgs e)
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
