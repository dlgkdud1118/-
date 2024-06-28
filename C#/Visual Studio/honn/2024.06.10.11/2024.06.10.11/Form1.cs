using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing;

namespace _2024._06._10._11
{
    public partial class Form1 : Form
    {
        private string strPrint;
        private PageSettings pageSetting = new PageSettings();

        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string saveFileName;

            if (saveFileDialog1.ShowDialog() ==DialogResult.OK)
            {
                saveFileName = saveFileDialog1.FileName;
            }
            else
            {
                return;
            }
            StreamWriter textFile =
                new StreamWriter(
                    new FileStream(saveFileName, FileMode.Create)
                    );textFile.Write(textBox1.Text);
            textFile.Close();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string openFileName;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileName = openFileDialog1.FileName;
            }
            else
            {
                return;
            }

            textBox1.Clear();
            StreamReader textFile = new StreamReader(openFileName);
            textBox1.Text = textFile.ReadToEnd();
            textFile.Close();
        }

        private void Menu2_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.DefaultPageSettings = pageSetting;
                strPrint = textBox1.Text;
                printDialog1.Document = printDocument1;

                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー");
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font Fontsize = new Font("MS UI Gothic", 11);
            int intNumberChars;
            int intNumberLines;
            string strPrintString;
            StringFormat strFormat = new StringFormat();

            RectangleF rectSquare =
                new RectangleF(e.MarginBounds.Left,
                               e.MarginBounds.Top,
                               e.MarginBounds.Width,
                               e.MarginBounds.Height
                               );

            SizeF SquareSize =
                new SizeF(e.MarginBounds.Width,
                          e.MarginBounds.Height -
                            Fontsize.GetHeight(e.Graphics)
                            );

            e.Graphics.MeasureString(strPrint,
                                     Fontsize,
                                     SquareSize,
                                     strFormat,
                                     out intNumberChars,
                                     out intNumberLines
                                     );

            strPrintString = strPrint.Substring(
                                                    0, intNumberChars
                                                );

            e.Graphics.DrawString(strPrintString,
                                  Fontsize,
                                  Brushes.Black,
                                  rectSquare,
                                  strFormat
                                  );

            if (intNumberChars < strPrint.Length)
            {
                strPrint = strPrint.Substring(intNumberChars);
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                strPrint = textBox1.Text;
            }
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings = pageSetting;
            strPrint = textBox1.Text;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = pageSetting;
            pageSetupDialog1.ShowDialog();
        }
    }
}
