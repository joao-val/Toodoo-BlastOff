namespace Sorteio_Toodoo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Toodoo_Jpg = new System.Windows.Forms.PictureBox();
            this.toolboxPanel = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.List_Button = new System.Windows.Forms.Button();
            this.Raffle_Button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBoxWinners = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textWinners = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.winnersGif = new System.Windows.Forms.PictureBox();
            this.congratulations = new System.Windows.Forms.PictureBox();
            this.homePage = new System.Windows.Forms.PictureBox();
            this.repeated = new System.Windows.Forms.PictureBox();
            this.countdown = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Toodoo_Jpg)).BeginInit();
            this.toolboxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnersGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congratulations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countdown)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.Toodoo_Jpg);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(743, 76);
            this.topPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Raffle Application";
            // 
            // Toodoo_Jpg
            // 
            this.Toodoo_Jpg.Image = ((System.Drawing.Image)(resources.GetObject("Toodoo_Jpg.Image")));
            this.Toodoo_Jpg.Location = new System.Drawing.Point(0, -2);
            this.Toodoo_Jpg.Name = "Toodoo_Jpg";
            this.Toodoo_Jpg.Size = new System.Drawing.Size(77, 84);
            this.Toodoo_Jpg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Toodoo_Jpg.TabIndex = 1;
            this.Toodoo_Jpg.TabStop = false;
            // 
            // toolboxPanel
            // 
            this.toolboxPanel.BackColor = System.Drawing.Color.Blue;
            this.toolboxPanel.Controls.Add(this.btnHome);
            this.toolboxPanel.Controls.Add(this.List_Button);
            this.toolboxPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolboxPanel.Location = new System.Drawing.Point(0, 76);
            this.toolboxPanel.Name = "toolboxPanel";
            this.toolboxPanel.Size = new System.Drawing.Size(77, 475);
            this.toolboxPanel.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Orange;
            this.btnHome.Location = new System.Drawing.Point(0, 14);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(77, 44);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home Page";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // List_Button
            // 
            this.List_Button.BackColor = System.Drawing.Color.Black;
            this.List_Button.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.List_Button.ForeColor = System.Drawing.Color.Orange;
            this.List_Button.Location = new System.Drawing.Point(0, 103);
            this.List_Button.Name = "List_Button";
            this.List_Button.Size = new System.Drawing.Size(77, 44);
            this.List_Button.TabIndex = 0;
            this.List_Button.Text = "Winners List";
            this.List_Button.UseVisualStyleBackColor = false;
            this.List_Button.Click += new System.EventHandler(this.list_button_Click);
            // 
            // Raffle_Button
            // 
            this.Raffle_Button.BackColor = System.Drawing.Color.Black;
            this.Raffle_Button.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Raffle_Button.ForeColor = System.Drawing.Color.Orange;
            this.Raffle_Button.Location = new System.Drawing.Point(217, 96);
            this.Raffle_Button.Name = "Raffle_Button";
            this.Raffle_Button.Size = new System.Drawing.Size(396, 30);
            this.Raffle_Button.TabIndex = 0;
            this.Raffle_Button.Text = "Raffle";
            this.Raffle_Button.UseVisualStyleBackColor = false;
            this.Raffle_Button.Click += new System.EventHandler(this.Raffle_Button_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBoxWinners
            // 
            this.listBoxWinners.BackColor = System.Drawing.Color.Orange;
            this.listBoxWinners.Font = new System.Drawing.Font("Snap ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxWinners.FormattingEnabled = true;
            this.listBoxWinners.ItemHeight = 19;
            this.listBoxWinners.Location = new System.Drawing.Point(225, 421);
            this.listBoxWinners.Name = "listBoxWinners";
            this.listBoxWinners.Size = new System.Drawing.Size(380, 99);
            this.listBoxWinners.TabIndex = 10;
            this.listBoxWinners.SelectedIndexChanged += new System.EventHandler(this.listBoxWinners_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(611, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // textWinners
            // 
            this.textWinners.AutoSize = true;
            this.textWinners.BackColor = System.Drawing.Color.Black;
            this.textWinners.Font = new System.Drawing.Font("Algerian", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textWinners.ForeColor = System.Drawing.Color.Coral;
            this.textWinners.Location = new System.Drawing.Point(365, 102);
            this.textWinners.Name = "textWinners";
            this.textWinners.Size = new System.Drawing.Size(108, 18);
            this.textWinners.TabIndex = 12;
            this.textWinners.Text = "The Winners";
            this.textWinners.Click += new System.EventHandler(this.textWinners_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardInputEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // winnersGif
            // 
            this.winnersGif.Image = ((System.Drawing.Image)(resources.GetObject("winnersGif.Image")));
            this.winnersGif.Location = new System.Drawing.Point(225, 138);
            this.winnersGif.Name = "winnersGif";
            this.winnersGif.Size = new System.Drawing.Size(380, 264);
            this.winnersGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winnersGif.TabIndex = 13;
            this.winnersGif.TabStop = false;
            this.winnersGif.Click += new System.EventHandler(this.winnersGif_Click);
            // 
            // congratulations
            // 
            this.congratulations.Image = ((System.Drawing.Image)(resources.GetObject("congratulations.Image")));
            this.congratulations.Location = new System.Drawing.Point(225, 138);
            this.congratulations.Name = "congratulations";
            this.congratulations.Size = new System.Drawing.Size(380, 264);
            this.congratulations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.congratulations.TabIndex = 14;
            this.congratulations.TabStop = false;
            this.congratulations.Click += new System.EventHandler(this.congratulations_Click);
            // 
            // homePage
            // 
            this.homePage.Image = ((System.Drawing.Image)(resources.GetObject("homePage.Image")));
            this.homePage.Location = new System.Drawing.Point(225, 138);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(380, 277);
            this.homePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homePage.TabIndex = 16;
            this.homePage.TabStop = false;
            this.homePage.Click += new System.EventHandler(this.homePage_Click);
            // 
            // repeated
            // 
            this.repeated.Image = ((System.Drawing.Image)(resources.GetObject("repeated.Image")));
            this.repeated.Location = new System.Drawing.Point(225, 138);
            this.repeated.Name = "repeated";
            this.repeated.Size = new System.Drawing.Size(380, 277);
            this.repeated.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.repeated.TabIndex = 17;
            this.repeated.TabStop = false;
            this.repeated.Click += new System.EventHandler(this.repeated_Click);
            // 
            // countdown
            // 
            this.countdown.Image = ((System.Drawing.Image)(resources.GetObject("countdown.Image")));
            this.countdown.Location = new System.Drawing.Point(225, 138);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(380, 277);
            this.countdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.countdown.TabIndex = 18;
            this.countdown.TabStop = false;
            this.countdown.Click += new System.EventHandler(this.countdown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(743, 551);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.congratulations);
            this.Controls.Add(this.winnersGif);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxWinners);
            this.Controls.Add(this.Raffle_Button);
            this.Controls.Add(this.toolboxPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.textWinners);
            this.Controls.Add(this.repeated);
            this.Controls.Add(this.countdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Toodoo_Jpg)).EndInit();
            this.toolboxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winnersGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congratulations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Toodoo_Jpg;
        private System.Windows.Forms.Panel toolboxPanel;
        private System.Windows.Forms.Button List_Button;
        private System.Windows.Forms.Button Raffle_Button;
        protected System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBoxWinners;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label textWinners;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.PictureBox winnersGif;
        private System.Windows.Forms.PictureBox congratulations;
        private System.Windows.Forms.PictureBox homePage;
        private System.Windows.Forms.PictureBox repeated;
        private System.Windows.Forms.PictureBox countdown;
    }
}
