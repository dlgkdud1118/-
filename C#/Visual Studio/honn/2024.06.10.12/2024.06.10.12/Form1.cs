using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._06._10._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 frmChild = new Form2();
            frmChild.MdiParent = this;
            frmChild.Text = frmChild.Text + ":" + this.MdiChildren.Length;
            frmChild.Show();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox mdi = (RichTextBox)ActiveMdiChild.ActiveControl;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    mdi.LoadFile(openFileDialog1.FileName);
                }
            }
            catch
            {
                MessageBox.Show( 
                    "ファイルを展開するためのウィンドウが開いていません。", "エラー");
            }
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox mdi = (RichTextBox)ActiveMdiChild.ActiveControl;
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    mdi.SaveFile(saveFileDialog1.FileName);
                }
            }
            catch
            {
                MessageBox.Show( 
                "保存対象のウィンドウが開いていません", "エラー");
            }
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            RichTextBox mdi = (RichTextBox)ActiveMdiChild.ActiveControl;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                mdi.SelectionFont = this.fontDialog1.Font;
                mdi.SelectionColor = this.fontDialog1.Color;
            }
        }
    }
}
