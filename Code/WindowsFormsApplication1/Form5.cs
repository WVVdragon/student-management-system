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
    public partial class Form5 : Form
    {
        public static string strtxt3;
        public static string strtxt4;
        Form1 form1 = new Form1();
        string txt1 = Form1.strtxt1;

        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            strtxt3 = textBox1.Text.ToString();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "server=DESKTOP-H3U6B32;uid=sa;pwd=12345678;database=MDB";
            SqlConnection connection = new SqlConnection(conn);//连接数据库  
            connection.Open();

            string command = "select count(CID) from Choose where SID='" + txt1 + "'and CID='"+ strtxt3+"'";
            SqlCommand sqc = new SqlCommand(command, connection);
            int i = Convert.ToInt32(sqc.ExecuteScalar());
            if (i != 0) MessageBox.Show("该课程已选");
            else
            {
                DateTime dt = DateTime.Now;
                string Y = dt.Year.ToString();
                if (strtxt3 == "1008060") strtxt4 = "10001";
                else if (strtxt3 == "1203006") strtxt4 = "10003";
                else if (strtxt3 == "3009405") strtxt4 = "20010";
                else if (strtxt3 == "7787564") strtxt4 = "35790";
                command = "insert into Choose values(" + txt1 + "," + strtxt3 + "," + strtxt4 + ",NULL,"+Y+")";
                SqlCommand sq = new SqlCommand(command, connection);
                sq.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = sq.ExecuteReader();
                connection.Close();
                MessageBox.Show("成功");
                 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
         private void Form5_Load(object sender, EventArgs e)
        {
            
        }
        

       
    }
}
