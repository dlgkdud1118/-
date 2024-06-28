using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButton_Ａ.Checked)
            {
                this.button_A.Enabled = true;
            }
            else
            {
                this.button_A.Enabled = false;
            }
        }

        private void radioButton_Ｂ_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButton_Ｂ.Checked)
            {
                this.button_B.Enabled = true;
            }
            else 
            {
                this.button_B.Enabled = false;
            }
        }
    }
}
