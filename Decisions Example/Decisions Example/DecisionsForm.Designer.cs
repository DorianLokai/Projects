namespace Decisions_Example
{
    partial class DecisionsForm
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
            this.btnIsLessThanhundred = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(44, 44);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnIsLessThanhundred
            // 
            this.btnIsLessThanhundred.Location = new System.Drawing.Point(156, 42);
            this.btnIsLessThanhundred.Name = "btnIsLessThanhundred";
            this.btnIsLessThanhundred.Size = new System.Drawing.Size(100, 23);
            this.btnIsLessThanhundred.TabIndex = 1;
            this.btnIsLessThanhundred.Text = "Is text < 100?";
            this.btnIsLessThanhundred.UseVisualStyleBackColor = true;
            this.btnIsLessThanhundred.Click += new System.EventHandler(this.btnIsLessThanhundred_Click);
            // 
            // DecisionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIsLessThanhundred);
            this.Controls.Add(this.txtInput);
            this.Name = "DecisionsForm";
            this.Text = "Decisions Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnIsLessThanhundred;
    }
}

