using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");

            DataRow dr = dt.NewRow();
            dr["id"] = "10";
            dr["name"] = "肉";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["id"] = "11";
            dr["name"] = "魚";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["id"] = "12";
            dr["name"] = "野菜";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["id"] = "13";
            dr["name"] = "果物";
            dt.Rows.Add(dr);

            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.ValueMember = "id";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = this.comboBox1.SelectedIndex;
            string value = this.comboBox1.SelectedValue.ToString();
            return;
        }

        private void buttonIndex_Click(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 1;
        }

        private void buttonValue_Click(object sender, EventArgs e)
        {
            this.comboBox1.SelectedValue = "13";
        }
    }
}
