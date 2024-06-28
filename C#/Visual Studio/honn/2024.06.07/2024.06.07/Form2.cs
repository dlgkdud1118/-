using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._06._07
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string[] user1 = { "taro", "tr1234" };
        private string[] user2 = { "hanako", "hn1234" };

        private void auth()
        {
            MessageBox.Show("パスワードを受け付けました。");
            this.Close();
        }
        private void noauth()
        {
            MessageBox.Show("認証できません。");
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "taro":
                    if(textBox2.Text == user1[1])
                    {
                        auth();
                        break;
                    }
                    else
                    {
                        goto default;
                    }
                case "hanako":
                    if (textBox2.Text == user2[1])
                    {
                        auth(); ;
                        break;
                    }
                    else
                    {
                        goto default;
                    }

                default:
                    noauth();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void Form2_Load_1(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
