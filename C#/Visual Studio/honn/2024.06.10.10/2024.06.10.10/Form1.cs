using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._06._10._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DateTime datStart;

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dat1 = DateTime.Now;
            TimeSpan timespan = dat1 - datStart;
            label1.Text = timespan.Minutes.ToString("00") + ":"
                + timespan.Seconds.ToString("00") + ":"
                + timespan.Milliseconds.ToString("000");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datStart = DateTime.Now;
            timer1.Enabled = true;
            this.button1.Enabled = false;
            this.button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "00:00:000";
            this.button1.Enabled = true;
        }
    }
}
