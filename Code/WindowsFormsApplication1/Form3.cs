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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            string command = "select * from Student";
            SqlCommand sqm = new SqlCommand();
            sqm.CommandText = command;
            sqm.Connection = connection;

            SqlDataAdapter sda = new SqlDataAdapter(sqm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            string command = "select Student.Sname,Course.Cname,Choose.Score from Choose,Course,Student where Course.CID = Choose.CID and Choose.SID = Student.SID";
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

            string command = "select Cname,avg(Score) as average from Course,Choose where Course.CID = Choose.CID group by Cname";
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
            Form6 f6 = new Form6();
            f6.ShowDialog();
            this.Close();
        }
           
    }
}
