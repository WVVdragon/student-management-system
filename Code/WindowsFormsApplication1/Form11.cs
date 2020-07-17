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
    public partial class Form11 : Form
    {
        public static string strtxt19;
        public static string strtxt20;
        public static string strtxt21;
        public static string strtxt22;
        public static string strtxt23;
        public static string strtxt24;
        public static string strtxt25;
        public static string strtxt26;
        public static string strtxt27;
        public static string strtxt28;
        public static string strtxt29;
        public static string strtxt30;
        public static string strtxt31;
        public static string strtxt32;
        public static string strtxt33;
        public static string strtxt34;
        public static string strtxt35;
        public static string strtxt36;
        public static string strtxt37;
        public static string strtxt38;

        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            strtxt19 = textBox1.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            strtxt20 = textBox2.Text.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            strtxt21 = textBox3.Text.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            strtxt22 = textBox4.Text.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            strtxt23 = textBox5.Text.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            strtxt24 = textBox6.Text.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            strtxt25 = textBox7.Text.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            strtxt26 = textBox8.Text.ToString();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            strtxt27 = textBox9.Text.ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            strtxt28 = textBox10.Text.ToString();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            strtxt29 = textBox11.Text.ToString();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            strtxt30 = textBox12.Text.ToString();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            strtxt31 = textBox13.Text.ToString();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            strtxt32 = textBox14.Text.ToString();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            strtxt33 = textBox15.Text.ToString();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            strtxt34 = textBox16.Text.ToString();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            strtxt35 = textBox17.Text.ToString();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            strtxt36 = textBox18.Text.ToString();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            strtxt37 = textBox19.Text.ToString();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            strtxt38 = textBox20.Text.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            if (radioButton1.Checked == true)
            {
                string selectsql = "insert into student values('" + strtxt19 + "','" + strtxt20 + "','" + strtxt21 + "','" + strtxt22 + "','" + strtxt23 + "','" + strtxt24 + "')";
                SqlCommand cmd = new SqlCommand(selectsql, connection);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                MessageBox.Show("录入成功");
                connection.Close();
            }
            else if (radioButton2.Checked == true)
            {
                string selectsql = "insert into Teacher values('" + strtxt25 + "','" + strtxt26 + "','" + strtxt27 + "')"; 
                SqlCommand cmd = new SqlCommand(selectsql, connection);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                MessageBox.Show("录入成功");
                connection.Close();
            }
            else if (radioButton3.Checked == true)
            {
                string selectsql = "insert into Course values('" + strtxt28 + "','" + strtxt29 + "','" + strtxt30 + "','" + strtxt31 + "','" + strtxt32 + "','" + strtxt33 + "')";
                SqlCommand cmd = new SqlCommand(selectsql, connection);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                MessageBox.Show("录入成功");
                connection.Close();
            }
            else if (radioButton4.Checked == true)
            {
                string selectsql = "insert into Choose values('" + strtxt34 + "','" + strtxt35 + "','" + strtxt36 + "','" + strtxt37 + "','" + strtxt38 + "')";
                SqlCommand cmd = new SqlCommand(selectsql, connection);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                MessageBox.Show("录入成功");
                connection.Close();
            }
        }

       

    }
}
