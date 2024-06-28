using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._06._10._05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intBirthday;
            label2.Text = "選択した日付" + dateTimePicker1.Value.Date.ToString();
            intBirthday = dateTimePicker1.Value.Subtract(DateTime.Today).Days;
            label3.Text = "本日から次の誕生日まであと" + intBirthday.ToString() + "日";
        }
    }
}
