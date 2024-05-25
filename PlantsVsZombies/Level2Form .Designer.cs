namespace PlantsVsZombies
{
    partial class Level2Form
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ClickPlant = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LevelCompletionBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.levelBarIconPb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SunCountlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SunDroper = new System.Windows.Forms.Timer(this.components);
            this.GenerateSunTimer = new System.Windows.Forms.Timer(this.components);
            this.fireBullet = new System.Windows.Forms.Timer(this.components);
            this.GenerateFire = new System.Windows.Forms.Timer(this.components);
            this.GeneratePlant = new System.Windows.Forms.Timer(this.components);
            this.ZombiesMovement = new System.Windows.Forms.Timer(this.components);
            this.GemeOverChecker = new System.Windows.Forms.Timer(this.components);
            this.ZombieHealth = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.Flag = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PlayPuaseBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClickPlant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelBarIconPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPuaseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox1.Image = global::PlantsVsZombies.Properties.Resources.CloseBtn1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(746, -7);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 3;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox1.FillColor = System.Drawing.Color.Empty;
            this.PictureBox1.ImageRotate = 0F;
            this.PictureBox1.Location = new System.Drawing.Point(199, 65);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(64, 54);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 4;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.UseTransparentBackground = true;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox2.FillColor = System.Drawing.Color.Empty;
            this.PictureBox2.ImageRotate = 0F;
            this.PictureBox2.Location = new System.Drawing.Point(199, 134);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(64, 53);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 5;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.UseTransparentBackground = true;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox3.FillColor = System.Drawing.Color.Empty;
            this.PictureBox3.ImageRotate = 0F;
            this.PictureBox3.Location = new System.Drawing.Point(199, 204);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(64, 55);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 6;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.UseTransparentBackground = true;
            this.PictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // PictureBox4
            // 
            this.PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox4.FillColor = System.Drawing.Color.Empty;
            this.PictureBox4.ImageRotate = 0F;
            this.PictureBox4.Location = new System.Drawing.Point(199, 265);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(64, 63);
            this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox4.TabIndex = 7;
            this.PictureBox4.TabStop = false;
            this.PictureBox4.UseTransparentBackground = true;
            this.PictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // PictureBox5
            // 
            this.PictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox5.FillColor = System.Drawing.Color.Empty;
            this.PictureBox5.ImageRotate = 0F;
            this.PictureBox5.Location = new System.Drawing.Point(199, 346);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(64, 53);
            this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox5.TabIndex = 8;
            this.PictureBox5.TabStop = false;
            this.PictureBox5.UseTransparentBackground = true;
            this.PictureBox5.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Empty;
            this.guna2PictureBox1.Image = global::PlantsVsZombies.Properties.Resources.PvZ_iOS_unused_sun_bank;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(103, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(108, 42);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // ClickPlant
            // 
            this.ClickPlant.BackColor = System.Drawing.Color.Transparent;
            this.ClickPlant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClickPlant.FillColor = System.Drawing.Color.Empty;
            this.ClickPlant.Image = global::PlantsVsZombies.Properties.Resources.Snow_Pea_New_Premium_Seed_Packet;
            this.ClickPlant.ImageRotate = 0F;
            this.ClickPlant.Location = new System.Drawing.Point(43, 48);
            this.ClickPlant.Name = "ClickPlant";
            this.ClickPlant.Size = new System.Drawing.Size(64, 50);
            this.ClickPlant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClickPlant.TabIndex = 10;
            this.ClickPlant.TabStop = false;
            this.ClickPlant.UseTransparentBackground = true;
            this.ClickPlant.Click += new System.EventHandler(this.ClickPlant_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Empty;
            this.guna2PictureBox3.Image = global::PlantsVsZombies.Properties.Resources.LevelBarTrans1;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(281, 0);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(355, 32);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 11;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // LevelCompletionBar
            // 
            this.LevelCompletionBar.FillColor = System.Drawing.Color.Black;
            this.LevelCompletionBar.Location = new System.Drawing.Point(300, 11);
            this.LevelCompletionBar.Name = "LevelCompletionBar";
            this.LevelCompletionBar.Size = new System.Drawing.Size(320, 10);
            this.LevelCompletionBar.TabIndex = 12;
            this.LevelCompletionBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // levelBarIconPb
            // 
            this.levelBarIconPb.BackColor = System.Drawing.Color.Transparent;
            this.levelBarIconPb.FillColor = System.Drawing.Color.Empty;
            this.levelBarIconPb.Image = global::PlantsVsZombies.Properties.Resources.Pvzmobileogdancings;
            this.levelBarIconPb.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.levelBarIconPb.ImageRotate = 0F;
            this.levelBarIconPb.Location = new System.Drawing.Point(291, -7);
            this.levelBarIconPb.Name = "levelBarIconPb";
            this.levelBarIconPb.Size = new System.Drawing.Size(36, 42);
            this.levelBarIconPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.levelBarIconPb.TabIndex = 13;
            this.levelBarIconPb.TabStop = false;
            this.levelBarIconPb.UseTransparentBackground = true;
            // 
            // SunCountlb
            // 
            this.SunCountlb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SunCountlb.AutoSize = false;
            this.SunCountlb.BackColor = System.Drawing.Color.Transparent;
            this.SunCountlb.BackgroundImage = global::PlantsVsZombies.Properties.Resources.countback;
            this.SunCountlb.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunCountlb.Location = new System.Drawing.Point(140, 7);
            this.SunCountlb.Name = "SunCountlb";
            this.SunCountlb.Size = new System.Drawing.Size(57, 25);
            this.SunCountlb.TabIndex = 14;
            this.SunCountlb.Text = "500";
            this.SunCountlb.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SunDroper
            // 
            this.SunDroper.Enabled = true;
            this.SunDroper.Interval = 20;
            this.SunDroper.Tick += new System.EventHandler(this.SunDroper_Tick);
            // 
            // GenerateSunTimer
            // 
            this.GenerateSunTimer.Enabled = true;
            this.GenerateSunTimer.Interval = 6000;
            this.GenerateSunTimer.Tick += new System.EventHandler(this.GenerateSunTimer_Tick);
            // 
            // fireBullet
            // 
            this.fireBullet.Enabled = true;
            this.fireBullet.Interval = 20;
            this.fireBullet.Tick += new System.EventHandler(this.GenerateBulletTimer_Tick);
            // 
            // GenerateFire
            // 
            this.GenerateFire.Enabled = true;
            this.GenerateFire.Interval = 1300;
            this.GenerateFire.Tick += new System.EventHandler(this.BulletFires_Tick);
            // 
            // GeneratePlant
            // 
            this.GeneratePlant.Enabled = true;
            this.GeneratePlant.Interval = 20;
            this.GeneratePlant.Tick += new System.EventHandler(this.PlantGeneratorTimer);
            // 
            // ZombiesMovement
            // 
            this.ZombiesMovement.Enabled = true;
            this.ZombiesMovement.Interval = 20;
            this.ZombiesMovement.Tick += new System.EventHandler(this.ZombiesMovement_Tick);
            // 
            // GemeOverChecker
            // 
            this.GemeOverChecker.Enabled = true;
            this.GemeOverChecker.Interval = 500;
            this.GemeOverChecker.Tick += new System.EventHandler(this.GameOverChecker_Tick);
            // 
            // ZombieHealth
            // 
            this.ZombieHealth.FillColor = System.Drawing.Color.Transparent;
            this.ZombieHealth.Location = new System.Drawing.Point(1, 11);
            this.ZombieHealth.Name = "ZombieHealth";
            this.ZombieHealth.Size = new System.Drawing.Size(0, 0);
            this.ZombieHealth.TabIndex = 15;
            this.ZombieHealth.Text = "guna2ProgressBar1";
            this.ZombieHealth.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ZombieHealth.Value = 100;
            // 
            // Flag
            // 
            this.Flag.BackColor = System.Drawing.Color.Transparent;
            this.Flag.Image = global::PlantsVsZombies.Properties.Resources.flag;
            this.Flag.ImageRotate = 0F;
            this.Flag.Location = new System.Drawing.Point(616, 0);
            this.Flag.Name = "Flag";
            this.Flag.Size = new System.Drawing.Size(30, 26);
            this.Flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flag.TabIndex = 16;
            this.Flag.TabStop = false;
            this.Flag.UseTransparentBackground = true;
            // 
            // PlayPuaseBtn
            // 
            this.PlayPuaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayPuaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayPuaseBtn.Image = global::PlantsVsZombies.Properties.Resources.Pause;
            this.PlayPuaseBtn.ImageRotate = 0F;
            this.PlayPuaseBtn.Location = new System.Drawing.Point(678, 1);
            this.PlayPuaseBtn.Name = "PlayPuaseBtn";
            this.PlayPuaseBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PlayPuaseBtn.Size = new System.Drawing.Size(46, 41);
            this.PlayPuaseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayPuaseBtn.TabIndex = 17;
            this.PlayPuaseBtn.TabStop = false;
            this.PlayPuaseBtn.UseTransparentBackground = true;
            this.PlayPuaseBtn.Click += new System.EventHandler(this.PlayPuaseBtn_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Red;
            this.guna2VSeparator1.Location = new System.Drawing.Point(260, 40);
            this.guna2VSeparator1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 366);
            this.guna2VSeparator1.TabIndex = 19;
            // 
            // Level2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlantsVsZombies.Properties.Resources.Player_s_House;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.PlayPuaseBtn);
            this.Controls.Add(this.Flag);
            this.Controls.Add(this.ZombieHealth);
            this.Controls.Add(this.SunCountlb);
            this.Controls.Add(this.levelBarIconPb);
            this.Controls.Add(this.LevelCompletionBar);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.ClickPlant);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.PictureBox5);
            this.Controls.Add(this.PictureBox4);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Level2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level1Form";
            this.Load += new System.EventHandler(this.Level1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClickPlant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelBarIconPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPuaseBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox5;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox4;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox ClickPlant;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2ProgressBar LevelCompletionBar;
        private Guna.UI2.WinForms.Guna2PictureBox levelBarIconPb;
        private Guna.UI2.WinForms.Guna2HtmlLabel SunCountlb;
        private System.Windows.Forms.Timer SunDroper;
        private System.Windows.Forms.Timer GenerateSunTimer;
        private System.Windows.Forms.Timer fireBullet;
        private System.Windows.Forms.Timer GenerateFire;
        private System.Windows.Forms.Timer GeneratePlant;
        private System.Windows.Forms.Timer ZombiesMovement;
        private System.Windows.Forms.Timer GemeOverChecker;
        private Guna.UI2.WinForms.Guna2ProgressBar ZombieHealth;
        private Guna.UI2.WinForms.Guna2PictureBox Flag;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PlayPuaseBtn;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
    }
}