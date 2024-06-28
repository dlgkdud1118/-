using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementInterface
{
    public partial class Form1 : Form
    {
        ISample obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj = new Cls1();
            Do ();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj = new Cls2();
            Do ();
        }

        private void Do()
        {
            obj.DoCalc(Int32.Parse(textBox1.Text));
        }
    }
}
