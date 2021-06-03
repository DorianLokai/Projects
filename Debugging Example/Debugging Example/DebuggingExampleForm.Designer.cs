namespace Debugging_Example
{
    partial class DebuggingExampleForm
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnPerformDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(79, 113);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(120, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnPerformDivision
            // 
            this.btnPerformDivision.Location = new System.Drawing.Point(79, 139);
            this.btnPerformDivision.Name = "btnPerformDivision";
            this.btnPerformDivision.Size = new System.Drawing.Size(120, 23);
            this.btnPerformDivision.TabIndex = 1;
            this.btnPerformDivision.Text = "Perform Division";
            this.btnPerformDivision.UseVisualStyleBackColor = true;
            this.btnPerformDivision.Click += new System.EventHandler(this.btnPerformDivision_Click);
            // 
            // DebuggingExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPerformDivision);
            this.Controls.Add(this.txtInput);
            this.Name = "DebuggingExampleForm";
            this.Text = "Debugging Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnPerformDivision;
    }
}

