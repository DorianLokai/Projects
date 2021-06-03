using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Picture_Viewer
{
    public partial class ViewerForm : Form
    {
        const bool c_defPromptOnExit = false; // sets the prompt on exit to false as a constant variable.
        string m_strUserName = ""; // creates a string variable for the username using the (m) which is private to class
        bool m_blnPromptOnExit = c_defPromptOnExit;
        Color m_objPictureBackColor;

        private void OpenPicture()
        {
            try 
            {
                //show the open file dialog box
                if (ofdSelectPicture.ShowDialog() == DialogResult.OK)
                {
                    //Load the picture into the pictue box.
                    picShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName);
                    //Show the name of the file in the form's caption.
                    this.Text = string.Concat("Picture Viewer(" + ofdSelectPicture.FileName + ")");
                    //Show the name of the picture in the status bar.                    
                }
                UpdateLog(ofdSelectPicture.FileName);
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show("The file you have chosen is not an image file.",
                    "Invalid File", MessageBoxButtons.OK);
            }
        }

        private void UpdateLog(string strFileName)
        {
            System.IO.StreamWriter objFile = new System.IO.StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory + @"\PictureLog.txt", true);

            objFile.WriteLine(DateTime.Now + " " + strFileName);
            objFile.Close();
            objFile.Dispose();
        }

        private void DrawBorder(PictureBox objPicturebox)
        {
            Graphics objGraphics = null;
            //objGraphics = this.CreateGraphics();
            //objGraphics.Clear(SystemColors.Control);
            //objGraphics.DrawRectangle(Pens.Blue,
            //    objPicturebox.Left - 1, objPicturebox.Top - 1,
            //    objPicturebox.Width + 1, objPicturebox.Height + 1);
            //objGraphics.Dispose();

            if (objGraphics != null)
            {
                objGraphics = this.CreateGraphics();
                objGraphics.Clear(SystemColors.Control);
                objGraphics.DrawRectangle(Pens.Blue,
                    objPicturebox.Left - 1, objPicturebox.Top - 1,
                    objPicturebox.Width + 1, objPicturebox.Height + 1);
                objGraphics.Dispose();
            }
            else
            {
                objGraphics = this.CreateGraphics();
                objGraphics.Clear(SystemColors.Control);
                objGraphics.DrawRectangle(Pens.DarkRed,
                    objPicturebox.Left - 1, objPicturebox.Top - 1,
                    objPicturebox.Width + 1, objPicturebox.Height + 1);
                objGraphics.Dispose();
            }
        }

        public ViewerForm()
        {
            InitializeComponent();
        }

        
        
        private void btnEnlarge_Click(object sender, EventArgs e)
        {
            this.Width = this.Width + 20;
            this.Height = this.Height + 20;
        }

        private void btnShrink_Click(object sender, EventArgs e)
        {
            this.Width = this.Width - 20;
            this.Height = this.Height - 20;
        }

       
        
        private void picShowPicture_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = "X: " + e.X.ToString();
            lblY.Text = "Y: " + e.Y.ToString();

        }

        private void picShowPicture_MouseLeave(object sender, EventArgs e)
        {
            lblX.Text = "";
            lblY.Text = "";

        }

        private void ViewerForm_Load(object sender, EventArgs e)
        {
            lblX.Text = "";
            lblY.Text = "";

            LoadDefaults();
            
        }

        private void LoadDefaults()
        {
            //m_blnPromptOnExit = c_defPromptOnExit;
            // Above modular var is replaced, as code below retrieves the promtp on exit flag from the registry and sets the modular variable instead of the check box on form.
            m_blnPromptOnExit = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\CleverSoftware\PictureViewer\", "PromtOnExit", "false"));
            mnuConfirmOnExit.Checked = m_blnPromptOnExit;

            //m_objPictureBackColor = System.Drawing.SystemColors.Control;            
            if (Convert.ToString(Registry.GetValue(@"HKEY_CURRENT_USER\Software\CleverSoftware\PictureViewer\", "BackColor", "Gray")) == "Gray")
                m_objPictureBackColor = System.Drawing.SystemColors.Control;
            else
                m_objPictureBackColor = System.Drawing.Color.White;

            picShowPicture.BackColor = m_objPictureBackColor;

        }

        private void mnuOpenPicture_Click(object sender, EventArgs e)
        {
            this.OpenPicture();
        }

        private void mnuConfirmOnExit_Click(object sender, EventArgs e)
        {
            mnuConfirmOnExit.Checked = !(mnuConfirmOnExit.Checked);

            m_blnPromptOnExit = mnuConfirmOnExit.Checked;
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuDrawBorder_Click(object sender, EventArgs e)
        {            
            this.DrawBorder(picShowPicture);
        }

        private void mnuOptions_Click(object sender, EventArgs e)
        {
            OptionsForm frmOptionsDialog = new OptionsForm();
            frmOptionsDialog.ShowDialog();//ShowDialog is a Modal form can not use the program/form while this one is open.

            LoadDefaults();
        }

        private void drawBorderToolStripMenuItem_Click(object sender, EventArgs e)// Draws a blue border arround the box in which the picture is displayd
        {
            Graphics objGraphics = null;
            objGraphics = this.CreateGraphics();
            objGraphics.Clear(SystemColors.Control);
            objGraphics.DrawRectangle(Pens.Blue,
                picShowPicture.Left - 1, picShowPicture.Top - 1,
                picShowPicture.Width + 1, picShowPicture.Height + 1);
            objGraphics.Dispose();

        }

        private void tbbOpenPicture_Click(object sender, EventArgs e)
        {
            this.OpenPicture();
        }

        private void tbbDrawBorder_Click(object sender, EventArgs e)
        {           
          this.DrawBorder(picShowPicture);
        }

        private void tbbOptions_Click(object sender, EventArgs e)
        {
            OptionsForm frmOptionsDialog = new OptionsForm();
            frmOptionsDialog.ShowDialog();

            LoadDefaults();

        }

        private void mnuMainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ViewerForm_FormClosing(object sender, FormClosingEventArgs e)//This part shows the Message Box to confirm exit if the prompt on Exit is checked under file menu
        {
            if (m_blnPromptOnExit)
            {
                if (MessageBox.Show("Close the Picture Viewer program?", "Confirm Exit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                    == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

        }

        private void tbbGetFileAttributes_Click(object sender, EventArgs e)
        {
            // Make sure a file is open.
            if ((ofdSelectPicture.FileName) == "")
            {
                MessageBox.Show("There is no file open");
                return;
            }

            // Create the string builder object to concatenate strings.
            System.Text.StringBuilder stbProperties = new System.Text.StringBuilder("");
            System.IO.FileAttributes fileAttributes;

            // Get the dates.
            stbProperties.Append("Created: ");
            stbProperties.Append(System.IO.File.GetCreationTime(ofdSelectPicture.FileName));
            stbProperties.Append("\r\n");

            stbProperties.Append("Accessed: ");
            stbProperties.Append(System.IO.File.GetLastAccessTime(ofdSelectPicture.FileName));
            stbProperties.Append("\r\n");

            stbProperties.Append("Modified: ");
            stbProperties.Append(System.IO.File.GetLastWriteTime(ofdSelectPicture.FileName));
            stbProperties.Append("\r\n");

            // Get File Attributes.
            fileAttributes = System.IO.File.GetAttributes(ofdSelectPicture.FileName);
            stbProperties.Append("\r\n");

            // Use a binary AND to extract the specific attributes.
            stbProperties.Append("Normal: ");
            stbProperties.Append(
                Convert.ToBoolean((fileAttributes & System.IO.FileAttributes.Normal)
                == System.IO.FileAttributes.Normal));
            stbProperties.Append("\r\n");

            stbProperties.Append("Hidden: ");
            stbProperties.Append(
                Convert.ToBoolean((fileAttributes & System.IO.FileAttributes.Hidden)
                == System.IO.FileAttributes.Hidden));
            stbProperties.Append("\r\n");

            stbProperties.Append("ReadOnly: ");
            stbProperties.Append(
                Convert.ToBoolean((fileAttributes & System.IO.FileAttributes.ReadOnly)
                == System.IO.FileAttributes.ReadOnly));
            stbProperties.Append("\r\n");

            stbProperties.Append("System: ");
            stbProperties.Append(
                Convert.ToBoolean((fileAttributes & System.IO.FileAttributes.System)
                == System.IO.FileAttributes.System));
            stbProperties.Append("\r\n");

            stbProperties.Append("Temporary File: ");
            stbProperties.Append(
                Convert.ToBoolean((fileAttributes & System.IO.FileAttributes.Temporary)
                == System.IO.FileAttributes.Temporary));
            stbProperties.Append("\r\n");

            stbProperties.Append("Archive: ");
            stbProperties.Append(
                Convert.ToBoolean((fileAttributes & System.IO.FileAttributes.Archive)
                == System.IO.FileAttributes.Archive));
            MessageBox.Show(stbProperties.ToString());

        }

        private void tbbShowLog_Click(object sender, EventArgs e)
        {
            LogViewerForm objLog = new LogViewerForm();
            objLog.ShowDialog();
        }
    }
}
