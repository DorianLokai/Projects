namespace Class_Programming_Example
{
    partial class ClassExampleForm
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
            this.btnCreateObject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateObject
            // 
            this.btnCreateObject.Location = new System.Drawing.Point(100, 120);
            this.btnCreateObject.Name = "btnCreateObject";
            this.btnCreateObject.Size = new System.Drawing.Size(88, 23);
            this.btnCreateObject.TabIndex = 0;
            this.btnCreateObject.Text = "Create Object";
            this.btnCreateObject.UseVisualStyleBackColor = true;
            this.btnCreateObject.Click += new System.EventHandler(this.btnCreateObject_Click);
            // 
            // ClassExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateObject);
            this.Name = "ClassExampleForm";
            this.Text = "Class Programming Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateObject;
    }
}

