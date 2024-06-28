using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._06._10._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check1, check2, check3, total;
            check1 = 0;
            check2 = 0;
            check3 = 0;

            if (checkBox1.Checked)
                check1 = 500;
            if (checkBox2.Checked)
                check2 = 600;
            if (checkBox3.Checked)
                check3 = 700;

            total = check1 + check2 + check3;
            MessageBox.Show("合計金額は" + total + "円です。", "計算結果");
        }
    }
}
