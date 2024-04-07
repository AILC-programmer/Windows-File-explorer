namespace Explorer.UtilityForms
{
    partial class NewFolderForm
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
            this.FolderNamePanel = new MetroFramework.Controls.MetroPanel();
            this.FolderNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.FolderNameLabel = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.AcptButton = new MetroFramework.Controls.MetroButton();
            this.CancelBtn = new MetroFramework.Controls.MetroButton();
            this.FolderNamePanel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderNamePanel
            // 
            this.FolderNamePanel.Controls.Add(this.FolderNameTextBox);
            this.FolderNamePanel.Controls.Add(this.FolderNameLabel);
            this.FolderNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FolderNamePanel.HorizontalScrollbarBarColor = true;
            this.FolderNamePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.FolderNamePanel.HorizontalScrollbarSize = 12;
            this.FolderNamePanel.Location = new System.Drawing.Point(22, 75);
            this.FolderNamePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FolderNamePanel.Name = "FolderNamePanel";
            this.FolderNamePanel.Size = new System.Drawing.Size(357, 35);
            this.FolderNamePanel.TabIndex = 0;
            this.FolderNamePanel.VerticalScrollbarBarColor = true;
            this.FolderNamePanel.VerticalScrollbarHighlightOnWheel = false;
            this.FolderNamePanel.VerticalScrollbarSize = 11;
            // 
            // FolderNameTextBox
            // 
            // 
            // 
            // 
            this.FolderNameTextBox.CustomButton.Image = null;
            this.FolderNameTextBox.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.FolderNameTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FolderNameTextBox.CustomButton.Name = "";
            this.FolderNameTextBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.FolderNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FolderNameTextBox.CustomButton.TabIndex = 1;
            this.FolderNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FolderNameTextBox.CustomButton.UseSelectable = true;
            this.FolderNameTextBox.CustomButton.Visible = false;
            this.FolderNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderNameTextBox.Lines = new string[] {
        "metroTextBox1"};
            this.FolderNameTextBox.Location = new System.Drawing.Point(90, 0);
            this.FolderNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FolderNameTextBox.MaxLength = 32767;
            this.FolderNameTextBox.Name = "FolderNameTextBox";
            this.FolderNameTextBox.PasswordChar = '\0';
            this.FolderNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FolderNameTextBox.SelectedText = "";
            this.FolderNameTextBox.SelectionLength = 0;
            this.FolderNameTextBox.SelectionStart = 0;
            this.FolderNameTextBox.ShortcutsEnabled = true;
            this.FolderNameTextBox.Size = new System.Drawing.Size(267, 35);
            this.FolderNameTextBox.TabIndex = 3;
            this.FolderNameTextBox.Text = "metroTextBox1";
            this.FolderNameTextBox.UseSelectable = true;
            this.FolderNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FolderNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.FolderNameTextBox.TextChanged += new System.EventHandler(this.FolderNameTextBox_TextChanged);
            // 
            // FolderNameLabel
            // 
            this.FolderNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FolderNameLabel.Location = new System.Drawing.Point(0, 0);
            this.FolderNameLabel.Name = "FolderNameLabel";
            this.FolderNameLabel.Size = new System.Drawing.Size(90, 35);
            this.FolderNameLabel.TabIndex = 2;
            this.FolderNameLabel.Text = "Folder name";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.AcptButton);
            this.metroPanel1.Controls.Add(this.CancelBtn);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(22, 116);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(357, 35);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // AcptButton
            // 
            this.AcptButton.Location = new System.Drawing.Point(208, 5);
            this.AcptButton.Name = "AcptButton";
            this.AcptButton.Size = new System.Drawing.Size(70, 25);
            this.AcptButton.TabIndex = 2;
            this.AcptButton.Text = "Accept";
            this.AcptButton.UseSelectable = true;
            this.AcptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(284, 5);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(70, 25);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseSelectable = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // NewFolderForm
            // 
            this.AcceptButton = this.AcptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(401, 176);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.FolderNamePanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "NewFolderForm";
            this.Padding = new System.Windows.Forms.Padding(22, 75, 22, 25);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Folder generator";
            this.FolderNamePanel.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel FolderNamePanel;
        private MetroFramework.Controls.MetroTextBox FolderNameTextBox;
        private MetroFramework.Controls.MetroLabel FolderNameLabel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton AcptButton;
        private MetroFramework.Controls.MetroButton CancelBtn;
    }
}