using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _2024._06._11._01
{
    public partial class Form1 : Form
    {
        private SqlConnection cn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader rd;
        private string cnstr =
            @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            @"AttachDbFilename=|DataDirectory|\Database1.mdf;" +
            "Integrated Security=True;" +
            "Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = cnstr;
            cn.Open();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Table]";

            rd = cmd.ExecuteReader();
            while (rd.Read())
                listBox1.Items.Add(
                    String.Format("[{0}] {1,-10} {2,-10} {3,-30} [Tel]{4}",
                                  rd["Id"], rd["Name"], rd["ZipCode"],
                                  rd["Address"], rd["Tel"]));
            rd.Close();
            cn.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cn.ConnectionString = cnstr;
            cn.Open();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Table]" +
                              "WHERE Id='" + textBox1.Text + "'";
            rd = cmd.ExecuteReader();
            while (rd.Read())
                listBox1.Items.Add(
                    String.Format("[{0}] {1,-10} {2,-10} {3,-30} [Tel]{4}",
                                  rd["Id"], rd["Name"], rd["ZipCode"],
                                  rd["Address"], rd["Tel"]));
            rd.Close();
            cn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = cnstr;
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Table]" +
                              "WHERE Address Like N'%" + textBox2.Text + "%'";
            rd = cmd.ExecuteReader();
            while (rd.Read())
                listBox1.Items.Add(
                    String.Format("[{0}] {1,-10} {2,-10} {3,-30} [Tel]{4}", 
                                   rd["Id"], rd["Name"], rd["ZipCode"], 
                                   rd["Address"], rd["Tel"]));
            rd.Close();
            cn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }
    }
}
