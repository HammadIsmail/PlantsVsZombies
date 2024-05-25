namespace PlantsVsZombies
{
    partial class GameOverForm
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
            this.TryAgainBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MainMenuBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TryAgainBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // TryAgainBtn
            // 
            this.TryAgainBtn.BackColor = System.Drawing.Color.Transparent;
            this.TryAgainBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TryAgainBtn.FillColor = System.Drawing.Color.Empty;
            this.TryAgainBtn.ImageRotate = 0F;
            this.TryAgainBtn.Location = new System.Drawing.Point(275, 278);
            this.TryAgainBtn.Name = "TryAgainBtn";
            this.TryAgainBtn.Size = new System.Drawing.Size(117, 34);
            this.TryAgainBtn.TabIndex = 0;
            this.TryAgainBtn.TabStop = false;
            this.TryAgainBtn.UseTransparentBackground = true;
            this.TryAgainBtn.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuBtn.FillColor = System.Drawing.Color.Empty;
            this.MainMenuBtn.ImageRotate = 0F;
            this.MainMenuBtn.Location = new System.Drawing.Point(407, 278);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(111, 34);
            this.MainMenuBtn.TabIndex = 1;
            this.MainMenuBtn.TabStop = false;
            this.MainMenuBtn.UseTransparentBackground = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click);
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlantsVsZombies.Properties.Resources.Screenshotter__YouTube_PlantsVSZombies1GameOver_0_13_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.TryAgainBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameOverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOverForm";
            ((System.ComponentModel.ISupportInitialize)(this.TryAgainBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox TryAgainBtn;
        private Guna.UI2.WinForms.Guna2PictureBox MainMenuBtn;
    }
}