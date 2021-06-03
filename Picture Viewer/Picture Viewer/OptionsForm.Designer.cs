namespace Picture_Viewer
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabOption = new System.Windows.Forms.TabControl();
            this.pgeGeneral = new System.Windows.Forms.TabPage();
            this.chkPromptOnExit = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pgeAppearance = new System.Windows.Forms.TabPage();
            this.grpDefaultBackcolor = new System.Windows.Forms.GroupBox();
            this.optBackgroundWhite = new System.Windows.Forms.RadioButton();
            this.optBackgroundDefault = new System.Windows.Forms.RadioButton();
            this.tabOption.SuspendLayout();
            this.pgeGeneral.SuspendLayout();
            this.pgeAppearance.SuspendLayout();
            this.grpDefaultBackcolor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(305, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(304, 38);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabOption
            // 
            this.tabOption.Controls.Add(this.pgeGeneral);
            this.tabOption.Controls.Add(this.pgeAppearance);
            this.tabOption.Location = new System.Drawing.Point(12, 12);
            this.tabOption.Name = "tabOption";
            this.tabOption.SelectedIndex = 0;
            this.tabOption.Size = new System.Drawing.Size(287, 145);
            this.tabOption.TabIndex = 2;
            // 
            // pgeGeneral
            // 
            this.pgeGeneral.Controls.Add(this.chkPromptOnExit);
            this.pgeGeneral.Controls.Add(this.txtUserName);
            this.pgeGeneral.Controls.Add(this.lblUserName);
            this.pgeGeneral.Location = new System.Drawing.Point(4, 22);
            this.pgeGeneral.Name = "pgeGeneral";
            this.pgeGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.pgeGeneral.Size = new System.Drawing.Size(279, 119);
            this.pgeGeneral.TabIndex = 0;
            this.pgeGeneral.Text = "General";
            this.pgeGeneral.UseVisualStyleBackColor = true;
            // 
            // chkPromptOnExit
            // 
            this.chkPromptOnExit.AutoSize = true;
            this.chkPromptOnExit.Location = new System.Drawing.Point(90, 66);
            this.chkPromptOnExit.Name = "chkPromptOnExit";
            this.chkPromptOnExit.Size = new System.Drawing.Size(142, 17);
            this.chkPromptOnExit.TabIndex = 7;
            this.chkPromptOnExit.Text = "Prompt to confirm on exit";
            this.chkPromptOnExit.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(90, 25);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(139, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(25, 28);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User Name:";
            // 
            // pgeAppearance
            // 
            this.pgeAppearance.Controls.Add(this.grpDefaultBackcolor);
            this.pgeAppearance.Location = new System.Drawing.Point(4, 22);
            this.pgeAppearance.Name = "pgeAppearance";
            this.pgeAppearance.Padding = new System.Windows.Forms.Padding(3);
            this.pgeAppearance.Size = new System.Drawing.Size(279, 119);
            this.pgeAppearance.TabIndex = 1;
            this.pgeAppearance.Text = "Appearance";
            this.pgeAppearance.UseVisualStyleBackColor = true;
            // 
            // grpDefaultBackcolor
            // 
            this.grpDefaultBackcolor.Controls.Add(this.optBackgroundWhite);
            this.grpDefaultBackcolor.Controls.Add(this.optBackgroundDefault);
            this.grpDefaultBackcolor.Location = new System.Drawing.Point(43, 23);
            this.grpDefaultBackcolor.Name = "grpDefaultBackcolor";
            this.grpDefaultBackcolor.Size = new System.Drawing.Size(200, 72);
            this.grpDefaultBackcolor.TabIndex = 6;
            this.grpDefaultBackcolor.TabStop = false;
            this.grpDefaultBackcolor.Text = "Default Picture Background Color";
            // 
            // optBackgroundWhite
            // 
            this.optBackgroundWhite.AutoSize = true;
            this.optBackgroundWhite.Location = new System.Drawing.Point(14, 42);
            this.optBackgroundWhite.Name = "optBackgroundWhite";
            this.optBackgroundWhite.Size = new System.Drawing.Size(53, 17);
            this.optBackgroundWhite.TabIndex = 1;
            this.optBackgroundWhite.Text = "White";
            this.optBackgroundWhite.UseVisualStyleBackColor = true;
            // 
            // optBackgroundDefault
            // 
            this.optBackgroundDefault.AutoSize = true;
            this.optBackgroundDefault.Checked = true;
            this.optBackgroundDefault.Location = new System.Drawing.Point(14, 19);
            this.optBackgroundDefault.Name = "optBackgroundDefault";
            this.optBackgroundDefault.Size = new System.Drawing.Size(84, 17);
            this.optBackgroundDefault.TabIndex = 0;
            this.optBackgroundDefault.TabStop = true;
            this.optBackgroundDefault.Text = "Default Gray";
            this.optBackgroundDefault.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.tabOption);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Picture Viewer Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.tabOption.ResumeLayout(false);
            this.pgeGeneral.ResumeLayout(false);
            this.pgeGeneral.PerformLayout();
            this.pgeAppearance.ResumeLayout(false);
            this.grpDefaultBackcolor.ResumeLayout(false);
            this.grpDefaultBackcolor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabOption;
        private System.Windows.Forms.TabPage pgeGeneral;
        private System.Windows.Forms.CheckBox chkPromptOnExit;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TabPage pgeAppearance;
        private System.Windows.Forms.GroupBox grpDefaultBackcolor;
        private System.Windows.Forms.RadioButton optBackgroundWhite;
        private System.Windows.Forms.RadioButton optBackgroundDefault;
    }
}