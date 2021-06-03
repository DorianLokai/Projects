namespace Fading_Form
{
    partial class FadingFormForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFadeForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFadeForm
            // 
            this.btnFadeForm.Location = new System.Drawing.Point(105, 113);
            this.btnFadeForm.Name = "btnFadeForm";
            this.btnFadeForm.Size = new System.Drawing.Size(75, 23);
            this.btnFadeForm.TabIndex = 0;
            this.btnFadeForm.Text = "Fade Form";
            this.btnFadeForm.UseVisualStyleBackColor = true;
            this.btnFadeForm.Click += new System.EventHandler(this.btnFadeForm_Click);
            // 
            // FadingFormForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFadeForm);
            this.Name = "FadingFormForm";
            this.Text = "Fading Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFadeForm;
    }
}

