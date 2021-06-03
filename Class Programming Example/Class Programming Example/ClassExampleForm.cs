using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Programming_Example
{
    public partial class ClassExampleForm : Form
    {
        public ClassExampleForm()
        {
            InitializeComponent();
        }

        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            clsMyClass objMyObject = new clsMyClass();
            MessageBox.Show(objMyObject.AddTwoNumbers(1, 2).ToString());
        }
    }
}
