using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Example
{
    public partial class KeyboardExampleForm : Form
    {
        public KeyboardExampleForm()
        {
            InitializeComponent();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'k' || e.KeyChar == 'K')
                e.Handled = true;
        }
    }
}
