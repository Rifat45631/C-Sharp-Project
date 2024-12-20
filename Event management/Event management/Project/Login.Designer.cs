namespace Project
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            AdnameTb = new TextBox();
            PasswordTb = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            panel1 = new Panel();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            loginBtn = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            passcheck = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(570, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(32, 176);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 1;
            // 
            // AdnameTb
            // 
            AdnameTb.BackColor = Color.DarkSlateGray;
            AdnameTb.BorderStyle = BorderStyle.FixedSingle;
            AdnameTb.Cursor = Cursors.Hand;
            AdnameTb.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdnameTb.ForeColor = Color.Cornsilk;
            AdnameTb.Location = new Point(206, 305);
            AdnameTb.Name = "AdnameTb";
            AdnameTb.PlaceholderText = "AdminName";
            AdnameTb.Size = new Size(319, 35);
            AdnameTb.TabIndex = 2;
            AdnameTb.TextChanged += textBox1_TextChanged;
            // 
            // PasswordTb
            // 
            PasswordTb.BackColor = Color.DarkSlateGray;
            PasswordTb.BorderStyle = BorderStyle.FixedSingle;
            PasswordTb.Cursor = Cursors.Hand;
            PasswordTb.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTb.ForeColor = Color.Cornsilk;
            PasswordTb.Location = new Point(206, 383);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PlaceholderText = "Password";
            PasswordTb.Size = new Size(319, 35);
            PasswordTb.TabIndex = 3;
            PasswordTb.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 21.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(38, 250);
            label2.Name = "label2";
            label2.Size = new Size(154, 32);
            label2.TabIndex = 5;
            label2.Text = "Give Info:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(38, 366);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(162, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(38, 285);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(162, 77);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Algerian", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(407, 465);
            button2.Name = "button2";
            button2.Size = new Size(61, 37);
            button2.TabIndex = 4;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(guna2CircleButton1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 216);
            panel1.TabIndex = 9;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.Animated = true;
            guna2CircleButton1.BorderColor = Color.DarkSlateGray;
            guna2CircleButton1.Cursor = Cursors.Hand;
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.Transparent;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.HoverState.BorderColor = Color.DarkSlateGray;
            guna2CircleButton1.HoverState.CustomBorderColor = Color.DarkSlateGray;
            guna2CircleButton1.HoverState.FillColor = Color.DarkSlateGray;
            guna2CircleButton1.HoverState.Image = (Image)resources.GetObject("resource.Image");
            guna2CircleButton1.Image = (Image)resources.GetObject("guna2CircleButton1.Image");
            guna2CircleButton1.ImageSize = new Size(30, 30);
            guna2CircleButton1.Location = new Point(526, 10);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(34, 32);
            guna2CircleButton1.TabIndex = 76;
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // loginBtn
            // 
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.DisabledState.BorderColor = Color.DarkGray;
            loginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            loginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            loginBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            loginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            loginBtn.FillColor = Color.Black;
            loginBtn.FillColor2 = Color.Transparent;
            loginBtn.Font = new Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.Cornsilk;
            loginBtn.HoverState.FillColor = Color.Transparent;
            loginBtn.HoverState.FillColor2 = Color.FromArgb(233, 30, 99);
            loginBtn.Location = new Point(257, 428);
            loginBtn.Name = "loginBtn";
            loginBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            loginBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            loginBtn.Size = new Size(106, 106);
            loginBtn.TabIndex = 12;
            loginBtn.Text = "LogIn";
            loginBtn.Click += guna2GradientCircleButton1_Click;
            // 
            // passcheck
            // 
            passcheck.BackColor = Color.DarkSlateGray;
            passcheck.CheckedState.Image = (Image)resources.GetObject("resource.Image1");
            passcheck.Cursor = Cursors.Hand;
            passcheck.HoverState.Image = (Image)resources.GetObject("resource.Image2");
            passcheck.Image = (Image)resources.GetObject("passcheck.Image");
            passcheck.ImageOffset = new Point(0, 0);
            passcheck.ImageRotate = 0F;
            passcheck.Location = new Point(531, 383);
            passcheck.Name = "passcheck";
            passcheck.ShadowDecoration.CustomizableEdges = customizableEdges3;
            passcheck.Size = new Size(29, 35);
            passcheck.TabIndex = 13;
            passcheck.CheckedChanged += passcheck_CheckedChanged;
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Aqua;
            guna2Button1.Cursor = Cursors.Hand;
            guna2Button1.CustomizableEdges = customizableEdges4;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.HoverState.Image = (Image)resources.GetObject("resource.Image3");
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.ImageSize = new Size(40, 40);
            guna2Button1.Location = new Point(525, 466);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.FromArgb(233, 30, 99);
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2Button1.Size = new Size(35, 36);
            guna2Button1.TabIndex = 14;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(572, 546);
            Controls.Add(guna2Button1);
            Controls.Add(passcheck);
            Controls.Add(loginBtn);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(PasswordTb);
            Controls.Add(AdnameTb);
            Controls.Add(label1);
            Cursor = Cursors.PanNW;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox AdnameTb;
        private TextBox PasswordTb;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button2;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton loginBtn;
        private Guna.UI2.WinForms.Guna2ImageCheckBox passcheck;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
