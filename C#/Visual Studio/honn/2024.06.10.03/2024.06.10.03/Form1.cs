using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _2024._06._10._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                MessageBox.Show("項目が未選択です", "エラー");
            else
            {
                string select = "";
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                    select = select + listBox1.SelectedItems[i].ToString() + "\r\n";
                }
                MessageBox.Show(select, "以下の項目が選択されました。");
            }
        }
    }
}
