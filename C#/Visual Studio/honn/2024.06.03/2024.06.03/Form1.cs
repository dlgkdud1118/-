using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._06._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 person = new Class1(textBox1.Text, dateTimePicker1.Value.Date);
            MessageBox.Show(person.Name + "さんの年齢は" + Convert.ToString(person.GetAge()) + "歳です。");
        }
    }
}
