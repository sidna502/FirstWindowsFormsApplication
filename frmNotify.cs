using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsFormsApplication
{
    public partial class frmNotify : Form
    {
        public frmNotify()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon =   ToolTipIcon.Error;
            notifyIcon1.BalloonTipTitle = "This is a Title";
            notifyIcon1.BalloonTipText = "This is a notification message";
            notifyIcon1.ShowBalloonTip(30000);
        }

        private void NotifyIcon1_BoloonTipClick(object sender, EventArgs e)
        {
            MessageBox.Show("Boloon Tip Clicked");
        }

        private void NotifyIcon1_BoloonTipShown(object sender, EventArgs e)
        {
            MessageBox.Show("Boloon Tip Shown");
        }

        private void NotifyIcon1_BoloonTipClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Boloon Tip Clicked");
        }

        private void NotifyIcon1_BoloonTipClosed(object sender, EventArgs e)
        {
            MessageBox.Show("Boloon Tip Closed");
        }
    }
}
