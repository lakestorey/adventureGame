using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        int hundreds;
        int seconds;
        int minutes;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            countTimer.Enabled = true;
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            //add to hundreds
            hundreds++;

            //update values
            if (hundreds == 100)
            {
                seconds++;
                hundreds = 0;
            }
            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            //update displays
            msLabel.Text = hundreds + "";
            secLabel.Text = seconds + "";
            minLabel.Text = minutes + "";
        }
    }
}
