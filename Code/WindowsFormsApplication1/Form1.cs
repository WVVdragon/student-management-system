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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string strtxt1;
        public static string strtxt2;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            strtxt1 = textBox1.Text.ToString();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            strtxt2 = textBox2.Text.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            if (radioButton3.Checked == true)
            {
                string command = "select count('MID') from permission3 where MID='" + strtxt1 + "'";
                SqlCommand mySqlCommand = new SqlCommand(command, connection);
                int i = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                if (i == 0) MessageBox.Show("用户不存在");
                else
                {
                    command = "select count('MID') from permission3 where MID='" + strtxt1 + "'and MPW='" + strtxt2 + "'";
                    SqlCommand sql = new SqlCommand(command, connection);
                    int j = Convert.ToInt32(sql.ExecuteScalar());
                    if (j != 0)
                    {
                        MessageBox.Show("成功");
                        Form4 f4 = new Form4();
                        f4.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("密码错误");

                }
            }
            else if (radioButton2.Checked == true)
            {
                string command = "select count('TID') from permission2 where TID='" + strtxt1 + "'";
                SqlCommand mySqlCommand = new SqlCommand(command, connection);
                int i = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                if (i == 0) MessageBox.Show("用户不存在");
                else
                {
                    command = "select count('TID') from permission2 where TID='" + strtxt1 + "'and TPW='" + strtxt2 + "'";
                    SqlCommand sql = new SqlCommand(command, connection);
                    int j = Convert.ToInt32(sql.ExecuteScalar());
                    if (j != 0)
                    {
                        MessageBox.Show("成功");
                        Form3 f3 = new Form3();
                        f3.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("密码错误");
                }

            }
            else if (radioButton1.Checked == true)
            {
                string command = "select count('SID') from permission1 where SID='" + strtxt1 + "'";
                SqlCommand mySqlCommand = new SqlCommand(command, connection);
                int i = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                if (i == 0) MessageBox.Show("用户不存在");
                else
                {
                    command = "select count('SID') from permission1 where SID='" + strtxt1 + "'and SPW='" + strtxt2 + "'";
                    SqlCommand sql = new SqlCommand(command, connection);
                    int j = Convert.ToInt32(sql.ExecuteScalar());
                    if (j != 0)
                    {
                        MessageBox.Show("成功");
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("密码错误");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        

        
    }
}
