using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;

namespace PlantsVsZombies.BL
{
    internal class Zombies
    {
        private static int i = 0;

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

        public static Guna2PictureBox createEnemy(Image img,Random rand)
        {
            //50, 125, 205,265,330
            Guna2PictureBox pbEnemy = new Guna2PictureBox();
            int[] numbers = { 50, 125, 205, 265, 330 };
            int index = rand.Next(numbers.Length);
            int top = numbers[index];
            int left = 750;
            pbEnemy.Location = new Point(left, top);
            pbEnemy.Size = new Size(64, 70);
            pbEnemy.BackColor = Color.Transparent;
            pbEnemy.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEnemy.Image = img;
          //  Controls.Add(pbEnemy);
            return pbEnemy;
        }

        public static Guna2PictureBox Movement(ref bool ZombieAlive,Guna2PictureBox Zombie,Random rand,int level)
        {
            if (!ZombieAlive)
            {
                int number=0;
                if (level ==1)
                {
                    Zombie = Zombies.createEnemy(Properties.Resources.FootballZombie, rand);

                }
                if (level == 2)
                {
                     number = rand.Next(1, 3);

                    if (number == 1)
                    {
                        Zombie = Zombies.createEnemy(Properties.Resources.FootballZombie, rand);

                    }
                    if (number == 2)
                    {
                        Zombie = Zombies.createEnemy(Properties.Resources.SecondLevelZombie, rand);

                    }
                }
                if (level == 3)
                {
                     number = rand.Next(1, 4);
                    if (number == 1)
                    {
                        Zombie = Zombies.createEnemy(Properties.Resources.FootballZombie, rand);

                    }
                    if (number == 2)
                    {
                        Zombie = Zombies.createEnemy(Properties.Resources.SecondLevelZombie, rand);

                    }
                    if (number == 3)
                    {
                        Zombie = Zombies.createEnemy(Properties.Resources.jumpingZombie, rand);

                    }

                }
             

                //     this.Controls.Add(Zombie);
                ZombieAlive = true;
                i=i+1;
            }
            Zombie.Left -= 1;
            return Zombie;
        }


    }
}
