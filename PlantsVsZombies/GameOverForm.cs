using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantsVsZombies
{
    public partial class GameOverForm : Form
    {
        int LevelNo;
        public GameOverForm(int LevelNo)
        {
            InitializeComponent();
            this.LevelNo = LevelNo;
        }
        public  void tryAgain()
        {
            if (LevelNo==1)
            {
                Level1Form tryAgain = new Level1Form();
                Application.Run(tryAgain);
            }
            if (LevelNo == 2)
            {
                Level2Form tryAgain = new Level2Form();
                Application.Run(tryAgain);
            }
            if (LevelNo == 3)
            {
                Level3Form tryAgain = new Level3Form();
                Application.Run(tryAgain);
            }

        }
        public static void Menu()
        {
            LevelScreenForm Menu = new LevelScreenForm();
            Application.Run(Menu);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(tryAgain));
            thread.Start();
            this.Close();

        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(Menu));
            thread.Start();
            this.Close();
        }
    }
}
