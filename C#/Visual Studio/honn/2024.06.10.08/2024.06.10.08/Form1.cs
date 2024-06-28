using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._06._10._08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DateTime dat = DateTime.Now;
            label1.Text = dat.ToLongDateString();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DateTime dat = DateTime.Now;
            label1.Text = dat.ToShortTimeString();
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
