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

namespace GATE_v1
{
    public partial class Control : Form
    {
        Stopwatch TimerWatch = new Stopwatch();
        Stopwatch TimerWatch2 = new Stopwatch();
        int min, sec, milisec;
        int cntGo, state = 1;
        bool isPass = false, isFinish = false;
        bool isPass2 = false, isFinish2 = false;
        ShowForm frm;
        int check_point = 0;
        int check_point2 = 0;
        public Control()
        {
            InitializeComponent();
            frm = new ShowForm(this);
            getAvailablePorts();
            cbBaur.Text = "9600";
            bntMode.Text = "MODE 2";
            lbWatch2.Hide();
            lbWatch1.BringToFront();
            lbWatch2.BringToFront();
            btn_team_2.Hide();
            textBox_name_team_2.Hide();
            btn_both.Hide();
        }

        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            cbCom.Items.AddRange(ports);
        }

        //----------------------------------------------
        //....................BUTON.....................
        //----------------------------------------------

        private void bntMode_Click(object sender, EventArgs e)
        {
            if (bntMode.Text == "MODE 1")
            {
                UART.Write("1");
                bntMode.Text = "MODE 2";
                state = 1;
                lbWatch2.Hide();
                btn_team_2.Hide();
                textBox_name_team_2.Hide();
                btn_both.Hide();
            }
            else if (bntMode.Text == "MODE 2")
            { 
                UART.Write("2");
                bntMode.Text = "MODE 1";
                state = 2;
                lbWatch2.Show();
                btn_team_2.Show();
                textBox_name_team_2.Show();
                btn_both.Show();
            }
        }

        private void bntConnect_Click(object sender, EventArgs e)
        {
            if (bntConnect.Text == "CONNECT")
            {
                try
                {
                    if (cbCom.Text == "" || cbBaur.Text == "")
                    {
                        lbStripStatus.Text = "Please select PORT setting.";
                    }
                    else
                    {
                        UART.PortName = cbCom.Text;
                        UART.BaudRate = Convert.ToInt32(cbBaur.Text);
                        UART.Open();
                        progressBar.Value = 100;

                        UART.Write("R");

                        if (bntMode.Text == "MODE 1")
                            UART.Write("2");
                        else if (bntMode.Text == "MODE 2")
                            UART.Write("1");
                        

                        lbStripStatus.Text = "CONNECT TO " + UART.PortName;
                        bntConnect.Text = "DISCONNECT";

                        cbCom.Enabled = false;
                        cbBaur.Enabled = false;
                        bntGate.Enabled = true;
                        bntReset.Enabled = true;
                        bntReady.Enabled = true;
                        bntSend.Enabled = true;
                        bntMode.Enabled = true;
                        tbTx.Enabled = true;
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    lbStripStatus.Text = "Unauthor Access.";
                }
            }
            else
            {
                progressBar.Value = 0;
                UART.Write("R");
                UART.Close();

                

                CountDown.Stop();
                Watch.Stop();
                TimerWatch.Stop();
                lbCountDown.Text = "READY";
                lbWatch1.Text = "00:00:000";
                lbWatch2.Text = "00:00:000";

                bntConnect.Text = "CONNECT";
                cbCom.Enabled = true;
                cbBaur.Enabled = true;

                bntGate.Enabled = false;
                bntReady.Enabled = false;
                bntStart.Enabled = false;
                bntSend.Enabled = false;
                bntMode.Enabled = false;
                tbTx.Enabled = false;
            }
        }

        private void bntReady_Click(object sender, EventArgs e)
        {
            try
            {
                UART.Write("D");
                CountDown.Stop();
                Watch.Stop();
                TimerWatch.Stop();
                TimerWatch2.Stop();
                //if (bntMode.Text == "MODE 1")
                //    UART.Write("1");
                //else if (bntMode.Text == "MODE 2")
                //    UART.Write("2");
               
                isPass = false;
                isFinish = false;
                isPass2 = false;
                isFinish2 = false;
                bntReady.Enabled = false;
                bntStart.Enabled = true;
            }
            catch { }

            if (int.Parse(tbCount.Text) > 0)
                cntGo = int.Parse(tbCount.Text);
            else
                cntGo = 5;

            this.lbCountDown.Text = cntGo.ToString("00") + "  READY";
            this.lbWatch1.Text = "00:00:000";
            this.lbWatch2.Text = "00:00:000";
            frm.lbCountDown.Text = cntGo.ToString("00") + "  READY";
            frm.lbWatch.Text = "00:00:000";

            lbStripStatus.Text = "READY";
        }

        private void bntStart_Click(object sender, EventArgs e)
        {
            check_point = 0;
            CountDown.Start();

            bntStart.Enabled = false;
            bntGate.Enabled = false;

            lbStripStatus.Text = "COUNT DOWN";
        }

        private void bntGate_Click(object sender, EventArgs e)
        {
            if (bntGate.Text == "OPEN")
            {
                UART.Write("O");      // OPEN          

                bntGate.Text = "CLOSE";
                lbStripStatus.Text = "SERVO OPEN.";
            }
            else
            {
                UART.Write("C");      // CLOSE

                bntGate.Text = "OPEN";
                lbStripStatus.Text = "SERVO CLOSE.";
            }
        }

        private void bntSend_Click(object sender, EventArgs e)
        {
            UART.Write(tbTx.Text);
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            if (bntConnect.Text == "DISCONNECT")
            {
                UART.Write("R");          // RESET
                if (bntMode.Text == "MODE 1")
                    UART.Write("2");
                else if (bntMode.Text == "MODE 2")
                    UART.Write("1");
                try
                {
                    CountDown.Stop();
                    Watch.Stop();
                    TimerWatch.Stop();
                }
                catch (Exception) { }
                
                isPass = false;
                isFinish = false;

                bntReady.Enabled = true;
                bntStart.Enabled = false;
                bntGate.Enabled = true;
                bntGate.Text = "OPEN";

                if (int.Parse(tbCount.Text) > 0)
                    cntGo = int.Parse(tbCount.Text);
                else
                    cntGo = 5;

                this.lbCountDown.Text = cntGo.ToString("00") + "  READY";
                this.lbWatch1.Text = "00:00:000";
                this.lbWatch2.Text = "00:00:000";
                frm.lbCountDown.Text = cntGo.ToString("00") + "  READY";
                frm.lbWatch.Text = "00:00:000";
            }
            else
            {
                cbCom.Text = "";
                cbCom.Items.Clear();
                getAvailablePorts();
            }
            lbStripStatus.Text = "RESET";
        }



        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShow.Checked == true)
            {
                frm.Show();
            }
            else
            {
                frm.Hide();
            }
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            tbRx.Clear();
        }

        //_____________________________________________________________
        //
        //_____________________________________________________________

        private void Watch_Tick(object sender, EventArgs e)
        {
            if (isFinish == true && state==1)
            {
                try
                {
                    CountDown.Stop();
                    Watch.Stop();
                    TimerWatch.Stop();
                    System.IO.File.WriteAllText("result\\" + textBox_name_team_1.Text + ".txt", "Team " + textBox_name_team_1.Text + ":\nCheck point " + check_point.ToString() + ": " + min.ToString("00") + ":" + sec.ToString("00") + "." + milisec.ToString("000"));
                    UART.Write("F");
                } catch { }
                

                this.lbCountDown.Text = "FINISH !!!";
                frm.lbCountDown.Text = "FINISH !!!";
            }

            if (isFinish == true && state == 2)
            {
                try
                {
                    TimerWatch.Stop();
                    System.IO.File.WriteAllText("result\\" + textBox_name_team_1.Text + ".txt", "Team " + textBox_name_team_1.Text + ":\nCheck point " + check_point.ToString() + ": " + min.ToString("00") + ":" + sec.ToString("00") + "." + milisec.ToString("000"));
                }
                catch { }


                this.lbCountDown.Text = "PLAYER 1 FINISH !!!";
                frm.lbCountDown.Text = "PLAYER 1 FINISH !!!";
            }

            if (isFinish2 == true && state == 2)
            {
                try
                {
                    TimerWatch2.Stop();
                    System.IO.File.WriteAllText("result\\" + textBox_name_team_2.Text + ".txt", "Team " + textBox_name_team_2.Text + ":\nCheck point " + check_point2.ToString() + ": " + min.ToString("00") + ":" + sec.ToString("00") + "." + milisec.ToString("000"));
                }
                catch { }


                this.lbCountDown.Text = "PLAYER 2 FINISH !!!";
                frm.lbCountDown.Text = "PLAYER 2 FINISH !!!";
            }

            if (isFinish2 == true && isFinish == true && state == 2)
            {
                try
                {
                    Watch.Stop();
                    UART.Write("F");
                    
                }
                catch { }


                this.lbCountDown.Text = "FINISH !!!";
                frm.lbCountDown.Text = "FINISH !!!";
            }

            if (isFinish == false)
            {
                min = TimerWatch.Elapsed.Minutes;
                sec = TimerWatch.Elapsed.Seconds;
                milisec = TimerWatch.Elapsed.Milliseconds;

                this.lbWatch1.Text = min.ToString("00") + ":" + sec.ToString("00") + "." + milisec.ToString("000");
                frm.lbWatch.Text = min.ToString("00") + ":" + sec.ToString("00") + "." + milisec.ToString("000");
            }

            if (isFinish2 == false)
            {
                min = TimerWatch2.Elapsed.Minutes;
                sec = TimerWatch2.Elapsed.Seconds;
                milisec = TimerWatch2.Elapsed.Milliseconds;

                this.lbWatch2.Text = min.ToString("00") + ":" + sec.ToString("00") + "." + milisec.ToString("000");
                frm.lbWatch.Text = min.ToString("00") + ":" + sec.ToString("00") + "." + milisec.ToString("000");
            }
        }

        private void btn_both_Click(object sender, EventArgs e)
        {

        }

        private void btn_team_1_Click(object sender, EventArgs e)
        {
            min = TimerWatch.Elapsed.Minutes;
            sec = TimerWatch.Elapsed.Seconds;
            milisec = TimerWatch.Elapsed.Milliseconds;
            check_point++;
            System.IO.File.WriteAllText("result\\"+textBox_name_team_1.Text+".txt", "Team "+textBox_name_team_1.Text+":\nCheck point "+check_point.ToString()+": "+ min.ToString("00") + ":" + sec.ToString("00") + "." + milisec.ToString("000"));
        }

        private void btn_team_2_Click(object sender, EventArgs e)
        {
            min = TimerWatch2.Elapsed.Minutes;
            sec = TimerWatch2.Elapsed.Seconds;
            milisec = TimerWatch2.Elapsed.Milliseconds;
            check_point2++;
            System.IO.File.WriteAllText("result\\" + textBox_name_team_2.Text + ".txt", "Team " + textBox_name_team_2.Text + ":\nCheck point " + check_point2.ToString() + ": " + min.ToString("00") + ":" + sec.ToString("00") + "." + milisec.ToString("000"));
        }

        private void keyEvent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Q")
            {
                //this is key code for team 1
                min = TimerWatch.Elapsed.Minutes;
                sec = TimerWatch.Elapsed.Seconds;
                milisec = TimerWatch.Elapsed.Milliseconds;
                check_point++;
                System.IO.File.WriteAllText("result\\" + textBox_name_team_1.Text + ".txt", "Team " + textBox_name_team_1.Text + ":\nCheck point " + check_point.ToString() + ": " + min.ToString("00") + ":" + sec.ToString("00") + "." + milisec.ToString("000"));
            }
            if (e.KeyCode.ToString() == "P")
            {
                //this is key code for team 2
                min = TimerWatch2.Elapsed.Minutes;
                sec = TimerWatch2.Elapsed.Seconds;
                milisec = TimerWatch2.Elapsed.Milliseconds;
                check_point2++;
                System.IO.File.WriteAllText("result\\" + textBox_name_team_2.Text + ".txt", "Team " + textBox_name_team_2.Text + ":\nCheck point " + check_point2.ToString() + ": " + min.ToString("00") + ":" + sec.ToString("00") + "." + milisec.ToString("000"));
            }
        }

        private void CountDown_Tick(object sender, EventArgs e)
        {
            cntGo--;
            this.lbCountDown.Text = cntGo.ToString("00") + "  READY";
            frm.lbCountDown.Text = cntGo.ToString("00  READY");

            if (cntGo == 0)
            {
                TimerWatch2.Reset();
                TimerWatch.Reset();
                UART.Write("O");          // OPEN
                UART.Write("G");          // OPEN

                this.lbCountDown.Text = "GO !!!";
                frm.lbCountDown.Text = "GO !!!";
                bntGate.Text = "CLOSE";

                CountDown.Stop();
                Watch.Start();

                lbStripStatus.Text = "Timer is starting.";
            }
        }

        private void tbRx_TextChanged(object sender, EventArgs e)
        {
            tbRx.SelectionStart = tbRx.Text.Length; //Set the current caret position at the end
            tbRx.ScrollToCaret(); //Now scroll it automatically
        }

        Action<string> serialPortReceiveAction;
        private void UART_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialPortReceiveAction = serialPortReceiver;
            try
            {
                BeginInvoke(serialPortReceiveAction, UART.ReadExisting());
            }
            catch { }
        }

        private void serialPortReceiver(string input)
        {
            tbRx.Text += input;
            int tempt1 = input.IndexOf('a');
            int tempt2 = input.IndexOf('b');
            input = "";

            if (tempt1 > -1 && isPass == true)
            {
                min = TimerWatch.Elapsed.Minutes;
                sec = TimerWatch.Elapsed.Seconds;
                milisec = TimerWatch.Elapsed.Milliseconds;
                check_point++;
                isFinish = true;
            }
            else if (tempt1 > -1 && isPass == false)
            {
                isPass = true;
                TimerWatch.Reset();
                TimerWatch.Start();
            }

            if (tempt2 > -1 && isPass2 == true)
                isFinish2 = true;
            else if (tempt2 > -1 && isPass2 == false)
            {
                isPass2 = true;
                TimerWatch2.Reset();
                TimerWatch2.Start();
            }

            tbRx.Focus();
            tbRx.SelectionStart = tbRx.Text.Length;
        }
    }
}
