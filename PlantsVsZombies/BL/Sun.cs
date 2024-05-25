using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PlantsVsZombies.BL
{
    internal class Sun
    {
        Guna2HtmlLabel SunCountlb;
        Form level;
        List<Guna2PictureBox> SunList;
        public Sun(Guna2HtmlLabel SunCountlb, Form level, List<Guna2PictureBox> SunList) { 
        
        this.SunCountlb = SunCountlb;
            this.level = level;
            this.SunList = SunList;
        }

        public Level1Form Composition
        {
            get => default;
            set
            {
            }
        }

        public Level2Form CompositiOn
        {
            get => default;
            set
            {
            }
        }

        public Level3Form CompositioN
        {
            get => default;
            set
            {
            }
        }

        public static void minusSun(Guna2HtmlLabel SunCountlb)
        {
            int minus = int.Parse(SunCountlb.Text) - 100;
            SunCountlb.Text = minus.ToString();
        }


        public static void SunDropper(List<Guna2PictureBox> SunList )
        {
            foreach (Guna2PictureBox Sun in SunList)
            {
                Sun.Top = Sun.Top + 4;
            }
            for (int idx = SunList.Count - 1; idx >= 0; idx--)
            {
                if (SunList[idx].Top >= 450)
                {
                    SunList.RemoveAt(idx);
                }
            }
        }
        public Guna2PictureBox createSun(Image FireImage)
        {
            Guna2PictureBox pbFire = new Guna2PictureBox();
            pbFire.Image = FireImage;
            pbFire.Cursor = Cursors.Hand;
            pbFire.Size = new Size(60, 60);

            pbFire.BackColor = Color.Transparent;
            pbFire.SizeMode = PictureBoxSizeMode.StretchImage;

            pbFire.Click += this.sun_Click;
            return pbFire;
        }
        private void sun_Click(object sender, EventArgs e)
        {
            if (sender is Guna2PictureBox clickedSun)
            {
                int add = int.Parse(SunCountlb.Text) + 25;
                SunCountlb.Text = add.ToString();

                level.Controls.Remove(clickedSun);
                for (int idx = SunList.Count - 1; idx >= 0; idx--)
                {

                    SunList.RemoveAt(idx);

                }
            }
        }

        public static void GenerateSun(Form level, Image Sunimg, List<Guna2PictureBox> SunList,Random rand,Guna2HtmlLabel SunCountlb)
        {
            Sun sun = new Sun(SunCountlb,level, SunList);
            Guna2PictureBox pbSun = sun.createSun(Sunimg);
            SunList.Add(pbSun);
            int left = rand.Next(300, level.Width - 70);
            pbSun.Left = left;
            level.Controls.Add(pbSun);
        }
    }
}