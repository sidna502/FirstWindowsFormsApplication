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
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is a Message!");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is a Message!", "Title");
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure ? ", "Confirm", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("User Press Ok");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure ? ", "Confirm", MessageBoxButtons.YesNoCancel, 
                MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MessageBox.Show("User Press Ok");
            }
        }
    }
}
