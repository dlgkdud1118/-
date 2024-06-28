using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._06._07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int num1, num2;

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkValue())
                MessageBox.Show(Convert.ToString(num1 + num2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkValue())
                MessageBox.Show(Convert.ToString(num1 - num2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkValue())
                MessageBox.Show(Convert.ToString(num1 * num2));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkValue())
            {
                double a = num1 / (double)num2;
                MessageBox.Show(Convert.ToString(a));
            }
        }

        private bool checkValue()
        {
            try
            {
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);
                return true;
            }

            catch
            {
                MessageBox.Show("A欄とB欄に数字を入力して下さい。", "エラー");
                return false;
            }
            // テキストボクスをクリアする
            finally
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }


       
    }
}
