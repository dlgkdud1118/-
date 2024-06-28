using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.RunWhile();
        }

        private void RunFor()
        {
            int max = 3;
            List<int> list = new List<int>();

            for(int i = 0; i < max; i++)
            {
                list.Add(i);
                Console.WriteLine(i.ToString() + "が追加されました");
            }
        }

        private void RunWhile()
        {
            List<string> list = new List<string>() { "X", "Y", "Z" };
            int i = 0;
            bool isRun = true;
            while(isRun)
            {
                if(i !=2)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(list[i] + "が追加されました");
                isRun = false;
            }
        }
    }
}
