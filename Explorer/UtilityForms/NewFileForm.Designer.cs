namespace Explorer.UtilityForms
{
    partial class NewFileForm
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
            this.MainPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.FileNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.FileNameLabel = new MetroFramework.Controls.MetroLabel();
            this.ButtonsPanel = new MetroFramework.Controls.MetroPanel();
            this.AcptButton = new MetroFramework.Controls.MetroButton();
            this.CnclButton = new MetroFramework.Controls.MetroButton();
            this.MainPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.metroLabel1);
            this.MainPanel.Controls.Add(this.metroComboBox1);
            this.MainPanel.Controls.Add(this.FileNameTextBox);
            this.MainPanel.Controls.Add(this.FileNameLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.HorizontalScrollbarBarColor = true;
            this.MainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MainPanel.HorizontalScrollbarSize = 10;
            this.MainPanel.Location = new System.Drawing.Point(20, 75);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(315, 68);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.VerticalScrollbarBarColor = true;
            this.MainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MainPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "File type";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Text document",
            "Powerpoint",
            "Word",
            "Excel",
            "BitMap"});
            this.metroComboBox1.Location = new System.Drawing.Point(81, 0);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(231, 29);
            this.metroComboBox1.TabIndex = 5;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // FileNameTextBox
            // 
            // 
            // 
            // 
            this.FileNameTextBox.CustomButton.Image = null;
            this.FileNameTextBox.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.FileNameTextBox.CustomButton.Name = "";
            this.FileNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FileNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FileNameTextBox.CustomButton.TabIndex = 1;
            this.FileNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FileNameTextBox.CustomButton.UseSelectable = true;
            this.FileNameTextBox.CustomButton.Visible = false;
            this.FileNameTextBox.Lines = new string[] {
        "metroTextBox1"};
            this.FileNameTextBox.Location = new System.Drawing.Point(81, 36);
            this.FileNameTextBox.MaxLength = 32767;
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.PasswordChar = '\0';
            this.FileNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FileNameTextBox.SelectedText = "";
            this.FileNameTextBox.SelectionLength = 0;
            this.FileNameTextBox.SelectionStart = 0;
            this.FileNameTextBox.ShortcutsEnabled = true;
            this.FileNameTextBox.Size = new System.Drawing.Size(231, 23);
            this.FileNameTextBox.TabIndex = 4;
            this.FileNameTextBox.Text = "metroTextBox1";
            this.FileNameTextBox.UseSelectable = true;
            this.FileNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FileNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.FileNameTextBox.TextChanged += new System.EventHandler(this.FileNameTextBox_TextChanged);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(6, 36);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(66, 19);
            this.FileNameLabel.TabIndex = 3;
            this.FileNameLabel.Text = "File name";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.AcptButton);
            this.ButtonsPanel.Controls.Add(this.CnclButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPanel.HorizontalScrollbarBarColor = true;
            this.ButtonsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ButtonsPanel.HorizontalScrollbarSize = 10;
            this.ButtonsPanel.Location = new System.Drawing.Point(20, 144);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(315, 40);
            this.ButtonsPanel.TabIndex = 1;
            this.ButtonsPanel.VerticalScrollbarBarColor = true;
            this.ButtonsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ButtonsPanel.VerticalScrollbarSize = 10;
            // 
            // AcptButton
            // 
            this.AcptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AcptButton.Location = new System.Drawing.Point(158, 5);
            this.AcptButton.Name = "AcptButton";
            this.AcptButton.Size = new System.Drawing.Size(76, 30);
            this.AcptButton.TabIndex = 2;
            this.AcptButton.Text = "Accept";
            this.AcptButton.UseSelectable = true;
            this.AcptButton.Click += new System.EventHandler(this.AcptButton_Click);
            // 
            // CnclButton
            // 
            this.CnclButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CnclButton.Location = new System.Drawing.Point(240, 5);
            this.CnclButton.Name = "CnclButton";
            this.CnclButton.Size = new System.Drawing.Size(72, 30);
            this.CnclButton.TabIndex = 2;
            this.CnclButton.Text = "Cancel";
            this.CnclButton.UseSelectable = true;
            this.CnclButton.Click += new System.EventHandler(this.CnclButton_Click);
            // 
            // NewFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(355, 209);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(355, 209);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(355, 209);
            this.Name = "NewFileForm";
            this.Padding = new System.Windows.Forms.Padding(20, 75, 20, 25);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "New file";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel MainPanel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox FileNameTextBox;
        private MetroFramework.Controls.MetroLabel FileNameLabel;
        private MetroFramework.Controls.MetroPanel ButtonsPanel;
        private MetroFramework.Controls.MetroButton AcptButton;
        private MetroFramework.Controls.MetroButton CnclButton;
    }
}