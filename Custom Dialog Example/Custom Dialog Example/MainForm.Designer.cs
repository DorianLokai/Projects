namespace Custom_Dialog_Example
{
    partial class MainForm
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
            this.btnShowCustomDialogBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowCustomDialogBox
            // 
            this.btnShowCustomDialogBox.Location = new System.Drawing.Point(67, 180);
            this.btnShowCustomDialogBox.Name = "btnShowCustomDialogBox";
            this.btnShowCustomDialogBox.Size = new System.Drawing.Size(152, 23);
            this.btnShowCustomDialogBox.TabIndex = 0;
            this.btnShowCustomDialogBox.Text = "Show Custom Dialog Box";
            this.btnShowCustomDialogBox.UseVisualStyleBackColor = true;
            this.btnShowCustomDialogBox.Click += new System.EventHandler(this.btnShowCustomDialogBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowCustomDialogBox);
            this.Name = "MainForm";
            this.Text = "Custom DIalog Box Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowCustomDialogBox;
    }
}

