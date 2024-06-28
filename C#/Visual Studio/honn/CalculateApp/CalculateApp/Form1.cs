using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateApp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price, quantity, subtotal, tax, total;
            const double TAX_RATE = 0.08;

            price = Convert.ToInt32(textBox1.Text);
            quantity = Convert.ToInt32(textBox2.Text);
            subtotal = price * quantity;
            tax = (int)(subtotal * TAX_RATE);
            total = subtotal + tax;

            label6.Text = String.Format("{0:0,000}", subtotal);
            label7.Text = String.Format("{0:0,000}", tax);
            label8.Text = String.Format("{0:0,000}", total);
        }


    }

}
