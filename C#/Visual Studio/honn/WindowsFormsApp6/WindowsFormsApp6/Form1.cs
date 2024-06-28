using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNotice_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("送信しました。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.labelNotice.Text = result.ToString();
        }

        private void buttonError_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("エラーが発生しました。ログをひょうじしますか。",
                "異常",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error);
            this.labelError.Text = result.ToString();
            if(result == DialogResult.Yes)
            {
                return;
            }

            if(result == DialogResult.No)
            {
                return;
            }
        }

        private void buttonWarn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("データを削除しますか?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            this.labelWarn.Text = result.ToString();
            switch(result)
            {
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
        }
    }
}
