namespace No_Remainders
{
    partial class NoRemaindersForm
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
            this.btnFindNumbers = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFindNumbers
            // 
            this.btnFindNumbers.Location = new System.Drawing.Point(82, 39);
            this.btnFindNumbers.Name = "btnFindNumbers";
            this.btnFindNumbers.Size = new System.Drawing.Size(120, 23);
            this.btnFindNumbers.TabIndex = 0;
            this.btnFindNumbers.Text = "Find Numbers";
            this.btnFindNumbers.UseVisualStyleBackColor = true;
            this.btnFindNumbers.Click += new System.EventHandler(this.btnFindNumbers_Click);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(82, 68);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(120, 160);
            this.lstResults.TabIndex = 1;
            // 
            // NoRemaindersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnFindNumbers);
            this.Name = "NoRemaindersForm";
            this.Text = "No Remainders";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFindNumbers;
        private System.Windows.Forms.ListBox lstResults;
    }
}

