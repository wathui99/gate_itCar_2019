namespace GATE_v1
{
    partial class ShowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowForm));
            this.lbWatch = new System.Windows.Forms.Label();
            this.lbCountDown = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWatch
            // 
            resources.ApplyResources(this.lbWatch, "lbWatch");
            this.lbWatch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbWatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbWatch.Name = "lbWatch";
            // 
            // lbCountDown
            // 
            resources.ApplyResources(this.lbCountDown, "lbCountDown");
            this.lbCountDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbCountDown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCountDown.Name = "lbCountDown";
            // 
            // ShowForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lbCountDown);
            this.Controls.Add(this.lbWatch);
            this.Name = "ShowForm";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lbWatch;
        public System.Windows.Forms.Label lbCountDown;
    }
}