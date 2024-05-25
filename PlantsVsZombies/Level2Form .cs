using Guna.UI2.WinForms;
using PlantsVsZombies.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PlantsVsZombies
{
    public partial class Level2Form : Form
    {
        List<Guna2PictureBox> playerFires = new List<Guna2PictureBox>();
        List<Guna2PictureBox> SunList = new List<Guna2PictureBox>();
        bool clickPlant, clickPictureBox1, clickPictureBox2, clickPictureBox3, clickPictureBox4, clickPictureBox5;
        bool checkPlant1, checkPlant2,checkPlant3, checkPlant4, checkPlant5;
        Random rand = new Random();
        Image peaShooter;
        Guna2PictureBox Zombie1;
        bool ZombieAlive1;

        Image PeaFire;
        Image Sunimg;
        Form level;
        bool pause = false;
        int ZombieHealthMinus=10;
        public Level2Form()
        {
            InitializeComponent();
          this.StartPosition= FormStartPosition.CenterScreen;
             level = this;
        }

        public LevelScreenForm Composition
        {
            get => default;
            set
            {
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void guna2PictureBox3_Click_1(object sender, EventArgs e)
        {
            clickPlant = true;
        }
   
        private void BulletFires_Tick(object sender, EventArgs e)
        {
            Plant.FireBullets(level, playerFires, ref checkPlant1,
               ref checkPlant2, ref checkPlant3, ref checkPlant4, ref checkPlant5, Zombie1, PeaFire,
                PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5);

        }


   
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }
        public static void start()
        {
        
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            clickPictureBox1=true;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            clickPictureBox2=true;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            clickPictureBox3= true;
        }

        private void ZombiesMovement_Tick(object sender, EventArgs e)
        {

             Zombie1 = Zombies.Movement(ref ZombieAlive1, Zombie1, rand,2);
            this.Controls.Add(Zombie1);


        }

        private void PlayPuaseBtn_Click(object sender, EventArgs e)
        {
            pause=!pause;
            if (pause)
            {
                PlayPuaseBtn.Image = Properties.Resources.play_44_64;
                GeneratePlant.Enabled = false;
                ZombiesMovement.Enabled = false;
                fireBullet.Enabled = false;
                SunDroper.Enabled = false;
                GenerateSunTimer.Enabled = false;
                GemeOverChecker.Enabled = false;
                GenerateFire.Enabled= false;
            }
            else
            {
                PlayPuaseBtn.Image = Properties.Resources.Pause;
                GeneratePlant.Enabled = true;
                ZombiesMovement.Enabled = true;
                fireBullet.Enabled = true;
                SunDroper.Enabled = true;
                GenerateSunTimer.Enabled = true;
                GemeOverChecker.Enabled = true;
                GenerateFire.Enabled = true;
            }
        }

        private void GameOverChecker_Tick(object sender, EventArgs e)
        {
            GameOver.lose( LevelCompletionBar,  levelBarIconPb,  Flag,  level,  Zombie1,  PictureBox1,  PictureBox2,  PictureBox3,  PictureBox4,  PictureBox5,2);
                
        }


        private void PictureBox4_Click(object sender, EventArgs e)
        {
            clickPictureBox4= true;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            clickPictureBox5= true;
        }

        private void ClickPlant_Click(object sender, EventArgs e)
        {
            clickPlant=true;
        }

        private void Level1Form_Load(object sender, EventArgs e)
        {
            Sunimg = Properties.Resources.SunBallTransparent1;
            PeaFire = Properties.Resources.SnowBall;
            //   peaShooter = PlantsVsZombies.Properties.Resources.PeashooterTransparentGif_391kb;
            peaShooter = PlantsVsZombies.Properties.Resources.SnowShooter;
            Zombie1 =Zombies.createEnemy(Properties.Resources.SecondLevelZombie,rand);
            this.Controls.Add(Zombie1);
            ZombieAlive1 = true;
       
        }

        private void GenerateBulletTimer_Tick(object sender, EventArgs e)
        {

            Plant.FireMovement(playerFires);

            Collision.FireCollideZombie(playerFires, Zombie1, ZombieHealth, level, ref ZombieAlive1,ref ZombieHealthMinus);
        }

        private void SunDroper_Tick(object sender, EventArgs e)
        {

            Sun.SunDropper(SunList);
        }

        private void GenerateSunTimer_Tick(object sender, EventArgs e)
        {

            Sun.GenerateSun(level, Sunimg, SunList, rand, SunCountlb);

        }

        private void PlantGeneratorTimer(object sender, EventArgs e)
        {
            Plant.GeneratePlant(SunCountlb,ref clickPlant,ref clickPictureBox1, ref clickPictureBox2, ref clickPictureBox3
                , ref clickPictureBox4, ref clickPictureBox5 , ref  checkPlant1, ref  checkPlant2, ref  checkPlant3, ref  checkPlant4,
            ref  checkPlant5,  PictureBox1,  PictureBox2,  PictureBox3,  PictureBox4,
             PictureBox5,  peaShooter);
        }

    }
}
