namespace Automate_Excel
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
            this.btnAutomateExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAutomateExcel
            // 
            this.btnAutomateExcel.Location = new System.Drawing.Point(90, 120);
            this.btnAutomateExcel.Name = "btnAutomateExcel";
            this.btnAutomateExcel.Size = new System.Drawing.Size(104, 23);
            this.btnAutomateExcel.TabIndex = 0;
            this.btnAutomateExcel.Text = "Automate Excel";
            this.btnAutomateExcel.UseVisualStyleBackColor = true;
            this.btnAutomateExcel.Click += new System.EventHandler(this.btnAutomateExcel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAutomateExcel);
            this.Name = "MainForm";
            this.Text = "Automate Excel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAutomateExcel;
    }
}

