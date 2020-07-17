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
    public partial class Form10 : Form
    {
        public static string strtxt17;
        public static string strtxt18;
        public Form10()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            strtxt17 = textBox1.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            strtxt18 = textBox2.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            if (radioButton1.Checked == true)
            {
                string selectsql = "delete from Student where SID = '" + strtxt17 + "' delete from Choose where SID = '" + strtxt17 + "'";
                SqlCommand cmd = new SqlCommand(selectsql, connection);
                cmd.CommandType = CommandType.Text;
                int ret = cmd.ExecuteNonQuery();
                if (ret == -1)
                {
                    MessageBox.Show("删除失败");
                    return;
                }
                else
                {
                    MessageBox.Show("删除成功");
                }
            }
            else if (radioButton2.Checked == true)
            {
                string selectsql = "delete from Course where CID = '" + strtxt18 + "'";
                SqlCommand cmd = new SqlCommand(selectsql, connection);
                cmd.CommandType = CommandType.Text;
                int ret = cmd.ExecuteNonQuery();
                if (ret == -1)
                {
                    MessageBox.Show("删除失败");
                    return;
                }
                else
                {
                    MessageBox.Show("删除成功");
                }
            }
            else if (radioButton3.Checked == true)
            {
                string selectsql = "delete from Choose where CID = '" + strtxt18 + "' and SID = '"+ strtxt17 + "'";
                SqlCommand cmd = new SqlCommand(selectsql, connection);
                cmd.CommandType = CommandType.Text;
                int ret = cmd.ExecuteNonQuery();
                if (ret == -1)
                {
                    MessageBox.Show("删除失败");
                    return;
                }
                else
                {
                    MessageBox.Show("删除成功");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
