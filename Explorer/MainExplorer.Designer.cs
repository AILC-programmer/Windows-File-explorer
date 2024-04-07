namespace Explorer
{
    partial class MainExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainExplorer));
            this.ExplorerMListView = new MetroFramework.Controls.MetroListView();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.HomeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BackToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FileDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.newFolderToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.renameToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.PluginsDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.PathToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.SearchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.SearchToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ItemsNumberLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageIconExplorer = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExplorerMListView
            // 
            this.ExplorerMListView.AllowSorting = true;
            this.ExplorerMListView.BackColor = System.Drawing.Color.Black;
            this.ExplorerMListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExplorerMListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ExplorerMListView.ForeColor = System.Drawing.Color.White;
            this.ExplorerMListView.FullRowSelect = true;
            this.ExplorerMListView.Location = new System.Drawing.Point(27, 119);
            this.ExplorerMListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExplorerMListView.Name = "ExplorerMListView";
            this.ExplorerMListView.OwnerDraw = true;
            this.ExplorerMListView.Size = new System.Drawing.Size(951, 559);
            this.ExplorerMListView.TabIndex = 1;
            this.ExplorerMListView.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ExplorerMListView.UseCompatibleStateImageBehavior = false;
            this.ExplorerMListView.UseSelectable = true;
            this.ExplorerMListView.View = System.Windows.Forms.View.List;
            this.ExplorerMListView.DoubleClick += new System.EventHandler(this.ExplorerMListView_DoubleClick);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripButton,
            this.BackToolStripButton,
            this.toolStripSeparator1,
            this.FileDropDownButton,
            this.PluginsDropDownButton,
            this.toolStripSeparator3,
            this.PathToolStripLabel,
            this.SearchToolStripTextBox,
            this.SearchToolStripLabel,
            this.toolStripSeparator5,
            this.toolStripButton1,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(27, 92);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(951, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // HomeToolStripButton
            // 
            this.HomeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HomeToolStripButton.Image = global::Explorer.Properties.Resources.bx_home_copy;
            this.HomeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeToolStripButton.Name = "HomeToolStripButton";
            this.HomeToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.HomeToolStripButton.Text = "Home";
            this.HomeToolStripButton.Click += new System.EventHandler(this.HomeToolStripButton_Click);
            // 
            // BackToolStripButton
            // 
            this.BackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackToolStripButton.Image = global::Explorer.Properties.Resources.bx_arrow_back_copy;
            this.BackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackToolStripButton.Name = "BackToolStripButton";
            this.BackToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.BackToolStripButton.Text = "Back";
            this.BackToolStripButton.Click += new System.EventHandler(this.BackToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // FileDropDownButton
            // 
            this.FileDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FileDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem2,
            this.newFileToolStripMenuItem2,
            this.toolStripMenuItem3,
            this.copyToolStripMenuItem2,
            this.cutToolStripMenuItem2,
            this.pasteToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.toolStripMenuItem4,
            this.renameToolStripMenuItem2,
            this.refreshToolStripMenuItem2});
            this.FileDropDownButton.Image = global::Explorer.Properties.Resources.bx_dots_vertical_copy;
            this.FileDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileDropDownButton.Name = "FileDropDownButton";
            this.FileDropDownButton.Size = new System.Drawing.Size(34, 24);
            this.FileDropDownButton.Text = "File";
            // 
            // newFolderToolStripMenuItem2
            // 
            this.newFolderToolStripMenuItem2.Image = global::Explorer.Properties.Resources.bx_folder_open_copy;
            this.newFolderToolStripMenuItem2.Name = "newFolderToolStripMenuItem2";
            this.newFolderToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newFolderToolStripMenuItem2.Size = new System.Drawing.Size(259, 26);
            this.newFolderToolStripMenuItem2.Text = "New folder";
            this.newFolderToolStripMenuItem2.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
            // 
            // newFileToolStripMenuItem2
            // 
            this.newFileToolStripMenuItem2.Image = global::Explorer.Properties.Resources.bxs_file_copy;
            this.newFileToolStripMenuItem2.Name = "newFileToolStripMenuItem2";
            this.newFileToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.newFileToolStripMenuItem2.Size = new System.Drawing.Size(259, 26);
            this.newFileToolStripMenuItem2.Text = "New file";
            this.newFileToolStripMenuItem2.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(256, 6);
            // 
            // copyToolStripMenuItem2
            // 
            this.copyToolStripMenuItem2.Image = global::Explorer.Properties.Resources.bx_copy_copy;
            this.copyToolStripMenuItem2.Name = "copyToolStripMenuItem2";
            this.copyToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem2.Size = new System.Drawing.Size(259, 26);
            this.copyToolStripMenuItem2.Text = "Copy";
            this.copyToolStripMenuItem2.ToolTipText = "Copy file";
            this.copyToolStripMenuItem2.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem2
            // 
            this.cutToolStripMenuItem2.Image = global::Explorer.Properties.Resources.bx_cut_copy;
            this.cutToolStripMenuItem2.Name = "cutToolStripMenuItem2";
            this.cutToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem2.Size = new System.Drawing.Size(259, 26);
            this.cutToolStripMenuItem2.Text = "Cut";
            this.cutToolStripMenuItem2.ToolTipText = "Cut file";
            this.cutToolStripMenuItem2.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Image = global::Explorer.Properties.Resources.bx_paste_copy;
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(259, 26);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.ToolTipText = "Paste copyed or cuted files";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Image = global::Explorer.Properties.Resources.bxs_trash_copy;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(259, 26);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.ToolTipText = "Delete selected files";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deletToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(256, 6);
            // 
            // renameToolStripMenuItem2
            // 
            this.renameToolStripMenuItem2.Image = global::Explorer.Properties.Resources.bx_rename_copy;
            this.renameToolStripMenuItem2.Name = "renameToolStripMenuItem2";
            this.renameToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.renameToolStripMenuItem2.Size = new System.Drawing.Size(259, 26);
            this.renameToolStripMenuItem2.Text = "Rename";
            this.renameToolStripMenuItem2.ToolTipText = "Rename selected files";
            this.renameToolStripMenuItem2.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem2
            // 
            this.refreshToolStripMenuItem2.Image = global::Explorer.Properties.Resources.bx_refresh_copy;
            this.refreshToolStripMenuItem2.Name = "refreshToolStripMenuItem2";
            this.refreshToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem2.Size = new System.Drawing.Size(259, 26);
            this.refreshToolStripMenuItem2.Text = "Refresh";
            this.refreshToolStripMenuItem2.ToolTipText = "Refresh the app";
            this.refreshToolStripMenuItem2.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // PluginsDropDownButton
            // 
            this.PluginsDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PluginsDropDownButton.Image = global::Explorer.Properties.Resources.bx_plug_copy;
            this.PluginsDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PluginsDropDownButton.Name = "PluginsDropDownButton";
            this.PluginsDropDownButton.Size = new System.Drawing.Size(34, 24);
            this.PluginsDropDownButton.Text = "Plugins";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // PathToolStripLabel
            // 
            this.PathToolStripLabel.Name = "PathToolStripLabel";
            this.PathToolStripLabel.Size = new System.Drawing.Size(37, 24);
            this.PathToolStripLabel.Text = "Path";
            this.PathToolStripLabel.ToolTipText = "Current path";
            // 
            // SearchToolStripTextBox
            // 
            this.SearchToolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SearchToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchToolStripTextBox.Name = "SearchToolStripTextBox";
            this.SearchToolStripTextBox.Size = new System.Drawing.Size(160, 27);
            this.SearchToolStripTextBox.ToolTipText = "Search name of file";
            this.SearchToolStripTextBox.TextChanged += new System.EventHandler(this.SearchToolStripTextBox_TextChanged);
            // 
            // SearchToolStripLabel
            // 
            this.SearchToolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SearchToolStripLabel.Name = "SearchToolStripLabel";
            this.SearchToolStripLabel.Size = new System.Drawing.Size(53, 24);
            this.SearchToolStripLabel.Text = "Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Explorer.Properties.Resources.bx_refresh_copy;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Refresh app";
            this.toolStripButton1.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemsNumberLabel});
            this.statusStrip1.Location = new System.Drawing.Point(27, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(951, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ItemsNumberLabel
            // 
            this.ItemsNumberLabel.Name = "ItemsNumberLabel";
            this.ItemsNumberLabel.Size = new System.Drawing.Size(70, 20);
            this.ItemsNumberLabel.Text = "Item(s): 0";
            // 
            // imageIconExplorer
            // 
            this.imageIconExplorer.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIconExplorer.ImageStream")));
            this.imageIconExplorer.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIconExplorer.Images.SetKeyName(0, "Folder-PNG.png");
            this.imageIconExplorer.Images.SetKeyName(1, "extension-file-text-txt-type-icon--icon-search-engine--21.png");
            this.imageIconExplorer.Images.SetKeyName(2, "advertising-stand-2.png");
            this.imageIconExplorer.Images.SetKeyName(3, "notes.png");
            this.imageIconExplorer.Images.SetKeyName(4, "video-camera-recording-orange-icon-transparent-background-11640206834cancxmp075.p" +
        "ng");
            this.imageIconExplorer.Images.SetKeyName(5, "red-question-mark-png-11552248199icv2yetzg8.png");
            this.imageIconExplorer.Images.SetKeyName(6, "bxs-file copy.png");
            this.imageIconExplorer.Images.SetKeyName(7, "bxs-file-archive copy.png");
            this.imageIconExplorer.Images.SetKeyName(8, "bxs-file-image copy.png");
            this.imageIconExplorer.Images.SetKeyName(9, "bxs-file-txt copy.png");
            // 
            // MainExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 735);
            this.Controls.Add(this.ExplorerMListView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(572, 735);
            this.Name = "MainExplorer";
            this.Padding = new System.Windows.Forms.Padding(27, 92, 27, 31);
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Explorer";
            this.Load += new System.EventHandler(this.MainExplorer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroListView ExplorerMListView;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton HomeToolStripButton;
        private System.Windows.Forms.ToolStripButton BackToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton PluginsDropDownButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel PathToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox SearchToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel SearchToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton FileDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ItemsNumberLabel;
        private System.Windows.Forms.ImageList imageIconExplorer;
    }
}

