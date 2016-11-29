///Lake Storey Nov. 24, 2016
///recreate the death star destruction plan animation from the
///starwars franchise
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarwarsTrenchRun
{
    public partial class TrenchRun : Form
    {
        // declare brushes, pens and fonts
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        Pen whitePen = new Pen(Color.White, 2);
        Pen blackPen = new Pen(Color.Black, 2);
        Font arial16 = new Font("Arial", 16);
        Font arial10 = new Font("Arial", 10);

        //declare variables
        int explosionSize = 0;
        int shipX = 0;
        int shipY = 25;
        int bombY = 40;
        int explosionWidth = 10;
        int explosionHeight = 10;
        int explosionX = 165;
        int explosionY = 190;

        //declare sounds
        SoundPlayer laserBlasts = new SoundPlayer(Properties.Resources.Laser_Blasts_SoundBible_com_108608437);
        SoundPlayer explosionSound = new SoundPlayer(Properties.Resources.Atomic_Bomb_Sound_Explorer_897730679);
        SoundPlayer successSound = new SoundPlayer(Properties.Resources.Ta_Da_SoundBible_com_1884170640);

        public TrenchRun()
        {
            InitializeComponent();
        }

        private void TrenchRun_Click(object sender, EventArgs e)
        {
            //create graphics object
            Graphics fg = this.CreateGraphics();
            //get rid of label
            topSecretLabel.Dispose();
            //clear background
            this.BackgroundImage = null;
            Refresh();
            //show text about the mission
            fg.DrawString("Death Star Attack Plan:", arial16, redBrush, 20,20);
            fg.DrawString("Step 1: Shoot the thing\nStep 2: Blow up " +
                "the thing\nStep 3: Profit", arial10, redBrush, 20, 45);
            Thread.Sleep(3000);
            fg.Clear(Color.Black);

            while (shipX <= this.Width + 20) 
            {
                if (shipX <= 160)
                {
                    Thread.Sleep(10);
                    fg.Clear(Color.Black);
                    fg.DrawPie(whitePen, shipX, shipY, 50, 50, 165, 20);
                    fg.DrawEllipse(whitePen, 20, 100, 300, 300);
                    fg.DrawRectangle(whitePen, 160, 100, 25, 100);
                    fg.FillRectangle(blackBrush, 161, 95, 23, 10);
                    shipX++;
                }
                else if(bombY == 41)
                {
                    laserBlasts.Play();
                    bombY++;
                }
                else
                {
                    Thread.Sleep(10);
                    fg.Clear(Color.Black);
                    fg.DrawPie(whitePen, shipX, shipY, 50, 50, 165, 20);
                    fg.DrawEllipse(whitePen, 20, 100, 300, 300);
                    fg.DrawRectangle(whitePen, 160, 100, 25, 100);
                    fg.FillRectangle(blackBrush, 161, 95, 23, 10);
                    fg.FillEllipse(orangeBrush, 162, bombY, 20, 20);
                    shipX++;
                    bombY++;
                }
            }

            explosionSound.Play();
            Thread.Sleep(300);
            while (explosionSize <= 200)
            {
                Thread.Sleep(10);
                fg.Clear(Color.Black);
                fg.DrawPie(whitePen, shipX, shipY, 50, 50, 165, 20);
                fg.DrawEllipse(whitePen, 20, 100, 300, 300);
                fg.DrawRectangle(whitePen, 160, 100, 25, 100);
                fg.FillRectangle(blackBrush, 161, 95, 23, 10);
                fg.FillEllipse(redBrush, explosionX, explosionY, explosionWidth, explosionHeight);
                explosionSize++;
                explosionWidth = explosionWidth + 2;
                explosionHeight = explosionHeight + 2;
                explosionY--;
                explosionX--;
            }
            fg.Clear(Color.Black);
            fg.DrawString("Mission Success!!", arial16, whiteBrush, 10, 10);
            successSound.Play();

        }
    }
}
