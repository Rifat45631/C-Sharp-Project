using Guna.UI2.WinForms;

namespace Project
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            AdnameTb.Text = "";
            PasswordTb.Text = "";
        }



        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            if (AdnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter Both: UserName & Password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (AdnameTb.Text == "admin" && PasswordTb.Text == "password")
            {
                OperationsCenter opcen = new OperationsCenter();
                opcen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName Or Password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passcheck_CheckedChanged(object sender, EventArgs e)
        {
            bool status = passcheck.Checked;
            switch (status)
            {
                case true:
                    PasswordTb.UseSystemPasswordChar = false;
                    break;
                default:
                    PasswordTb.UseSystemPasswordChar = true;
                    break;
            }
        }




        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          RoleSelection role = new RoleSelection();
          this.Hide();
          role.Show();
        }
    }
}

