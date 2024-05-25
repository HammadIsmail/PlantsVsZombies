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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        public LoadingForm Composition
        {
            get => default;
            set
            {
            }
        }

        public static void start()
        {
            LevelScreenForm start = new LevelScreenForm();
            Application.Run(start);
        }

        private void OpenLevelScreen_Click(object sender, EventArgs e)
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(start));
            thread.Start();
            this.Close();

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
