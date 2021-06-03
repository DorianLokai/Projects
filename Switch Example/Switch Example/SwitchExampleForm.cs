using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Example
{
    public partial class SwitchExampleForm : Form
    {
        public SwitchExampleForm()
        {
            InitializeComponent();
        }

        private void btnShowLegs_Click(object sender, EventArgs e)
        {
            switch (cboAnimals.Text)
            {
                case "Bird":
                    MessageBox.Show("The animal has 2 legs.");
                    break;
                case "Dog":
                //Notice there is no code here to execute.
                case "Horse":
                //Notice there is no code here to execute.
                case "Cat"://Switch case will execution falling through meaning it will move on to the next code till it reaches a break, in this case Dog,Horse & cat has 4 legs ie next message box is used.
                    MessageBox.Show("The animal has 4 legs.");
                    break;
                case "Snake":
                    MessageBox.Show("The animal has no legs.");
                    break;
                case "Centipede":
                    MessageBox.Show("The animal has 100 legs.");
                    break;
                default:
                    MessageBox.Show("You did not select from the list!");
                    break;
            }
        }
    }
}
