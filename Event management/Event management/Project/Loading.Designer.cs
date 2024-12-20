namespace Project
{
    partial class Loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            pbar = new CircularProgressBar_NET5.CircularProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pbar
            // 
            pbar.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            pbar.AnimationSpeed = 400;
            pbar.BackColor = Color.Transparent;
            pbar.Font = new Font("Algerian", 42F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pbar.ForeColor = Color.FromArgb(233, 30, 99);
            pbar.InnerColor = Color.Transparent;
            pbar.InnerMargin = 3;
            pbar.InnerWidth = 0;
            pbar.Location = new Point(199, 151);
            pbar.MarqueeAnimationSpeed = 10000;
            pbar.Name = "pbar";
            pbar.OuterColor = Color.Teal;
            pbar.OuterMargin = -25;
            pbar.OuterWidth = 25;
            pbar.ProgressColor = Color.FromArgb(233, 30, 99);
            pbar.ProgressWidth = 10;
            pbar.SecondaryFont = new Font("Algerian", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pbar.Size = new Size(173, 181);
            pbar.StartAngle = 270;
            pbar.Style = ProgressBarStyle.Continuous;
            pbar.SubscriptColor = Color.FromArgb(166, 166, 166);
            pbar.SubscriptMargin = new Padding(10, -35, 0, 0);
            pbar.SubscriptText = "";
            pbar.SuperscriptColor = Color.FromArgb(166, 166, 166);
            pbar.SuperscriptMargin = new Padding(10, 35, 0, 0);
            pbar.SuperscriptText = "";
            pbar.TabIndex = 0;
            pbar.TextMargin = new Padding(8, 8, 0, 0);
            pbar.UseWaitCursor = true;
            pbar.Value = 68;
            pbar.Click += circularProgressBar1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 240);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(509, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(219, 299);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Teal;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Algerian", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Cornsilk;
            label6.Location = new Point(119, 625);
            label6.Name = "label6";
            label6.Size = new Size(308, 23);
            label6.TabIndex = 67;
            label6.Text = "Meet the Dream Team: \"G14\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Algerian", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(233, 30, 99);
            label1.Location = new Point(29, 648);
            label1.Name = "label1";
            label1.Size = new Size(472, 17);
            label1.TabIndex = 67;
            label1.Text = "\"In Collaboration with Rifat Arafin, Ahsanul Azmain, Faisal Ahmed\"";
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(539, 670);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(pbar);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            Load += Loading_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CircularProgressBar_NET5.CircularProgressBar pbar;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label1;
    }
}