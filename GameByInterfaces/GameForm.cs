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
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            hearts.Add(heart1);
            hearts.Add(heart2);
            hearts.Add(heart3);
            hearts.Add(heart4);
            hearts.Add(heart5);

            heartsQ = hearts.Count();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (heartsQ > 0)
            {
                --heartsQ;
                hearts[heartsQ].Image = Image.FromFile("../../../../images/heart-empty.png");
                hearts[heartsQ].Invalidate();
            }
        }
    }
}
