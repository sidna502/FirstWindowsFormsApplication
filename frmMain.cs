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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMessageBox();
            frm1.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form frm1 = new frmCheckRadioGroup();
            frm1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmTextBoxes();
            frm1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmPictureBoxes();
            frm1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmShowImage();
            frm1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMaskedTextBox();
            frm1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmComboBox();
            frm1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmShowPicturesWithComboBox();
            frm1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmLinkLabel();
            frm1.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmCheckListBox();
            frm1.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmDateTimePicker();
            frm1.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMonthCalandar();
            frm1.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmTimer();
            frm1.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmNotify();
            frm1.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmTreeView();
            frm1.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmProgressBar();
            frm1.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmListView();
            frm1.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmErrorProvider();
            frm1.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmTrackBar();
            frm1.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmNumericUpDown();
            frm1.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmTabControls();
            frm1.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmPanel();
            frm1.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmColorDialog();
            frm1.Show();
        }
    }
}
