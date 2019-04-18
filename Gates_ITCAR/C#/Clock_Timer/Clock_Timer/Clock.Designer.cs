namespace Clock_Timer
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
            this.lbClock = new System.Windows.Forms.Label();
            this.bntStart = new System.Windows.Forms.Button();
            this.bntStop = new System.Windows.Forms.Button();
            this.bntReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbCOM = new System.Windows.Forms.ComboBox();
            this.lbBa = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gbTx = new System.Windows.Forms.GroupBox();
            this.gbRx = new System.Windows.Forms.GroupBox();
            this.bntSend = new System.Windows.Forms.Button();
            this.bntRead = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbClock
            // 
            this.lbClock.AutoSize = true;
            this.lbClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.Location = new System.Drawing.Point(27, 22);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(220, 55);
            this.lbClock.TabIndex = 0;
            this.lbClock.Text = "00:00:00";
            // 
            // bntStart
            // 
            this.bntStart.Location = new System.Drawing.Point(3, 89);
            this.bntStart.Name = "bntStart";
            this.bntStart.Size = new System.Drawing.Size(86, 53);
            this.bntStart.TabIndex = 2;
            this.bntStart.Text = "START";
            this.bntStart.UseVisualStyleBackColor = true;
            this.bntStart.Click += new System.EventHandler(this.lbStart_Click);
            // 
            // bntStop
            // 
            this.bntStop.Location = new System.Drawing.Point(95, 89);
            this.bntStop.Name = "bntStop";
            this.bntStop.Size = new System.Drawing.Size(86, 53);
            this.bntStop.TabIndex = 3;
            this.bntStop.Text = "STOP";
            this.bntStop.UseVisualStyleBackColor = true;
            this.bntStop.Click += new System.EventHandler(this.lbStop_Click);
            // 
            // bntReset
            // 
            this.bntReset.Location = new System.Drawing.Point(187, 89);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(86, 53);
            this.bntReset.TabIndex = 4;
            this.bntReset.Text = "RESET";
            this.bntReset.UseVisualStyleBackColor = true;
            this.bntReset.Click += new System.EventHandler(this.lbReset_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbCOM
            // 
            this.lbCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbCOM.FormattingEnabled = true;
            this.lbCOM.Location = new System.Drawing.Point(336, 52);
            this.lbCOM.Name = "lbCOM";
            this.lbCOM.Size = new System.Drawing.Size(121, 21);
            this.lbCOM.TabIndex = 5;
            // 
            // lbBa
            // 
            this.lbBa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbBa.FormattingEnabled = true;
            this.lbBa.Location = new System.Drawing.Point(336, 81);
            this.lbBa.Name = "lbBa";
            this.lbBa.Size = new System.Drawing.Size(121, 21);
            this.lbBa.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(336, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(121, 25);
            this.progressBar1.TabIndex = 7;
            // 
            // gbTx
            // 
            this.gbTx.Location = new System.Drawing.Point(3, 177);
            this.gbTx.Name = "gbTx";
            this.gbTx.Size = new System.Drawing.Size(208, 169);
            this.gbTx.TabIndex = 8;
            this.gbTx.TabStop = false;
            this.gbTx.Text = "Transfer";
            // 
            // gbRx
            // 
            this.gbRx.Location = new System.Drawing.Point(249, 177);
            this.gbRx.Name = "gbRx";
            this.gbRx.Size = new System.Drawing.Size(208, 169);
            this.gbRx.TabIndex = 9;
            this.gbRx.TabStop = false;
            this.gbRx.Text = "Receive";
            // 
            // bntSend
            // 
            this.bntSend.Location = new System.Drawing.Point(127, 352);
            this.bntSend.Name = "bntSend";
            this.bntSend.Size = new System.Drawing.Size(84, 24);
            this.bntSend.TabIndex = 10;
            this.bntSend.Text = "Send";
            this.bntSend.UseVisualStyleBackColor = true;
            // 
            // bntRead
            // 
            this.bntRead.Location = new System.Drawing.Point(373, 352);
            this.bntRead.Name = "bntRead";
            this.bntRead.Size = new System.Drawing.Size(84, 24);
            this.bntRead.TabIndex = 11;
            this.bntRead.Text = "Read";
            this.bntRead.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(352, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 63);
            this.button1.TabIndex = 12;
            this.button1.Text = "OPEN PORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clock
            // 
            this.ClientSize = new System.Drawing.Size(479, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntRead);
            this.Controls.Add(this.bntSend);
            this.Controls.Add(this.gbRx);
            this.Controls.Add(this.gbTx);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbBa);
            this.Controls.Add(this.lbCOM);
            this.Controls.Add(this.bntReset);
            this.Controls.Add(this.bntStop);
            this.Controls.Add(this.bntStart);
            this.Controls.Add(this.lbClock);
            this.MaximizeBox = false;
            this.Name = "Clock";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.Button bntStart;
        private System.Windows.Forms.Button bntStop;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox lbCOM;
        private System.Windows.Forms.ComboBox lbBa;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox gbTx;
        private System.Windows.Forms.GroupBox gbRx;
        private System.Windows.Forms.Button bntSend;
        private System.Windows.Forms.Button bntRead;
        private System.Windows.Forms.Button button1;
    }
}

