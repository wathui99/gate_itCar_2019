using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GATE_v1
{
    public partial class ShowForm : Form
    {
        int fontSize = 72,
            widthForm = 640;
        float ratio;

        private Control mainForm = null;

        public ShowForm(Form callingForm)
        {
            mainForm = callingForm as Control;
            InitializeComponent();
        
            lbWatch.AutoSize = false;
            int position = (this.Size.Width - lbWatch.Size.Width) / 2;
            lbWatch.Location = new Point(position, lbWatch.Location.Y);

            position = (this.Size.Width - lbCountDown.Size.Width) / 2;
            lbCountDown.Location = new Point(position, lbCountDown.Location.Y);
        }

        private void ShowForm_Resize(object sender, EventArgs e)
        {
            ratio = (float)this.Width / (float)widthForm;
            lbWatch.Font = new Font("Times New Roman", 144);
        }
    }
}
