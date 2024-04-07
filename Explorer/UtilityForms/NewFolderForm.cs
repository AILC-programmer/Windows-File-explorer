using MetroFramework;
using MetroFramework.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace Explorer.UtilityForms
{
    public partial class NewFolderForm : MetroForm
    {
        private Action<bool> OnSetValue;
        private bool isOK;
        private string newPath;
        private string lastPath;

        public NewFolderForm(string lastPath)
        {
            InitializeComponent();
            this.lastPath = lastPath;

            OnSetValue += setStyle;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            newPath = null;
            DialogResult = DialogResult.Cancel;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (!isOK)
                return;

            Directory.CreateDirectory(newPath);

            DialogResult = DialogResult.OK;
        }

        private void setStyle(bool status)
        {
            if (status)
                this.Style = MetroColorStyle.Lime;
            else
                this.Style = MetroColorStyle.Red;
            Refresh();
        }

        private bool canGeneratePath(string folderName)
        {

            newPath = Path.Combine(lastPath, folderName);
            isOK = !Directory.Exists(newPath);

            if (OnSetValue != null)
                OnSetValue(isOK);

            return isOK;
        }

        private void FolderNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var name = FolderNameTextBox.Text;
            if (name == null)
                return;
            if (!canGeneratePath(name))
                return;
        }
    }
}
