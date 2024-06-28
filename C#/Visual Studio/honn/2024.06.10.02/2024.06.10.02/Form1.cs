using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._06._10._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                this.BackColor = Color.Red;
            if (radioButton2.Checked)
                this.BackColor = Color.Blue;
            if (radioButton3.Checked)
                this.BackColor = Color.Green;
        }
    }
}
