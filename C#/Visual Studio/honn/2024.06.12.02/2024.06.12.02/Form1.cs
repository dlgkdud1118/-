using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._06._12._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'database2DataSet1.Table' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.tableTableAdapter.Fill(this.database2DataSet1.Table);
            dataGridView1.DataSource = bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = from rs in database2DataSet1.Table
                        where rs.Price > 150000
                        orderby rs.Name
                        select rs;
            bindingSource1.DataSource = query;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = database2DataSet1.Table;
        }
    }
}
