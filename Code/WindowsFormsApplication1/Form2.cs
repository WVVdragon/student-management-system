using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 form1 = new Form1();
        string txt1 = Form1.strtxt1;

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            string command = "select * from Student where SID = '" + txt1 + "'";
            SqlCommand sqm = new SqlCommand();
            sqm.CommandText = command;
            sqm.Connection = connection;

            SqlDataAdapter sda = new SqlDataAdapter(sqm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            string command = "select * from Course";
            SqlCommand sqm = new SqlCommand();
            sqm.CommandText = command;
            sqm.Connection = connection;

            SqlDataAdapter sda = new SqlDataAdapter(sqm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            string command = "select Course.Cname,Choose.CID,Choose.Score from Choose,Course where Choose.SID = '"+txt1+"'and Course.CID = Choose.CID";
            SqlCommand sqm = new SqlCommand();
            sqm.CommandText = command;
            sqm.Connection = connection;

            SqlDataAdapter sda = new SqlDataAdapter(sqm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
