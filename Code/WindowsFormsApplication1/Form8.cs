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
    public partial class Form8 : Form
    {
        public static string strtxt12;
        public static string strtxt13;
        public Form8()
        {
            InitializeComponent();
        }
        private void Form8_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            strtxt12 = textBox1.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            strtxt13 = textBox2.Text.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            if (textBox1.Text == String.Empty && textBox2.Text == String.Empty)
            {
                string command = "select Sname as '学生名',avg(Score) as '平均成绩' from Student,Choose where Student.SID = Choose.SID group by Sname";
                SqlCommand sqm = new SqlCommand();
                sqm.CommandText = command;
                sqm.Connection = connection;

                SqlDataAdapter sda = new SqlDataAdapter(sqm);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (textBox1.Text != String.Empty && textBox2.Text == String.Empty)
            {
                string command = "select Sname as '学生名',avg(Score) as '平均成绩' from Student,Choose where Student.SID = Choose.SID and Sname = '" + strtxt12 + "' group by Sname";
                SqlCommand sqm = new SqlCommand();
                sqm.CommandText = command;
                sqm.Connection = connection;

                SqlDataAdapter sda = new SqlDataAdapter(sqm);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else
            {
                string command = "select Sname as '学生名',avg(Score) as '平均成绩' from Student,Choose where Student.SID = Choose.SID and Student.SID = '" + strtxt13 + "' group by Sname";
                SqlCommand sqm = new SqlCommand();
                sqm.CommandText = command;
                sqm.Connection = connection;

                SqlDataAdapter sda = new SqlDataAdapter(sqm);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            if (textBox1.Text == String.Empty && textBox2.Text == String.Empty)
            {
                string command = "select Cname as '课程名',avg(Score) as '平均成绩' from Course,Choose where Course.CID = Choose.CID group by Cname";
                SqlCommand sqm = new SqlCommand();
                sqm.CommandText = command;
                sqm.Connection = connection;

                SqlDataAdapter sda = new SqlDataAdapter(sqm);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else if (textBox1.Text != String.Empty && textBox2.Text == String.Empty)
            {
                string command = "select Cname as '课程名',avg(Score) as '平均成绩' from Course,Choose where Course.CID = Choose.CID and Cname = '" + strtxt12 + "'group by Cname";
                SqlCommand sqm = new SqlCommand();
                sqm.CommandText = command;
                sqm.Connection = connection;

                SqlDataAdapter sda = new SqlDataAdapter(sqm);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            else
            {
                string command = "select Cname as '课程名',avg(Score) as '平均成绩' from Course,Choose where Course.CID = Choose.CID and Course.CID ='" + strtxt13 + "'group by Cname";
                SqlCommand sqm = new SqlCommand();
                sqm.CommandText = command;
                sqm.Connection = connection;

                SqlDataAdapter sda = new SqlDataAdapter(sqm);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
