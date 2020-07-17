using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public static string strtxt8;
        public static string strtxt9;
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            strtxt8 = textBox1.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            strtxt9 = textBox2.Text.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            if (textBox1.Text == String.Empty && textBox2.Text == String.Empty)
            {
                string command = "select * from Student";
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
                string command = "select * from Student where Sname='"+strtxt8+"'";
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
                string command = "select * from Student where SID='" + strtxt9 + "'";
                SqlCommand sqm = new SqlCommand();
                sqm.CommandText = command;
                sqm.Connection = connection;

                SqlDataAdapter sda = new SqlDataAdapter(sqm);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            if (textBox1.Text == String.Empty && textBox2.Text == String.Empty)
            {
                string command = "select * from Teacher";
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
                string command = "select * from Teacher where Tname='" + strtxt8 + "'";
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
                string command = "select * from Teacher where TID='" + strtxt9 +"'";
                SqlCommand sqm = new SqlCommand();
                sqm.CommandText = command;
                sqm.Connection = connection;

                SqlDataAdapter sda = new SqlDataAdapter(sqm);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            if (textBox1.Text == String.Empty && textBox2.Text == String.Empty)
            {
                string command = "select * from Course";
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
                string command = "select * from Course where Cname='" + strtxt8 + "'";
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
                string command = "select * from Course where CID='" + strtxt9 + "'";
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
            Form7 f7 = new Form7();
            f7.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.ShowDialog();
            this.Close();
        }
    }
}
