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
using System.Diagnostics;

namespace Serial_Port
{
    public partial class Clock : Form
    {
        Stopwatch watch = new Stopwatch();
        int mili, sec, min;

        public Clock()
        {
            InitializeComponent();
            getAvailablePorts();
        }

        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            cbCOM.Items.AddRange(ports);
        }

        private void bntOpenPort_Click(object sender, EventArgs e)
        {
            if (bntOpenPort.Text == "OPEN PORT")
            {
                try
                {
                    if (cbCOM.Text == "" || cbBaur.Text == "")
                    {
                        tbRx.Text = "Please selecte PORT setting.";
                    }
                    else
                    {
                        serialPort1.BaudRate = Convert.ToInt32(cbBaur.Text);
                        serialPort1.PortName = cbCOM.Text;
                        serialPort1.Open();
                        pbOpenPort.Value = 100; 

                        bntOpenPort.Text = "CLOSE PORT";
                        tbTx.Enabled = true;
                        bntRead.Enabled = true;
                        bntSend.Enabled = true;
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    tbRx.Text = "Unauthor Access.";
                }
            }
            else
            {
                serialPort1.Close();

                bntOpenPort.Text = "OPEN PORT";
                pbOpenPort.Value = 0;
                tbRx.Enabled = false;
                tbTx.Enabled = false;
                bntRead.Enabled = true;
                bntSend.Enabled = true;
            }
        }

        private void bntSend_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(tbTx.Text);  
        }

        private void bntStart_Click(object sender, EventArgs e)
        {
            if(bntStart.Text == "START")
            {
                bntStart.Text = "PAUSE";
                Startwatch.Start();               
                watch.Start();
            }
            else
            {
                bntStart.Text = "START";
                Startwatch.Stop();
                watch.Stop();
            }
        }

        private void bntRead_Click(object sender, EventArgs e)
        {
            try
            {
                tbRx.Text += serialPort1.ReadLine();
            }
            catch(UnauthorizedAccessException)
            {
                tbRx.Text = "Timeout Exception.";
            }
        }

        /********************* TIMER ***********************/

        private void Stopwatch_Tick(object sender, EventArgs e)
        {
            mili = watch.Elapsed.Milliseconds;
            sec = watch.Elapsed.Seconds;
            min = watch.Elapsed.Minutes;

            lbClock.Text = min.ToString("00") + ":" + sec.ToString("00") + ":" + mili.ToString("000");
        }
    }
}
