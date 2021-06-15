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

namespace New_project_LIB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Arun\\source\repos\\New_project_LIB\\New_project_LIB\\Database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private String getUserName()
        {
            //Fetch the data

            con.Open();
            String Syntax = "SELECT value FROM systemTable where property=UserName";
            cmd = new SqlCommand(Syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;


        }

        private String getPassword()
        {
            //Fetch the data

            con.Open();
            String Syntax = "SELECT value FROM systemTable where property=Password";
            cmd = new SqlCommand(Syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp= dr[0].ToString();
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
                AppBody obj = new AppBody();
                this.Hide();
                obj.Show();

           
            }
            else
            {
                //DONT LOGIN
                label4.Show();
            }
        }

    }
}
