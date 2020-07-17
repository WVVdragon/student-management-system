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
    public partial class Form9 : Form
    {
        public static string strtxt14;
        public static string strtxt15;
        public static string strtxt16;
        public Form9()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            strtxt14 = textBox1.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            strtxt15 = textBox2.Text.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            strtxt16 = textBox3.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            if (radioButton1.Checked == true)
            {
                string command = "update Student set "+strtxt14+" = '"+strtxt16+"' where SID = '"+strtxt15+"'";
                SqlCommand sqlc = new SqlCommand(command, connection);
                sqlc.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = sqlc.ExecuteReader();
                MessageBox.Show("修改成功");
            }
            else if (radioButton2.Checked == true)
            {
                string command = "update teacher set " + strtxt14 + " = '" + strtxt16 + "' where TID = '" + strtxt15 + "'";
                SqlCommand sqlc = new SqlCommand(command, connection);
                sqlc.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = sqlc.ExecuteReader();
                MessageBox.Show("修改成功");
            }
            else if (radioButton3.Checked == true)
            {
                string command = "update Course set " + strtxt14 + " = '" + strtxt16 + "' where CID = '" + strtxt15 + "'";
                SqlCommand sqlc = new SqlCommand(command, connection);
                sqlc.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = sqlc.ExecuteReader();
                MessageBox.Show("修改成功");
            }
            else if (radioButton4.Checked == true)
            {
                string command = "update Choose set " + strtxt14 + " = '" + strtxt16 + "' where SID = '" + strtxt15 + "'";
                SqlCommand sqlc = new SqlCommand(command, connection);
                sqlc.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = sqlc.ExecuteReader();
                MessageBox.Show("修改成功");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
