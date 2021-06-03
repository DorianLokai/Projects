using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debugging_Example
{
    public partial class DebuggingExampleForm : Form
    {
        public DebuggingExampleForm()
        {
            InitializeComponent();
        }

        private void btnPerformDivision_Click(object sender, EventArgs e)
        {
            //this procedure divides 100 by the value entered in
            // the text box txtInput.
            long lngAnswer;
            if (txtInput.Text.Length == 0) return;
            lngAnswer = 100 / Convert.ToInt64(txtInput.Text);
            MessageBox.Show("100/" + txtInput.Text + "is" + lngAnswer);
        }
    }
}
