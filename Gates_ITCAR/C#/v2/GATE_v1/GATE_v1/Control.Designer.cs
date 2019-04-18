namespace GATE_v1
{
    partial class Control
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            this.checkShow = new System.Windows.Forms.CheckBox();
            this.bntClear = new System.Windows.Forms.Button();
            this.tbRx = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lbStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCountDown = new System.Windows.Forms.Label();
            this.lbWatch1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tbTx = new System.Windows.Forms.TextBox();
            this.bntSend = new System.Windows.Forms.Button();
            this.bntReady = new System.Windows.Forms.Button();
            this.bntStart = new System.Windows.Forms.Button();
            this.bntReset = new System.Windows.Forms.Button();
            this.bntGate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntConnect = new System.Windows.Forms.Button();
            this.cbBaur = new System.Windows.Forms.ComboBox();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.CountDown = new System.Windows.Forms.Timer(this.components);
            this.Watch = new System.Windows.Forms.Timer(this.components);
            this.UART = new System.IO.Ports.SerialPort(this.components);
            this.tbCount = new System.Windows.Forms.TextBox();
            this.bntMode = new System.Windows.Forms.Button();
            this.lbWatch2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_team_1 = new System.Windows.Forms.Button();
            this.btn_team_2 = new System.Windows.Forms.Button();
            this.btn_both = new System.Windows.Forms.Button();
            this.textBox_name_team_1 = new System.Windows.Forms.TextBox();
            this.textBox_name_team_2 = new System.Windows.Forms.TextBox();
            this.keyEvent = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkShow
            // 
            this.checkShow.AutoSize = true;
            this.checkShow.Location = new System.Drawing.Point(271, 102);
            this.checkShow.Margin = new System.Windows.Forms.Padding(4);
            this.checkShow.Name = "checkShow";
            this.checkShow.Size = new System.Drawing.Size(97, 21);
            this.checkShow.TabIndex = 67;
            this.checkShow.Text = "Show/Hide";
            this.checkShow.UseVisualStyleBackColor = true;
            this.checkShow.CheckedChanged += new System.EventHandler(this.checkShow_CheckedChanged);
            // 
            // bntClear
            // 
            this.bntClear.Location = new System.Drawing.Point(104, 206);
            this.bntClear.Margin = new System.Windows.Forms.Padding(4);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(56, 34);
            this.bntClear.TabIndex = 65;
            this.bntClear.Text = "Clear";
            this.bntClear.UseVisualStyleBackColor = true;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // tbRx
            // 
            this.tbRx.EnableAutoDragDrop = true;
            this.tbRx.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRx.Location = new System.Drawing.Point(17, 241);
            this.tbRx.Margin = new System.Windows.Forms.Padding(4);
            this.tbRx.Name = "tbRx";
            this.tbRx.Size = new System.Drawing.Size(359, 254);
            this.tbRx.TabIndex = 62;
            this.tbRx.Text = "";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStripStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 581);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1195, 25);
            this.statusStrip.TabIndex = 61;
            this.statusStrip.Text = "DISCONNECT";
            // 
            // lbStripStatus
            // 
            this.lbStripStatus.Name = "lbStripStatus";
            this.lbStripStatus.Size = new System.Drawing.Size(90, 20);
            this.lbStripStatus.Text = "DISCONNET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "RECEIVE:";
            // 
            // lbCountDown
            // 
            this.lbCountDown.AutoSize = true;
            this.lbCountDown.BackColor = System.Drawing.Color.Orange;
            this.lbCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountDown.Location = new System.Drawing.Point(758, 40);
            this.lbCountDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size(269, 54);
            this.lbCountDown.TabIndex = 45;
            this.lbCountDown.Text = "00  READY";
            // 
            // lbWatch1
            // 
            this.lbWatch1.AutoSize = true;
            this.lbWatch1.BackColor = System.Drawing.Color.White;
            this.lbWatch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWatch1.Location = new System.Drawing.Point(723, 267);
            this.lbWatch1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWatch1.Name = "lbWatch1";
            this.lbWatch1.Size = new System.Drawing.Size(304, 69);
            this.lbWatch1.TabIndex = 58;
            this.lbWatch1.Text = "00:00:000";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(265, 197);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(133, 28);
            this.progressBar.TabIndex = 57;
            // 
            // tbTx
            // 
            this.tbTx.Enabled = false;
            this.tbTx.Location = new System.Drawing.Point(17, 165);
            this.tbTx.Margin = new System.Windows.Forms.Padding(4);
            this.tbTx.Name = "tbTx";
            this.tbTx.Size = new System.Drawing.Size(267, 22);
            this.tbTx.TabIndex = 56;
            // 
            // bntSend
            // 
            this.bntSend.Enabled = false;
            this.bntSend.Location = new System.Drawing.Point(293, 164);
            this.bntSend.Margin = new System.Windows.Forms.Padding(4);
            this.bntSend.Name = "bntSend";
            this.bntSend.Size = new System.Drawing.Size(73, 26);
            this.bntSend.TabIndex = 55;
            this.bntSend.Text = "SEND";
            this.bntSend.UseVisualStyleBackColor = true;
            this.bntSend.Click += new System.EventHandler(this.bntSend_Click);
            // 
            // bntReady
            // 
            this.bntReady.Location = new System.Drawing.Point(93, 81);
            this.bntReady.Margin = new System.Windows.Forms.Padding(4);
            this.bntReady.Name = "bntReady";
            this.bntReady.Size = new System.Drawing.Size(69, 59);
            this.bntReady.TabIndex = 68;
            this.bntReady.Text = "READY";
            this.bntReady.Click += new System.EventHandler(this.bntReady_Click);
            // 
            // bntStart
            // 
            this.bntStart.Enabled = false;
            this.bntStart.Location = new System.Drawing.Point(171, 81);
            this.bntStart.Margin = new System.Windows.Forms.Padding(4);
            this.bntStart.Name = "bntStart";
            this.bntStart.Size = new System.Drawing.Size(89, 59);
            this.bntStart.TabIndex = 53;
            this.bntStart.Text = "START";
            this.bntStart.UseVisualStyleBackColor = true;
            this.bntStart.Click += new System.EventHandler(this.bntStart_Click);
            // 
            // bntReset
            // 
            this.bntReset.Location = new System.Drawing.Point(17, 81);
            this.bntReset.Margin = new System.Windows.Forms.Padding(4);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(68, 59);
            this.bntReset.TabIndex = 52;
            this.bntReset.Text = "RESET";
            this.bntReset.UseVisualStyleBackColor = true;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // bntGate
            // 
            this.bntGate.Enabled = false;
            this.bntGate.Location = new System.Drawing.Point(296, 15);
            this.bntGate.Margin = new System.Windows.Forms.Padding(4);
            this.bntGate.Name = "bntGate";
            this.bntGate.Size = new System.Drawing.Size(71, 59);
            this.bntGate.TabIndex = 51;
            this.bntGate.Text = "OPEN";
            this.bntGate.UseVisualStyleBackColor = true;
            this.bntGate.Click += new System.EventHandler(this.bntGate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "COM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "BAUR:";
            // 
            // bntConnect
            // 
            this.bntConnect.Location = new System.Drawing.Point(199, 15);
            this.bntConnect.Margin = new System.Windows.Forms.Padding(4);
            this.bntConnect.Name = "bntConnect";
            this.bntConnect.Size = new System.Drawing.Size(89, 59);
            this.bntConnect.TabIndex = 48;
            this.bntConnect.Text = "CONNECT";
            this.bntConnect.UseVisualStyleBackColor = true;
            this.bntConnect.Click += new System.EventHandler(this.bntConnect_Click);
            // 
            // cbBaur
            // 
            this.cbBaur.FormattingEnabled = true;
            this.cbBaur.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbBaur.Location = new System.Drawing.Point(72, 48);
            this.cbBaur.Margin = new System.Windows.Forms.Padding(4);
            this.cbBaur.Name = "cbBaur";
            this.cbBaur.Size = new System.Drawing.Size(117, 24);
            this.cbBaur.TabIndex = 47;
            // 
            // cbCom
            // 
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(72, 15);
            this.cbCom.Margin = new System.Windows.Forms.Padding(4);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(117, 24);
            this.cbCom.TabIndex = 46;
            // 
            // CountDown
            // 
            this.CountDown.Interval = 1000;
            this.CountDown.Tick += new System.EventHandler(this.CountDown_Tick);
            // 
            // Watch
            // 
            this.Watch.Interval = 1;
            this.Watch.Tick += new System.EventHandler(this.Watch_Tick);
            // 
            // UART
            // 
            this.UART.PortName = "COM15";
            this.UART.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.UART_DataReceived);
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(411, 18);
            this.tbCount.Margin = new System.Windows.Forms.Padding(4);
            this.tbCount.Multiline = true;
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(25, 24);
            this.tbCount.TabIndex = 69;
            this.tbCount.Text = "5";
            // 
            // bntMode
            // 
            this.bntMode.Enabled = false;
            this.bntMode.Location = new System.Drawing.Point(411, 52);
            this.bntMode.Margin = new System.Windows.Forms.Padding(4);
            this.bntMode.Name = "bntMode";
            this.bntMode.Size = new System.Drawing.Size(85, 53);
            this.bntMode.TabIndex = 70;
            this.bntMode.Text = "MODE 1";
            this.bntMode.UseVisualStyleBackColor = true;
            this.bntMode.Click += new System.EventHandler(this.bntMode_Click);
            // 
            // lbWatch2
            // 
            this.lbWatch2.AutoSize = true;
            this.lbWatch2.BackColor = System.Drawing.Color.White;
            this.lbWatch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWatch2.Location = new System.Drawing.Point(723, 336);
            this.lbWatch2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWatch2.Name = "lbWatch2";
            this.lbWatch2.Size = new System.Drawing.Size(304, 69);
            this.lbWatch2.TabIndex = 71;
            this.lbWatch2.Text = "00:00:000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(629, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(532, 481);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // btn_team_1
            // 
            this.btn_team_1.Location = new System.Drawing.Point(420, 255);
            this.btn_team_1.Name = "btn_team_1";
            this.btn_team_1.Size = new System.Drawing.Size(181, 23);
            this.btn_team_1.TabIndex = 73;
            this.btn_team_1.Text = "TEAM 1";
            this.btn_team_1.UseVisualStyleBackColor = true;
            this.btn_team_1.Click += new System.EventHandler(this.btn_team_1_Click);
            // 
            // btn_team_2
            // 
            this.btn_team_2.Location = new System.Drawing.Point(420, 346);
            this.btn_team_2.Name = "btn_team_2";
            this.btn_team_2.Size = new System.Drawing.Size(181, 23);
            this.btn_team_2.TabIndex = 74;
            this.btn_team_2.Text = "TEAM 2";
            this.btn_team_2.UseVisualStyleBackColor = true;
            this.btn_team_2.Click += new System.EventHandler(this.btn_team_2_Click);
            // 
            // btn_both
            // 
            this.btn_both.Location = new System.Drawing.Point(420, 417);
            this.btn_both.Name = "btn_both";
            this.btn_both.Size = new System.Drawing.Size(181, 23);
            this.btn_both.TabIndex = 75;
            this.btn_both.Text = "BOTH";
            this.btn_both.UseVisualStyleBackColor = true;
            this.btn_both.Click += new System.EventHandler(this.btn_both_Click);
            // 
            // textBox_name_team_1
            // 
            this.textBox_name_team_1.Location = new System.Drawing.Point(420, 218);
            this.textBox_name_team_1.Name = "textBox_name_team_1";
            this.textBox_name_team_1.Size = new System.Drawing.Size(181, 22);
            this.textBox_name_team_1.TabIndex = 76;
            // 
            // textBox_name_team_2
            // 
            this.textBox_name_team_2.Location = new System.Drawing.Point(420, 307);
            this.textBox_name_team_2.Name = "textBox_name_team_2";
            this.textBox_name_team_2.Size = new System.Drawing.Size(181, 22);
            this.textBox_name_team_2.TabIndex = 77;
            // 
            // keyEvent
            // 
            this.keyEvent.Location = new System.Drawing.Point(420, 389);
            this.keyEvent.Name = "keyEvent";
            this.keyEvent.Size = new System.Drawing.Size(181, 22);
            this.keyEvent.TabIndex = 78;
            this.keyEvent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyEvent_KeyDown);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 606);
            this.Controls.Add(this.keyEvent);
            this.Controls.Add(this.textBox_name_team_2);
            this.Controls.Add(this.textBox_name_team_1);
            this.Controls.Add(this.btn_both);
            this.Controls.Add(this.btn_team_2);
            this.Controls.Add(this.btn_team_1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbWatch2);
            this.Controls.Add(this.bntMode);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.checkShow);
            this.Controls.Add(this.bntClear);
            this.Controls.Add(this.tbRx);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCountDown);
            this.Controls.Add(this.lbWatch1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tbTx);
            this.Controls.Add(this.bntSend);
            this.Controls.Add(this.bntReady);
            this.Controls.Add(this.bntStart);
            this.Controls.Add(this.bntReset);
            this.Controls.Add(this.bntGate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntConnect);
            this.Controls.Add(this.cbBaur);
            this.Controls.Add(this.cbCom);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Control";
            this.Text = "Control";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkShow;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.RichTextBox tbRx;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lbStripStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCountDown;
        private System.Windows.Forms.Label lbWatch1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox tbTx;
        private System.Windows.Forms.Button bntSend;
        private System.Windows.Forms.Button bntReady;
        private System.Windows.Forms.Button bntStart;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.Button bntGate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntConnect;
        private System.Windows.Forms.ComboBox cbBaur;
        private System.Windows.Forms.ComboBox cbCom;
        private System.Windows.Forms.Timer CountDown;
        private System.Windows.Forms.Timer Watch;
        private System.IO.Ports.SerialPort UART;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Button bntMode;
        private System.Windows.Forms.Label lbWatch2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_team_1;
        private System.Windows.Forms.Button btn_team_2;
        private System.Windows.Forms.Button btn_both;
        private System.Windows.Forms.TextBox textBox_name_team_1;
        private System.Windows.Forms.TextBox textBox_name_team_2;
        private System.Windows.Forms.TextBox keyEvent;
    }
}

