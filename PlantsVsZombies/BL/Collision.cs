using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantsVsZombies.BL
{
    internal class Collision
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

        public Level3Form CompositiOn
        {
            get => default;
            set
            {
            }
        }

        public static Guna2PictureBox CheckForZombieCollision(Guna2PictureBox PictureBox1, Guna2PictureBox PictureBox2, Guna2PictureBox PictureBox3, Guna2PictureBox PictureBox4, Guna2PictureBox PictureBox5, Guna2PictureBox Zombie)
        {
            Guna2PictureBox[] pictureBoxes = { PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5 };
            foreach (Guna2PictureBox pictureBox in pictureBoxes)
            {
                if (Zombie.Bounds.IntersectsWith(pictureBox.Bounds))
                {
                    return pictureBox;
                }
            }

            return null;
        }
        public static void FireCollideZombie(List<Guna2PictureBox> playerFires,Guna2PictureBox Zombie,Guna2ProgressBar ZombieHealth ,Form Level,ref bool ZombieAlive,ref int ZombieHealthMinus)
        {
            for (int i = playerFires.Count - 1; i >= 0; i--)
            {

                if (Zombie.Bounds.IntersectsWith(playerFires[i].Bounds) || playerFires[i].Left > 780)
                {
                    ZombieHealth.Value -= ZombieHealthMinus;

                    if (ZombieHealth.Value == 0)
                    {

                        Level.Controls.Remove(Zombie);
                        ZombieAlive = false;
                        ZombieHealth.Value = 100;


                    }
                    Level.Controls.Remove(playerFires[i]);
                    playerFires.RemoveAt(i);
                }
            }
        }
    }

}
