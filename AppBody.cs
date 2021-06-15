using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace New_project_LIB
{
    public partial class AppBody : Form
    {

        public AppBody()
        {
            InitializeComponent();
        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            LOG_IN_TIME.Start();

        }

        private void LOG_IN_TIME_Tick(object sender, EventArgs e)
        {
            if(this.Opacity= 1.)
            {
                this.Opacity += 0.025;

            }
            else
            {
                LOG_IN_TIME.Stop();
            }


        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void LOGOOFButton_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();

        }

        private void Tittlebar_MouseClick(object sender, MouseEventArgs e)
        {
                 {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        }
    }
}
