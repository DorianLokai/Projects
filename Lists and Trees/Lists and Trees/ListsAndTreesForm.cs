using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists_and_Trees
{
    public partial class ListsAndTreesForm : Form
    {
        public ListsAndTreesForm()
        {
            InitializeComponent();
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            tvwLanguages.Nodes.Add("James");
            tvwLanguages.Nodes.Add("Visual C#");
        }

        private void btnCreateChild_Click(object sender, EventArgs e)
        {
            TreeNode objNode;
            objNode = tvwLanguages.Nodes.Add("Matt Perry");
            objNode.Nodes.Add("Visual C#");
        }
    }
}
