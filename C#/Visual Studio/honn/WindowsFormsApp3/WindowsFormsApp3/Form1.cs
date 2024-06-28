using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 5;
            int b = -7;
            int value = this.Sum(a, b);
        }

        private int Sum(int left, int right)
        {
            int result = left + right;
            return result;
        }

        private void SetText(string text)
        {
            this.label.Text = text;
        }

        private void SetDisplayText(string text)
        {
            this.label.Text = "表示";
        }
    }
}
