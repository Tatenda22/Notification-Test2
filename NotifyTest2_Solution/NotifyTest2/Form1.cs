using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyTest2
{
    public partial class Form1 : Form
    {
        /**
         * This when minized will cause a pop up notification to appear with 
         * a message. It will remain running in the background unless 
         * the user exits the notification etc 
         * 
         **/ 
        public Form1()
        {
            InitializeComponent();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show(); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "Update Message", "Camera Update is required, Click this to make option", ToolTipIcon.Info);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
