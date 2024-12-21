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
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
                return;
            ListViewItem Item = new ListViewItem(txtID.Text);
            if(rbMale.Checked)
                Item.ImageIndex = 1;
            else
                Item.ImageIndex = 0;
            Item.SubItems.Add(txtName.Text);
            listView1.Items.Add(Item);

            txtID.Clear();
            txtName.Clear();
            txtID.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //if(listView1.SelectedItems.Count > 0)
            //{
            //    listView1.Items.Remove(listView1.SelectedItems[0]);
            //}
            foreach(ListViewItem Item in listView1.SelectedItems)
                listView1.Items.Remove(Item);
        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                ListViewItem Item = new ListViewItem(i.ToString());
                if(i % 2 == 0)
                    Item.ImageIndex = 1;
                else
                    Item.ImageIndex = 0;
                Item.SubItems.Add("Person " + i);
                listView1.Items.Add(Item);
            }
        }
        private void ChangeView(View view)
        {
            listView1.View = view;
        }
        private void rbDetails_CheckedChanged_1(object sender, EventArgs e)
        {
            listView1.View = View.Details;
          
        }

        private void rbLargeIcon_CheckedChanged_1(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbSmallIcon_CheckedChanged_1(object sender, EventArgs e)
        {
           listView1.View = View.SmallIcon;
        }

        private void rbList_CheckedChanged_1(object sender, EventArgs e)
        {
           listView1.View = View.List;
        }

        private void rbTie_CheckedChanged_1(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void ListView1_DoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].Text);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listView1.Columns.Add("Last Name");
        }
    }
}
