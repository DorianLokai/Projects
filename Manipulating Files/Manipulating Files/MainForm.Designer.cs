namespace Manipulating_Files
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnCopyFile = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(95, 8);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(184, 20);
            this.txtSource.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(9, 6);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(80, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Source";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(95, 34);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(184, 20);
            this.txtDestination.TabIndex = 2;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(9, 31);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(80, 23);
            this.btnSaveFile.TabIndex = 3;
            this.btnSaveFile.Text = "Destination";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnCopyFile
            // 
            this.btnCopyFile.Location = new System.Drawing.Point(95, 71);
            this.btnCopyFile.Name = "btnCopyFile";
            this.btnCopyFile.Size = new System.Drawing.Size(75, 23);
            this.btnCopyFile.TabIndex = 4;
            this.btnCopyFile.Text = "Copy";
            this.btnCopyFile.UseVisualStyleBackColor = true;
            this.btnCopyFile.Click += new System.EventHandler(this.btnCopyFile_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(95, 100);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 5;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(95, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnCopyFile);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtSource);
            this.Name = "MainForm";
            this.Text = "Manipulating Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnCopyFile;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnDelete;
    }
}

