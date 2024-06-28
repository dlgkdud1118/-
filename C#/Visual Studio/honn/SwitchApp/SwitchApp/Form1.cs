using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score;
            score = Convert.ToInt32(textBox1.Text);

            switch(score)
            {

                case 5:
                    MessageBox.Show("あなたの成績はAランクです。", "結果");
                    break;

                case 4:
                    MessageBox.Show("あなたの成績はBランクです。", "結果");
                    break;
                case 3:
                    MessageBox.Show("あなたの成績はCランクです。", "結果");
                    break;
                default:
                    MessageBox.Show("あなたの成績はDランクです。", "結果");
                    break;
            }
        }
    }
}
