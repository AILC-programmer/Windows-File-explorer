using MetroFramework;
using MetroFramework.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace Explorer.UtilityForms
{
    public partial class RenameForm : MetroForm
    {
        private FileInfo fInfo;
        private DirectoryInfo dInfo;
        private Action<bool> onSetValue;
        private bool isOK;
        private string currentPath;
        private string newPath;

        public RenameForm(object info)
        {
            InitializeComponent();

            if (info is FileInfo)
            {
                fInfo = info as FileInfo;
                currentPath = Path.GetDirectoryName(fInfo.FullName);
            }
            else if (info is DirectoryInfo)
            {
                dInfo = info as DirectoryInfo;
                currentPath = Path.GetFullPath(Path.Combine(dInfo.FullName, ".."));
            }

            onSetValue += setStyle;
        }

        private void setStyle(bool state)
        {
            if (state)
                this.Style = MetroColorStyle.Lime;
            else
                this.Style = MetroColorStyle.Red;
            Refresh();
        }

        private bool CanRename(string newName)
        {
            if (fInfo != null)
            {
                newPath = Path.Combine(Path.GetDirectoryName(fInfo.FullName), newName + fInfo.Extension);
                isOK = !File.Exists(newPath);
            }
            else if (dInfo != null)
            {
                newPath = Path.Combine(Path.GetFullPath(Path.Combine(dInfo.FullName, "..")), newName);
                isOK = !Directory.Exists(newPath);
            }

            if (onSetValue != null)
                onSetValue(isOK);

            return isOK;
        }

        private void NewNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var name = NewNameTextBox.Text;
            if (name == null)
                return;
            if (!CanRename(name))
                return;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (!isOK)
                return;

            try
            {
                if (fInfo != null)
                {
                    File.Move(fInfo.FullName, newPath);
                }
                else if (dInfo != null)
                {
                    Directory.Move(dInfo.FullName, newPath);
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void RenameForm_Load(object sender, EventArgs e)
        {
            if (fInfo != null)
                NewNameTextBox.Text = Path.GetFileNameWithoutExtension(fInfo.Name);
            else if (dInfo != null)
                NewNameTextBox.Text = dInfo.Name;
        }
    }
}
