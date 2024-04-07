namespace Explorer.UtilityForms
{
    partial class RenameForm
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
            this.ButtonsPanel = new MetroFramework.Controls.MetroPanel();
            this.CancelBtn = new MetroFramework.Controls.MetroButton();
            this.AcceptBtn = new MetroFramework.Controls.MetroButton();
            this.NewNameLabel = new MetroFramework.Controls.MetroLabel();
            this.NewNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.MainPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.NewNameTextBox);
            this.MainPanel.Controls.Add(this.NewNameLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.HorizontalScrollbarBarColor = true;
            this.MainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MainPanel.HorizontalScrollbarSize = 12;
            this.MainPanel.Location = new System.Drawing.Point(23, 69);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(345, 33);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.VerticalScrollbarBarColor = true;
            this.MainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MainPanel.VerticalScrollbarSize = 12;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.AcceptBtn);
            this.ButtonsPanel.Controls.Add(this.CancelBtn);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPanel.HorizontalScrollbarBarColor = true;
            this.ButtonsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ButtonsPanel.HorizontalScrollbarSize = 12;
            this.ButtonsPanel.Location = new System.Drawing.Point(23, 102);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(345, 35);
            this.ButtonsPanel.TabIndex = 1;
            this.ButtonsPanel.VerticalScrollbarBarColor = true;
            this.ButtonsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ButtonsPanel.VerticalScrollbarSize = 12;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.Location = new System.Drawing.Point(254, 6);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(88, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseSelectable = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptBtn.Location = new System.Drawing.Point(160, 6);
            this.AcceptBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(88, 23);
            this.AcceptBtn.TabIndex = 2;
            this.AcceptBtn.Text = "Accept";
            this.AcceptBtn.UseSelectable = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // NewNameLabel
            // 
            this.NewNameLabel.AutoSize = true;
            this.NewNameLabel.Location = new System.Drawing.Point(0, 4);
            this.NewNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewNameLabel.Name = "NewNameLabel";
            this.NewNameLabel.Size = new System.Drawing.Size(72, 19);
            this.NewNameLabel.TabIndex = 2;
            this.NewNameLabel.Text = "New name";
            // 
            // NewNameTextBox
            // 
            // 
            // 
            // 
            this.NewNameTextBox.CustomButton.Image = null;
            this.NewNameTextBox.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.NewNameTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NewNameTextBox.CustomButton.Name = "";
            this.NewNameTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.NewNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewNameTextBox.CustomButton.TabIndex = 1;
            this.NewNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewNameTextBox.CustomButton.UseSelectable = true;
            this.NewNameTextBox.CustomButton.Visible = false;
            this.NewNameTextBox.Lines = new string[] {
        "metroTextBox1"};
            this.NewNameTextBox.Location = new System.Drawing.Point(80, 0);
            this.NewNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NewNameTextBox.MaxLength = 32767;
            this.NewNameTextBox.Name = "NewNameTextBox";
            this.NewNameTextBox.PasswordChar = '\0';
            this.NewNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NewNameTextBox.SelectedText = "";
            this.NewNameTextBox.SelectionLength = 0;
            this.NewNameTextBox.SelectionStart = 0;
            this.NewNameTextBox.ShortcutsEnabled = true;
            this.NewNameTextBox.Size = new System.Drawing.Size(264, 27);
            this.NewNameTextBox.TabIndex = 3;
            this.NewNameTextBox.Text = "metroTextBox1";
            this.NewNameTextBox.UseSelectable = true;
            this.NewNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NewNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NewNameTextBox.TextChanged += new System.EventHandler(this.NewNameTextBox_TextChanged);
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 160);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ButtonsPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenameForm";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "RenameForm";
            this.Load += new System.EventHandler(this.RenameForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel MainPanel;
        private MetroFramework.Controls.MetroTextBox NewNameTextBox;
        private MetroFramework.Controls.MetroLabel NewNameLabel;
        private MetroFramework.Controls.MetroPanel ButtonsPanel;
        private MetroFramework.Controls.MetroButton AcceptBtn;
        private MetroFramework.Controls.MetroButton CancelBtn;
    }
}