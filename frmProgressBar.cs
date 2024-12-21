﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsFormsApplication
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            for (int i = 0; i < 10; i++)
            {
                if(progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(500);
                    label1.Refresh();
                    progressBar1.Value += 10;
                    label1.Text = ((float)progressBar1.Value / progressBar1.Maximum * 100) + "%";
                    //progressBar1.Refresh();
                    button1.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            label1.Text = "0%";
            button1 .Enabled = true;
        }
    }
}
