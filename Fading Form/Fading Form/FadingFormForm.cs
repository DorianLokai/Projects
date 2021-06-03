using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fading_Form
{
    public partial class FadingFormForm : Form
    {
        public FadingFormForm()
        {
            InitializeComponent();
        }

        private void btnFadeForm_Click(object sender, EventArgs e)
        {
            for (double dblOpacity = 1; dblOpacity > 0; dblOpacity += -0.05)
            {
                this.Opacity = dblOpacity;
                //Lets the form repaint itself.
                this.Refresh();
                //create a delay.
                System.Threading.Thread.Sleep(200);
            }
            //Show the form again
            this.Opacity = 1;
        }
    }
}
