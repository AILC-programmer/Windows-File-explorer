using MetroFramework;
using MetroFramework.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace Explorer.UtilityForms
{
    public partial class NewFileForm : MetroForm
    {
        private string extention;
        private string currentpath;
        private string newPath;
        private Action<bool> onSetValue;
        private bool isOK;

        public NewFileForm(string currentPath)
        {
            InitializeComponent();
            this.currentpath = currentPath;

            onSetValue += setStyle;

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

            newPath = Path.Combine(currentpath, folderName + extention);
            isOK = !File.Exists(newPath);

            if (onSetValue != null)
                onSetValue(isOK);

            return isOK;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = metroComboBox1.SelectedItem.ToString().Trim().ToLower();

            if (selectedItem.CompareTo("text document") == 0)
                extention = ".txt";
            else if (selectedItem.CompareTo("powerpoint") == 0)
                extention = ".pptx";
            else if (selectedItem.CompareTo("word") == 0)
                extention = ".docx";
            else if (selectedItem.CompareTo("excel") == 0)
                extention = ".xlsx";
            else if (selectedItem.CompareTo("bitmap") == 0)
                extention = ".bmp";
            else
                extention = null;
        }

        private void AcptButton_Click(object sender, EventArgs e)
        {
            if (!isOK)
                return;

            File.Create(newPath);

            DialogResult = DialogResult.OK;
        }

        private void CnclButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var name = FileNameTextBox.Text;
            if (name == null)
                return;
            if (!canGeneratePath(name))
                return;
        }
    }
}
