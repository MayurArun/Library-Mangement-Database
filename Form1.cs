using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;


        private String getUserName()
        {
            // fetch the data from datbase
            con.Open();
            string syntax = "SELECT Value FROM systemTable where Property=UserName";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;

        }

        private String getPassword()
        {
            // fetch the data from datbase
            con.Open();
            string syntax = "SELECT Value FROM systemTable where Property=Password";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            String Uname = getUserName(), Upass = getPassword(), name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
             if(name.Equals(Uname) && pass.Equals(Upass))
            {
                //LOGIN
                label4.Hide();
                MessageBox.Show("Log in sucess!!");

            }
             else
            {
                //DONT LOGIN
                label4.Show();
            }
        }
    }
}
