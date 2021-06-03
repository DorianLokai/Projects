using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisions_Example
{
    public partial class DecisionsForm : Form
    {
        public DecisionsForm()
        {
            InitializeComponent();
        }

        private void btnIsLessThanhundred_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtInput.Text) < 100)// if statement checks to see if text entered is equal to == or < than 100.
                MessageBox.Show("The test entered is less than 100.");// shows a message box with the string confirming text entered < 100.
            else//when the if statement returns false it runs the else
                MessageBox.Show("The text entered is greater than or equal to 100.");// only executes if text entered into texbox is == or > 100.
        }
    }
}
