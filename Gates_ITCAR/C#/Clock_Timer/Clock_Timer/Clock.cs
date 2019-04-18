using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Clock_Timer
{
    public partial class Clock : Form
    {
        int milisecond, second, minute;
        bool isActive;

        public Clock()
        {
            InitializeComponent();
        }



        private void lbStart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void lbStop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void lbReset_Click(object sender, EventArgs e)
        {
            isActive = false;

            ResetTime();
        }

        private void ResetTime()
        {
            milisecond = 0;
            second = 0;
            minute = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isActive == true)
            {
                milisecond++;
                if(milisecond >= 100)
                {
                    second++;
                    milisecond = 0; 
                    
                    if(second >= 60)
                    {
                        minute++;
                        second = 0;
                    }
                }
            }

            DrawStopWatch();
        }

        private void DrawStopWatch()
        {
            lbClock.Text = String.Format("{0:00}:{1:00}:{2:00}", minute, second, milisecond);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Clock_Load(object sender, EventArgs e)
        {
            ResetTime();

            isActive = false;
        }
    }
}
