using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameByInterfaces
{
    public partial class GameForm : Form
    {
        List<PictureBox> hearts = new List<PictureBox>();
        int heartsQ;
        int birdCount = 0;
        int testCount = 0;
        PictureBox bird = new PictureBox();

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("../../../../images/aim.cur");
            CreateBirdTimer.Start();

            hearts.Add(heart1);
            hearts.Add(heart2);
            hearts.Add(heart3);
            hearts.Add(heart4);
            hearts.Add(heart5);

            heartsQ = hearts.Count();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {}

        private void GameForm_Click(object sender, EventArgs e) {}

        private void GenericClick()
        {
            if (heartsQ > 0)
            {
                --heartsQ;
                hearts[heartsQ].Image = Image.FromFile("../../../../images/heart-empty.png");
                hearts[heartsQ].Invalidate();
            }
        }

        private void gamePanel_Click(object sender, EventArgs e)
        {
            GenericClick();
        }

        private void heartsPanel_Click(object sender, EventArgs e)
        {
            GenericClick();
        }

        private void BottomTabelPanel_Click(object sender, EventArgs e)
        {
            GenericClick();
        }

        private void GameForm_MouseMove(object sender, MouseEventArgs e){}

        private void genericMovement()
        {
            Point position = this.PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));

            if (position.X < gamePanel.Width / 2)
            {
                gun.Image = Image.FromFile("../../../../images/gun.png");
                gun.Location = new Point((int)(gamePanel.Width * 0.44444) + position.X / 10, position.Y / 10);
            }
            else
            {
                gun.Image = Image.FromFile("../../../../images/gun-zercal.png");
                gun.Location = new Point((int)(gamePanel.Width * 0.44444) + position.X / 10 - gun.Width, position.Y / 10);
            }
        }

        private void gamePanel_MouseMove(object sender, MouseEventArgs e)
        {
            genericMovement();
        }

        private void heartsPanel_MouseMove(object sender, MouseEventArgs e)
        {
            genericMovement();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            genericMovement();
        }

        private void gun_MouseMove(object sender, MouseEventArgs e) {}

        private void CreateBirdTimer_Tick(object sender, EventArgs e)
        {
            //if (birdCount < 1)
            //{
            //    Random random = new Random();
            //    int rndX = random.Next(1, 2);
            //    int rndY = random.Next(heartsPanel.Height, gamePanel.Height - bottomPanel.Height - bird.Height);

            //    bird.Image = Image.FromFile("../../../../images/bird1.gif");
            //    bird.BackColor = Color.Transparent;
            //    bird.Location = new Point(0, rndY);
            //    bird.SizeMode = PictureBoxSizeMode.StretchImage;
            //    bird.Width = 80;
            //    bird.Height = 80;

            //    gamePanel.Controls.Add(bird);
            //    TimerForBirdMovement.Start();

            //    birdCount++;

            //    Count.Text = "Очки: " + rndY;
            //}
        }

        private void TimerForBirdMovement_Tick(object sender, EventArgs e)
        {
            //bird.Invalidate();
            //bird.Left = bird.Left + 1;
            
            //if (bird.Left > gamePanel.Width)
            //{
            //    TimerForBirdMovement.Stop();
            //    birdCount--;
            //}
        }

        //private void bird_MouseMove(object sender, MouseEventArgs e)
        //{
        //    genericMovement();
        //}

        private void bottomPanel_Paint(object sender, PaintEventArgs e)
        {
            genericMovement();
        }

        //private void bird1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    genericMovement();
        //}

        //private void bird2_MouseMove(object sender, MouseEventArgs e)
        //{
        //    genericMovement();
        //}
    }
}
