namespace Database_Example
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
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.btnMovePrevious = new System.Windows.Forms.Button();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpNewRecord = new System.Windows.Forms.GroupBox();
            this.txtNewContactName = new System.Windows.Forms.TextBox();
            this.txtNewState = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpNewRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(48, 112);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(112, 20);
            this.txtContactName.TabIndex = 0;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(168, 112);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(80, 20);
            this.txtState.TabIndex = 1;
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Location = new System.Drawing.Point(12, 152);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(32, 23);
            this.btnMoveFirst.TabIndex = 2;
            this.btnMoveFirst.Text = "<<";
            this.btnMoveFirst.UseVisualStyleBackColor = true;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.Location = new System.Drawing.Point(48, 152);
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.Size = new System.Drawing.Size(32, 23);
            this.btnMovePrevious.TabIndex = 3;
            this.btnMovePrevious.Text = "<";
            this.btnMovePrevious.UseVisualStyleBackColor = true;
            this.btnMovePrevious.Click += new System.EventHandler(this.btnMovePrevious_Click);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Location = new System.Drawing.Point(86, 152);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.Size = new System.Drawing.Size(32, 23);
            this.btnMoveNext.TabIndex = 4;
            this.btnMoveNext.Text = ">";
            this.btnMoveNext.UseVisualStyleBackColor = true;
            this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Location = new System.Drawing.Point(124, 152);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(32, 23);
            this.btnMoveLast.TabIndex = 5;
            this.btnMoveLast.Text = ">>";
            this.btnMoveLast.UseVisualStyleBackColor = true;
            this.btnMoveLast.Click += new System.EventHandler(this.btnMoveLast_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(162, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpNewRecord
            // 
            this.grpNewRecord.Controls.Add(this.btnAddNew);
            this.grpNewRecord.Controls.Add(this.txtNewState);
            this.grpNewRecord.Controls.Add(this.txtNewContactName);
            this.grpNewRecord.Location = new System.Drawing.Point(16, 192);
            this.grpNewRecord.Name = "grpNewRecord";
            this.grpNewRecord.Size = new System.Drawing.Size(256, 58);
            this.grpNewRecord.TabIndex = 7;
            this.grpNewRecord.TabStop = false;
            this.grpNewRecord.Text = "New Contact";
            // 
            // txtNewContactName
            // 
            this.txtNewContactName.Location = new System.Drawing.Point(8, 24);
            this.txtNewContactName.Name = "txtNewContactName";
            this.txtNewContactName.Size = new System.Drawing.Size(112, 20);
            this.txtNewContactName.TabIndex = 0;
            // 
            // txtNewState
            // 
            this.txtNewState.Location = new System.Drawing.Point(126, 24);
            this.txtNewState.Name = "txtNewState";
            this.txtNewState.Size = new System.Drawing.Size(80, 20);
            this.txtNewState.TabIndex = 1;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(210, 22);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(40, 23);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(206, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 23);
            this.btnDelete.TabIndex = 3;
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
            this.Controls.Add(this.grpNewRecord);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMoveLast);
            this.Controls.Add(this.btnMoveNext);
            this.Controls.Add(this.btnMovePrevious);
            this.Controls.Add(this.btnMoveFirst);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtContactName);
            this.Name = "MainForm";
            this.Text = "Database Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpNewRecord.ResumeLayout(false);
            this.grpNewRecord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnMoveFirst;
        private System.Windows.Forms.Button btnMovePrevious;
        private System.Windows.Forms.Button btnMoveNext;
        private System.Windows.Forms.Button btnMoveLast;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpNewRecord;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtNewState;
        private System.Windows.Forms.TextBox txtNewContactName;
        private System.Windows.Forms.Button btnDelete;
    }
}

