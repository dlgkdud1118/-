using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structure
{
    public partial class Form1 : Form
    {
        public struct Customer
        {
            public int Number;
            public string Name;
            public int Age;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer1;
            customer1.Number = Convert.ToInt32(textBox1.Text);
            customer1.Name = textBox2.Text;
            customer1.Age = Convert.ToInt32(textBox3.Text);

            MessageBox.Show(
                            "顧客番号 : " + customer1.Number + "\n" +
                            "氏名     : " + customer1.Name + "\n" +
                            "年令     : " + customer1.Age + "\n" ,
                            "データが入力されました"
                            );
        }
    }
}
