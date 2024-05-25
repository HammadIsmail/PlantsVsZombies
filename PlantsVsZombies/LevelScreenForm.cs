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
    public partial class LevelScreenForm : Form
    {
        public LevelScreenForm()
        {
            InitializeComponent();
        }

        public StartForm Composition
        {
            get => default;
            set
            {
            }
        }

        public static void start1()
        {
            Level1Form start = new Level1Form();
            Application.Run(start);
        }

        private void Level1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(start1));
            thread.Start();
            this.Close();

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        public static void start2()
        {
            Level2Form start = new Level2Form();
            Application.Run(start);
        }
        public static void start3()
        {
            Level3Form start = new Level3Form();
            Application.Run(start);
        }
        private void Level2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(start2));
            thread.Start();
            this.Close();
        }

        private void Level3_Click(object sender, EventArgs e)
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(start3));
            thread.Start();
            this.Close();
        }
    }
}
