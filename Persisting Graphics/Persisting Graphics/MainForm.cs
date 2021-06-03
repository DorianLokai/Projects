using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persisting_Graphics
{
    public partial class MainForm : Form
    {
        private Bitmap m_objDrawingSurface;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create a drawing surface with the same dimenssions as the client area of the form.
            m_objDrawingSurface = new Bitmap(this.ClientRectangle.Width,
                this.ClientRectangle.Height,
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            InitializeSurface();
        }
        
        private void InitializeSurface()
        {
            Graphics objGraphics;
            Rectangle rectBounds;

            // Create a Graphics object that references the bitmap and clear it.
            objGraphics = Graphics.FromImage(m_objDrawingSurface);

            objGraphics.Clear(SystemColors.Control);

            // Create a rectangle the same size as the bitmap.
            rectBounds = new Rectangle(0, 0,
                m_objDrawingSurface.Width, m_objDrawingSurface.Height);
            // Reduce the rectangle slightly so the ellipse wón't appear on the border.
            rectBounds.Inflate(-1, -1);

            // Draw an ellipse that fills the form.
            objGraphics.DrawEllipse(Pens.Orange, rectBounds);

            // free up resources
            objGraphics.Dispose();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            // Draw the contents of the bitmap on the form.
            e.Graphics.DrawImage(m_objDrawingSurface, 0, 0,
                m_objDrawingSurface.Width,
                m_objDrawingSurface.Height);
            e.Graphics.Dispose();
        }

        private void btnDrawText_Click(object sender, EventArgs e)
        {
            Graphics objGraphics;
            Font objFont;
            int intFontSize, intTextX, intTextY;

            Random randomGenerator = new Random();

            // If no text has been entered, get out.
            if (txtInput.Text == "") return;

            // Create a graphics object using the memory bitmap.
            objGraphics = Graphics.FromImage(m_objDrawingSurface);

            // Create a random number for the font size. Keep it wetween 8 and 48.
            intFontSize = randomGenerator.Next(8, 48);
            // Create a random number for the X coordinate of the text.
            intTextX = randomGenerator.Next(0, this.ClientRectangle.Width);
            // Create a random number for the Y coordinates of the text.
            intTextY = randomGenerator.Next(0, this.ClientRectangle.Height);

            // Create a new font objext.
            objFont = new System.Drawing.Font("Arial", intFontSize, FontStyle.Bold);
            // Draw the user's text.
            objGraphics.DrawString(txtInput.Text, objFont,
                System.Drawing.Brushes.Red, intTextX, intTextY);
            // Clean up.
            objGraphics.Dispose();
            // Force the for to paint itself. This triggers the paint event.
            this.Invalidate();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_objDrawingSurface.Dispose();
        }
    }
}
