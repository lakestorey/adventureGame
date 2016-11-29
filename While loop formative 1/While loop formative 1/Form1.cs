using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_loop_formative_1
{
    public partial class Form1 : Form
    {
        //declare all variables
        int startValue;
        int endValue;
        int outputValue;
        int x;
        int y;

        //declare all graphics objects
        Graphics g;
        SolidBrush redBrush = new SolidBrush(Color.Red);
        Font arialFont = new Font("Arial", 16, FontStyle.Bold);
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            //convert inputs to integers
            startValue = Convert.ToInt16(startInput.Text);
            endValue = Convert.ToInt16(endInput.Text);
            outputValue = startValue;
            x = this.Width - 45;
            y = 180;

            ////while loop
            //while (outputValue >= startValue && outputValue <= endValue)
            //{
            //    g.DrawString(outputValue + "", arialFont, redBrush, x, y);
            //    x = x - 25;
            //    outputValue++;
            //    Thread.Sleep(10);
            //}

            while (startValue <= endValue)
            {
                g.DrawString(startValue + "", arialFont, redBrush, x, y);
                x = x - 25;
                startValue++;
                Thread.Sleep(10);
            }
        }
    }
}
