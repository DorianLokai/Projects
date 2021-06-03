using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manipulating_Files
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Following code opens a .txt file from selected location
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Select a File";
            openFileDialog1.Filter = "";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
                txtSource.Text = openFileDialog1.FileName;
            else
                txtSource.Text = "";
                    
        }

        // Following code saves a .txt file to the specified location.
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Specify Destinaiton File Name";
            saveFileDialog1.Filter = "Text Files (*.txt) |*.txt";
            saveFileDialog1.FilterIndex = 1;

            saveFileDialog1.OverwritePrompt = true;

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                txtDestination.Text = saveFileDialog1.FileName;

        }

        // Code below checks to see if the file exists or not then provides a popup message accordingly.
        bool SourceFileExists()
        {
            if (!System.IO.File.Exists(txtSource.Text))
            {
                MessageBox.Show("The source file does not exist!");
                return false;
            }
            else
                return true;
        }

        // Code below copies .txt file.
        private void btnCopyFile_Click(object sender, EventArgs e)
        {
            if (!SourceFileExists()) return;
            System.IO.File.Copy(txtSource.Text, txtDestination.Text);
            MessageBox.Show("The file has been successfully copied");
        }

        // Code below Moves .txt file.
        private void btnMove_Click(object sender, EventArgs e)
        {
            if (!SourceFileExists()) return;
            System.IO.File.Move(txtSource.Text, txtDestination.Text);
            MessageBox.Show("The file has been successfully moved");
        }

        // Code Below deletes a .txt file.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!SourceFileExists()) return;

            if (MessageBox.Show("Are you sure you want to delete the source file?",
                "Delete Verification",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.IO.File.Delete(txtSource.Text);
                MessageBox.Show("The file has been succesfully deleted.");
            }
        }
    }
}
