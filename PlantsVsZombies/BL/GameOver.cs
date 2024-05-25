using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantsVsZombies.BL
{
    internal class GameOver
    {
      static  int LevelNo;

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

        private static void Gameover()
        {
            GameOverForm start = new GameOverForm(LevelNo);
            Application.Run(start);
        }
        private static void Win()
        {
            WinForm start = new WinForm();
            Application.Run(start);
        }
        public static void lose(Guna2ProgressBar LevelCompletionBar,Guna2PictureBox levelBarIconPb, Guna2PictureBox Flag,Form Level,Guna2PictureBox Zombie,Guna2PictureBox PictureBox1, Guna2PictureBox PictureBox2, Guna2PictureBox PictureBox3, Guna2PictureBox PictureBox4, Guna2PictureBox PictureBox5,int l)
        {
            LevelNo = l;
            if (LevelCompletionBar.Value <= 100)
            {
                levelBarIconPb.Left += 3;
                LevelCompletionBar.Value += 1;
            }

            if (levelBarIconPb.Bounds.IntersectsWith(Flag.Bounds))
            {
                System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(Win));
                thread.Start();
                Level.Close();
            }
            if (Zombie.Bounds.IntersectsWith(PictureBox1.Bounds) || Zombie.Bounds.IntersectsWith(PictureBox2.Bounds) || Zombie.Bounds.IntersectsWith(PictureBox3.Bounds) || Zombie.Bounds.IntersectsWith(PictureBox4.Bounds) || Zombie.Bounds.IntersectsWith(PictureBox5.Bounds))
            {
                Guna2PictureBox collisionPictureBox = Collision.CheckForZombieCollision(PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5,Zombie);
                if (collisionPictureBox != null)
                {
                    System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(Gameover));
                    thread.Start();
                    Level.Close();

                }
            }
        }
    }
}
