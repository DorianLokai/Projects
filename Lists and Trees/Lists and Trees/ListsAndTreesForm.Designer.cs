namespace Lists_and_Trees
{
    partial class ListsAndTreesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListsAndTreesForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "James Foxall",
            "Nebraska"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Seth Luther",
            "Western Cape"}, 0);
            this.imgMyImages = new System.Windows.Forms.ImageList(this.components);
            this.lstMyListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvwLanguages = new System.Windows.Forms.TreeView();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.btnCreateChild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imgMyImages
            // 
            this.imgMyImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMyImages.ImageStream")));
            this.imgMyImages.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMyImages.Images.SetKeyName(0, "Person.ico");
            // 
            // lstMyListView
            // 
            this.lstMyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstMyListView.FullRowSelect = true;
            this.lstMyListView.HideSelection = false;
            this.lstMyListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lstMyListView.Location = new System.Drawing.Point(8, 8);
            this.lstMyListView.Name = "lstMyListView";
            this.lstMyListView.Size = new System.Drawing.Size(266, 97);
            this.lstMyListView.SmallImageList = this.imgMyImages;
            this.lstMyListView.TabIndex = 0;
            this.lstMyListView.UseCompatibleStateImageBehavior = false;
            this.lstMyListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "State";
            // 
            // tvwLanguages
            // 
            this.tvwLanguages.ImageIndex = 0;
            this.tvwLanguages.ImageList = this.imgMyImages;
            this.tvwLanguages.Location = new System.Drawing.Point(8, 128);
            this.tvwLanguages.Name = "tvwLanguages";
            this.tvwLanguages.SelectedImageIndex = 0;
            this.tvwLanguages.Size = new System.Drawing.Size(266, 97);
            this.tvwLanguages.TabIndex = 1;
            // 
            // btnAddNode
            // 
            this.btnAddNode.Location = new System.Drawing.Point(8, 231);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(75, 23);
            this.btnAddNode.TabIndex = 2;
            this.btnAddNode.Text = "Add Node";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // btnCreateChild
            // 
            this.btnCreateChild.Location = new System.Drawing.Point(89, 231);
            this.btnCreateChild.Name = "btnCreateChild";
            this.btnCreateChild.Size = new System.Drawing.Size(80, 23);
            this.btnCreateChild.TabIndex = 3;
            this.btnCreateChild.Text = "Create Child";
            this.btnCreateChild.UseVisualStyleBackColor = true;
            this.btnCreateChild.Click += new System.EventHandler(this.btnCreateChild_Click);
            // 
            // ListsAndTreesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateChild);
            this.Controls.Add(this.btnAddNode);
            this.Controls.Add(this.tvwLanguages);
            this.Controls.Add(this.lstMyListView);
            this.Name = "ListsAndTreesForm";
            this.Text = "Lists and Trees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgMyImages;
        private System.Windows.Forms.ListView lstMyListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TreeView tvwLanguages;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.Button btnCreateChild;
    }
}

