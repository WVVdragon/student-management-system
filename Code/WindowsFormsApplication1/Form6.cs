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
    public partial class Form6 : Form
    {
        public static string strtxt5;
        public static string strtxt6;
        public static string strtxt7;
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            strtxt5 = textBox1.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            strtxt6 = textBox2.Text.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            strtxt7 = textBox3.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            string command = "update Choose set Score = " + strtxt7 + " where SID = '" + strtxt5 + "'and CID='" + strtxt6 + "'";
            SqlCommand sqlc = new SqlCommand(command, connection);
            sqlc.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = sqlc.ExecuteReader();
            MessageBox.Show("成功");

        }


    }
}
