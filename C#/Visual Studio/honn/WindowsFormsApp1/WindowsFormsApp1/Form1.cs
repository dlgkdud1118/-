using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            int one = 1;
            int three = 3;
            int four = one + three;

            four++;
            four++;
            four--;

            this.MessageLabel.Text = four.ToString();
        }

        private void actionButton_MouseHover(object sender, EventArgs e)
        {
            this.MessageLabel.Text = "マウスが乗りました。";
        }

        private void actionButton_MouseLeave(object sender, EventArgs e)
        {
            string hello = "こんにちは";
            string goodNight = "こんばんは";


            this.MessageLabel.Text = hello + goodNight;
        }
    }
}

