using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._03._11._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       /* private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
/*            // TODO: このコード行はデータを 'database1DataSet.Table' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.tableTableAdapter.Fill(this.database1DataSet.Table);*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.Fill(this.database1DataSet.Table);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tableBindingSource.EndEdit();
                this.tableTableAdapter.Update(this.database1DataSet.Table);
                MessageBox.Show("Update successful!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
