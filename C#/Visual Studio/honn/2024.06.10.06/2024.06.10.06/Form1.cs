using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._06._10._06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("プログラムを終了します。", "終了");
            Application.Exit();
        }
    }
}
