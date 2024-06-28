using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foreachApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[,] array = new int[2, 5];

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frmDialog = new Form2();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    frmDialog.Text = (i + 1) + "行目の" + (j + 1) + "列目の要素";
                    frmDialog.ShowDialog();
                    array[i, j] = Convert.ToInt32(frmDialog.textBox1.Text);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strResult = "";
            
            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    strResult = strResult + array[i, j] + ",";
                }
                strResult += "\r\n";
            }
            textBox1.Text = strResult;
        }
    }
}
