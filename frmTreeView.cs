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
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void TreeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void TreeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
        }
        private void CheckTreeViewNode(TreeNode node, bool IsCkecked)
        {
          foreach(TreeNode item in node.Nodes)
            {
                item.Checked = IsCkecked;
                if(item.Nodes.Count > 0)
                {
                    CheckTreeViewNode(item, IsCkecked);
                }
            }
        }
    }
}
