using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Dialog_Example
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShowCustomDialogBox_Click(object sender, EventArgs e)
        {
            CustomDialogBoxForm frmCustomDialogBox = new CustomDialogBoxForm();

            if (frmCustomDialogBox.ShowDialog() == DialogResult.OK)
                MessageBox.Show("You clicked OK");
            else
                MessageBox.Show("You clicked Cancel");

            frmCustomDialogBox = null;
        }
    }
}
