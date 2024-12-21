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
    public partial class frmShowPicturesWithComboBox : Form
    {
        public frmShowPicturesWithComboBox()
        {
            InitializeComponent();
        }
        enComboBoxOptions ComboBoxOptions;
        enum enComboBoxOptions { Book, Pen, Boy, Girl};
        void ChangeImageUsingComboBox(ComboBox cbBox)
        {
            //switch (cmbPictures.SelectedItem.ToString().ToLower())
            //{
            //    case "book":
            //        pictureBox1.Image = Properties.Resources.Book;
            //        label1.Text = "Book";
            //        break;
            //    case "boy":
            //        pictureBox1.Image = Properties.Resources.Boy;
            //        label1.Text = "Boy";
            //        break;
            //    case "girl":
            //        pictureBox1.Image = Properties.Resources.Girl;
            //        label1.Text = "Girl";
            //        break;
            //    case "pen":
            //        pictureBox1.Image = Properties.Resources.Pen;
            //        label1.Text = "Pen";
            //        break;
            //}
            if (cbBox.Text == enComboBoxOptions.Book.ToString())
            {
                pictureBox1.Image = Properties.Resources.Book;
                label1.Text = "Book";
            }
            if (cbBox.Text == enComboBoxOptions.Boy.ToString())
            {
                pictureBox1.Image = Properties.Resources.Boy;
                label1.Text = "Boy";
            }
            if (cbBox.Text == enComboBoxOptions.Girl.ToString())
            {
                pictureBox1.Image = Properties.Resources.Girl;
                label1.Text = "Girl";
            }
            if (cbBox.Text == enComboBoxOptions.Pen.ToString())
            {
                pictureBox1.Image = Properties.Resources.Pen;
                label1.Text = "Pen";
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //ChangeImageUsingComboBox((ComboBox)sender);
            string Active_Element = ((ComboBox)sender).Text;
            label1.Text = Active_Element;
            pictureBox1.Image = Image.FromFile($@"C:\Users\jedou\Downloads\Images\{Active_Element}.png");
        }

        private void frmShowPicturesWithComboBox_Load(object sender, EventArgs e)
        {
            cmbPictures.SelectedIndex = 1;
            //label1.Text = "Title";
        }
    }
}
