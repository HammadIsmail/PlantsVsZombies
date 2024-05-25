using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace PlantsVsZombies.BL
{
    internal class Plant
    {
        public Level1Form Composition
        {
            get => default;
            set
            {
            }
        }

        public Level2Form CompositioN
        {
            get => default;
            set
            {
            }
        }

        public Level3Form CompositIon
        {
            get => default;
            set
            {
            }
        }

        public static void GeneratePlant(Guna2HtmlLabel SunCountlb ,ref bool clickPlant,ref bool clickPictureBox1,
            ref bool clickPictureBox2, ref bool clickPictureBox3, ref bool clickPictureBox4, ref bool clickPictureBox5,
            ref bool checkPlant1, ref bool checkPlant2, ref bool checkPlant3, ref bool checkPlant4,
            ref bool checkPlant5, Guna2PictureBox PictureBox1,Guna2PictureBox PictureBox2, Guna2PictureBox PictureBox3, Guna2PictureBox PictureBox4, 
            Guna2PictureBox PictureBox5, Image peaShooter)
        {
            if (int.Parse(SunCountlb.Text) >= 100 && clickPlant)
            {
                if (clickPictureBox1)
                {
                    Sun.minusSun(SunCountlb);

                    PictureBox1.Image = peaShooter;
                    clickPlant = false;
                    clickPictureBox1 = false;
                    checkPlant1 = true;
                }
                else if (clickPictureBox2)
                {
                    Sun.minusSun(SunCountlb);
                    PictureBox2.Image = peaShooter;
                    clickPlant = false;
                    clickPictureBox2 = false;
                    checkPlant2 = true;


                }
                else if (clickPictureBox3)
                {
                    Sun.minusSun(SunCountlb);
                    PictureBox3.Image = peaShooter;
                    clickPlant = false;
                    clickPictureBox3 = false;
                    checkPlant3 = true;


                }
                else if (clickPictureBox4)
                {
                    Sun.minusSun(SunCountlb);
                    PictureBox4.Image = peaShooter;
                    clickPlant = false;
                    clickPictureBox4 = false;
                    checkPlant4 = true;


                }
                else if (clickPictureBox5)
                {
                    Sun.minusSun(SunCountlb);
                    PictureBox5.Image = peaShooter;
                    clickPlant = false;
                    clickPictureBox5 = false;
                    checkPlant5 = true;

                }

            }

        }

        public static Guna2PictureBox createFire(Image FireImage, Guna2PictureBox source)
        {
            Guna2PictureBox pbFire = new Guna2PictureBox();
            pbFire.Image = FireImage;
            pbFire.Size = new Size(30, 28);
            pbFire.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFire.BackColor = Color.Transparent;
            int x = source.Left + (source.Width / 2) + 30;
            int y = source.Top + (source.Height / 2) - 30;
            pbFire.Location = new Point(x, y);
          //  Controls.Add(pbFire);
            return pbFire;
        }

        public static void FireBullets(Form Level,List<Guna2PictureBox> playerFires,ref bool checkPlant1,
            ref bool checkPlant2, ref bool checkPlant3, ref bool checkPlant4, ref bool checkPlant5,Guna2PictureBox Zombie,Image PeaFire,
            Guna2PictureBox PictureBox1, Guna2PictureBox PictureBox2, Guna2PictureBox PictureBox3, Guna2PictureBox PictureBox4, Guna2PictureBox PictureBox5)
        {
            if (checkPlant1 && Zombie.Top == 50)
            {
                Guna2PictureBox pbfire = Plant.createFire(PeaFire, PictureBox1);
                playerFires.Add(pbfire);
                Level.Controls.Add(pbfire);
            }
            else if (checkPlant2 && Zombie.Top == 125)
            {
                Guna2PictureBox pbfire1 = Plant.createFire(PeaFire, PictureBox2);
                playerFires.Add(pbfire1);
                Level.Controls.Add(pbfire1);
            }
            else if (checkPlant3 && Zombie.Top == 205)
            {
                Guna2PictureBox pbfire2 = Plant.createFire(PeaFire, PictureBox3);
                playerFires.Add(pbfire2);
                Level.Controls.Add(pbfire2);
            }
            else if (checkPlant4 && Zombie.Top == 265)
            {
                Guna2PictureBox pbfire3 = Plant.createFire(PeaFire, PictureBox4);
                playerFires.Add(pbfire3);
                Level.Controls.Add(pbfire3);
            }
            else if (checkPlant5 && Zombie.Top == 330)
            {
                Guna2PictureBox pbfire4 = Plant.createFire(PeaFire, PictureBox5);
                playerFires.Add(pbfire4);
                Level.Controls.Add(pbfire4);
            }
        }
        public static void FireMovement(List<Guna2PictureBox> playerFires)
        {
            foreach (Guna2PictureBox bullet in playerFires)
            {
                bullet.Left = bullet.Left + 20;
            }
        }

    }
}

