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
    public partial class Form7 : Form
    {
        public static string strtxt10;
        public static string strtxt11;
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            strtxt10 = textBox1.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            strtxt11 = textBox2.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            if (radioButton1.Checked == true)
            {
                if (textBox1.Text == String.Empty && textBox2.Text == String.Empty)
                {
                    string command = "select Student.SID as '学号',Sname as '名字',Cname as '课程名' from Student,Course,Choose where Student.SID = Choose.SID and Course.CID = Choose.CID";
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
                    string command = "select Choose.SID as '学号',Student.Sname as '名字',Course.Cname as '课程名' from Student,Course,Choose where Choose.SID = '" + strtxt10 + "'and Student.SID = Choose.SID and Course.CID = Choose.CID";
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
                    string command = "select Choose.SID as '学号',Sname as '名字',Cname as '课程名' from Student,Course,Choose where Student.SID = Choose.SID and Course.CID = Choose.CID and Sname = '" + strtxt11 + "'";
                    SqlCommand sqm = new SqlCommand();
                    sqm.CommandText = command;
                    sqm.Connection = connection;

                    SqlDataAdapter sda = new SqlDataAdapter(sqm);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (textBox1.Text == String.Empty && textBox2.Text == String.Empty)
                {
                    string command = "select Distinct Teacher.TID as '老师编号',Teacher.Tname as '老师', Course.Cname as '课程名' from Teacher,Course,Choose where Teacher.TID = Choose.TID and Course.CID = Choose.CID order by Tname";
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
                    string command = "select Distinct Teacher.TID as '老师编号',Teacher.Tname as '老师', Course.Cname as '课程名' from Teacher,Course,Choose where Teacher.TID = Choose.TID and Course.CID = Choose.CID and Teacher.TID = '"+strtxt10+"' order by Tname";
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
                    string command = "select Distinct Teacher.TID as '老师编号',Teacher.Tname as '老师', Course.Cname as '课程名' from Teacher,Course,Choose where Teacher.TID = Choose.TID and Course.CID = Choose.CID and Tname = '"+strtxt11+"' order by Tname";
                    SqlCommand sqm = new SqlCommand();
                    sqm.CommandText = command;
                    sqm.Connection = connection;

                    SqlDataAdapter sda = new SqlDataAdapter(sqm);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }
            }
            else if (radioButton3.Checked == true)
            {
                if (textBox1.Text == String.Empty && textBox2.Text == String.Empty)
                {
                    string command = "select Distinct Course.CID as '课程编号',Course.Cname as '课程名' from Course,Choose where Course.CID = Choose.CID";
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
                    string command = "select Distinct Course.CID as '课程编号',Course.Cname as '课程名' from Course,Choose where Course.CID = Choose.CID and Course.CID = '"+ strtxt10 + "'";
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
                    string command = "select Distinct Course.CID as '课程编号',Course.Cname as '课程名' from Course,Choose where Course.CID = Choose.CID and Course.Cname ='" + strtxt11 +"'" ;
                    SqlCommand sqm = new SqlCommand();
                    sqm.CommandText = command;
                    sqm.Connection = connection;

                    SqlDataAdapter sda = new SqlDataAdapter(sqm);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }
            }
            else if (radioButton4.Checked == true)
            {
                if (textBox1.Text == String.Empty && textBox2.Text == String.Empty)
                {
                    string command = "select Sname as '学生名',Cname as '课程名',Score as '成绩' from Choose,Student,Course where Student.SID = Choose.SID and Course.CID = Choose.CID";
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
                    string command = "select Sname as '学生名',Cname as '课程名',Score as '成绩' from Choose,Student,Course where Student.SID = Choose.SID and Course.CID = Choose.CID and Student.SID = '" + strtxt10 + "'";
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
                    string command = "select Sname as '学生名',Cname as '课程名',Score as '成绩' from Choose,Student,Course where Student.SID = Choose.SID and Course.CID = Choose.CID and Sname = '"+ strtxt11+ "'";
                    SqlCommand sqm = new SqlCommand();
                    sqm.CommandText = command;
                    sqm.Connection = connection;

                    SqlDataAdapter sda = new SqlDataAdapter(sqm);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
