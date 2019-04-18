namespace Serial_Port
{
    partial class Clock
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
            this.bntOpenPort = new System.Windows.Forms.Button();
            this.bntRead = new System.Windows.Forms.Button();
            this.bntSend = new System.Windows.Forms.Button();
            this.gbRx = new System.Windows.Forms.GroupBox();
            this.tbRx = new System.Windows.Forms.TextBox();
            this.pbOpenPort = new System.Windows.Forms.ProgressBar();
            this.cbBaur = new System.Windows.Forms.ComboBox();
            this.cbCOM = new System.Windows.Forms.ComboBox();
            this.bntReset = new System.Windows.Forms.Button();
            this.bntStop = new System.Windows.Forms.Button();
            this.bntStart = new System.Windows.Forms.Button();
            this.lbClock = new System.Windows.Forms.Label();
            this.gbTx = new System.Windows.Forms.GroupBox();
            this.tbTx = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Startwatch = new System.Windows.Forms.Timer(this.components);
            this.gbRx.SuspendLayout();
            this.gbTx.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntOpenPort
            // 
            this.bntOpenPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntOpenPort.Location = new System.Drawing.Point(308, 124);
            this.bntOpenPort.Name = "bntOpenPort";
            this.bntOpenPort.Size = new System.Drawing.Size(148, 43);
            this.bntOpenPort.TabIndex = 24;
            this.bntOpenPort.Text = "OPEN PORT";
            this.bntOpenPort.UseVisualStyleBackColor = true;
            this.bntOpenPort.Click += new System.EventHandler(this.bntOpenPort_Click);
            // 
            // bntRead
            // 
            this.bntRead.Location = new System.Drawing.Point(378, 346);
            this.bntRead.Name = "bntRead";
            this.bntRead.Size = new System.Drawing.Size(84, 24);
            this.bntRead.TabIndex = 23;
            this.bntRead.Text = "Read";
            this.bntRead.UseVisualStyleBackColor = true;
            this.bntRead.Click += new System.EventHandler(this.bntRead_Click);
            // 
            // bntSend
            // 
            this.bntSend.Location = new System.Drawing.Point(132, 346);
            this.bntSend.Name = "bntSend";
            this.bntSend.Size = new System.Drawing.Size(84, 24);
            this.bntSend.TabIndex = 22;
            this.bntSend.Text = "Send";
            this.bntSend.UseVisualStyleBackColor = true;
            this.bntSend.Click += new System.EventHandler(this.bntSend_Click);
            // 
            // gbRx
            // 
            this.gbRx.Controls.Add(this.tbRx);
            this.gbRx.Location = new System.Drawing.Point(254, 171);
            this.gbRx.Name = "gbRx";
            this.gbRx.Size = new System.Drawing.Size(208, 169);
            this.gbRx.TabIndex = 21;
            this.gbRx.TabStop = false;
            this.gbRx.Text = "Receive";
            // 
            // tbRx
            // 
            this.tbRx.Enabled = false;
            this.tbRx.Location = new System.Drawing.Point(6, 19);
            this.tbRx.Multiline = true;
            this.tbRx.Name = "tbRx";
            this.tbRx.Size = new System.Drawing.Size(196, 144);
            this.tbRx.TabIndex = 1;
            // 
            // pbOpenPort
            // 
            this.pbOpenPort.Location = new System.Drawing.Point(308, 12);
            this.pbOpenPort.Name = "pbOpenPort";
            this.pbOpenPort.Size = new System.Drawing.Size(151, 25);
            this.pbOpenPort.TabIndex = 19;
            // 
            // cbBaur
            // 
            this.cbBaur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaur.FormattingEnabled = true;
            this.cbBaur.Items.AddRange(new object[] {
            "9600",
            "48600"});
            this.cbBaur.Location = new System.Drawing.Point(308, 83);
            this.cbBaur.Name = "cbBaur";
            this.cbBaur.Size = new System.Drawing.Size(107, 21);
            this.cbBaur.TabIndex = 18;
            // 
            // cbCOM
            // 
            this.cbCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCOM.FormattingEnabled = true;
            this.cbCOM.Location = new System.Drawing.Point(308, 54);
            this.cbCOM.Name = "cbCOM";
            this.cbCOM.Size = new System.Drawing.Size(107, 21);
            this.cbCOM.TabIndex = 17;
            // 
            // bntReset
            // 
            this.bntReset.Location = new System.Drawing.Point(192, 83);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(86, 53);
            this.bntReset.TabIndex = 16;
            this.bntReset.Text = "RESET";
            this.bntReset.UseVisualStyleBackColor = true;
            // 
            // bntStop
            // 
            this.bntStop.Location = new System.Drawing.Point(100, 83);
            this.bntStop.Name = "bntStop";
            this.bntStop.Size = new System.Drawing.Size(86, 53);
            this.bntStop.TabIndex = 15;
            this.bntStop.Text = "STOP";
            this.bntStop.UseVisualStyleBackColor = true;
            // 
            // bntStart
            // 
            this.bntStart.Location = new System.Drawing.Point(8, 83);
            this.bntStart.Name = "bntStart";
            this.bntStart.Size = new System.Drawing.Size(86, 53);
            this.bntStart.TabIndex = 14;
            this.bntStart.Text = "START";
            this.bntStart.UseVisualStyleBackColor = true;
            this.bntStart.Click += new System.EventHandler(this.bntStart_Click);
            // 
            // lbClock
            // 
            this.lbClock.AutoSize = true;
            this.lbClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.Location = new System.Drawing.Point(32, 16);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(248, 55);
            this.lbClock.TabIndex = 13;
            this.lbClock.Text = "00:00:000";
            // 
            // gbTx
            // 
            this.gbTx.Controls.Add(this.tbTx);
            this.gbTx.Location = new System.Drawing.Point(8, 171);
            this.gbTx.Name = "gbTx";
            this.gbTx.Size = new System.Drawing.Size(208, 169);
            this.gbTx.TabIndex = 20;
            this.gbTx.TabStop = false;
            this.gbTx.Text = "Transfer";
            // 
            // tbTx
            // 
            this.tbTx.Enabled = false;
            this.tbTx.Location = new System.Drawing.Point(6, 19);
            this.tbTx.Multiline = true;
            this.tbTx.Name = "tbTx";
            this.tbTx.Size = new System.Drawing.Size(196, 144);
            this.tbTx.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            // 
            // Startwatch
            // 
            this.Startwatch.Interval = 1;
            this.Startwatch.Tick += new System.EventHandler(this.Stopwatch_Tick);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 383);
            this.Controls.Add(this.bntOpenPort);
            this.Controls.Add(this.bntRead);
            this.Controls.Add(this.bntSend);
            this.Controls.Add(this.gbRx);
            this.Controls.Add(this.gbTx);
            this.Controls.Add(this.pbOpenPort);
            this.Controls.Add(this.cbBaur);
            this.Controls.Add(this.cbCOM);
            this.Controls.Add(this.bntReset);
            this.Controls.Add(this.bntStop);
            this.Controls.Add(this.bntStart);
            this.Controls.Add(this.lbClock);
            this.Name = "Clock";
            this.Text = "Serial Port";
            this.gbRx.ResumeLayout(false);
            this.gbRx.PerformLayout();
            this.gbTx.ResumeLayout(false);
            this.gbTx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntOpenPort;
        private System.Windows.Forms.Button bntRead;
        private System.Windows.Forms.Button bntSend;
        private System.Windows.Forms.GroupBox gbRx;
        private System.Windows.Forms.ProgressBar pbOpenPort;
        private System.Windows.Forms.ComboBox cbBaur;
        private System.Windows.Forms.ComboBox cbCOM;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.Button bntStop;
        private System.Windows.Forms.Button bntStart;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.TextBox tbRx;
        private System.Windows.Forms.GroupBox gbTx;
        private System.Windows.Forms.TextBox tbTx;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer Startwatch;
    }
}

