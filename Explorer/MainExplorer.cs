#region usings
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

#endregion

namespace Explorer
{
    public partial class MainExplorer : MetroForm
    {

        public Dictionary<double, string[]> pathDirectories = new Dictionary<double, string[]>();
        public bool setter = true;

        public MainExplorer()
        {
            InitializeComponent();
        }

        private void MainExplorer_Load(object sender, EventArgs e)
        {
            string lastPath = Properties.Settings.Default.lastPath;

            if (String.IsNullOrEmpty(lastPath))
                primarySetListView();
            else
                loadFAF(lastPath);

            loadPlugins();
        }

        private void ExplorerMListView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = ExplorerMListView.SelectedItems.OfType<ListViewItem>().First();

                if (selectedItem.Tag == null)
                    return;

                if (selectedItem.Tag is DriveInfo)
                    loadFAF((selectedItem.Tag as DriveInfo).Name);
                else if (selectedItem.Tag is DirectoryInfo)
                    loadFAF((selectedItem.Tag as DirectoryInfo).FullName);
                else if (selectedItem.Tag is FileInfo)
                    System.Diagnostics.Process.Start((selectedItem.Tag as FileInfo).FullName);
            }
            catch (Exception ex)
            {
                Extentions.MessageBox.Run(ex.Message, "Item clicked error");
                Properties.Settings.Default.lastPath = "";
                Properties.Settings.Default.Save();
            }
        }

        private void HomeToolStripButton_Click(object sender, EventArgs e) => primarySetListView();

        private void BackToolStripButton_Click(object sender, EventArgs e)
        {
            string currentPath = PathToolStripLabel.Tag.ToString();
            if (currentPath.Length == 3)
                primarySetListView();
            else
                loadFAF(Path.GetFullPath(Path.Combine(currentPath, "..")));
        }

        private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentPath = PathToolStripLabel.Tag.ToString();
            new UtilityForms.NewFolderForm(currentPath).ShowDialog();
            loadFAF(currentPath);
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentPath = PathToolStripLabel.Tag.ToString();
            new UtilityForms.NewFileForm(currentPath).ShowDialog();
            loadFAF(currentPath);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItems = ExplorerMListView.SelectedItems;
            if (selectedItems.Count == 0) return;
            List<object> lst = new List<object>();
            foreach (var item in selectedItems)
                lst.Add((item as ListViewItem).Tag);
            Tools.EntitiesJobs.Copy(lst);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItems = ExplorerMListView.SelectedItems;
            if (selectedItems.Count == 0) return;
            List<object> lst = new List<object>();
            foreach (var item in selectedItems)
                lst.Add((item as ListViewItem).Tag);
            Tools.EntitiesJobs.Cut(lst);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.EntitiesJobs.Paste(PathToolStripLabel.Tag.ToString());
                loadFAF(PathToolStripLabel.Tag.ToString());
            }
            catch (Exception ex)
            {
                Extentions.MessageBox.Run(ex.Message, "Paste error");
            }
        }

        private void deletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selecedItems = ExplorerMListView.SelectedItems.OfType<ListViewItem>();
            if (selecedItems.Count() == 0) return;
            List<object> lst = new List<object>();
            foreach (var item in selecedItems)
            {
                lst.Add(item.Tag);
            }
            Tools.Entities.Delete(lst);

            loadFAF(PathToolStripLabel.Tag.ToString());
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = ExplorerMListView.SelectedItems.OfType<ListViewItem>().FirstOrDefault();
            if (selectedItem.Tag == null) return;

            new UtilityForms.RenameForm(selectedItem.Tag).ShowDialog();

            loadFAF(PathToolStripLabel.Tag.ToString());
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) => this.Refresh();

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toolStripMenuItem = sender as ToolStripMenuItem;

            (toolStripMenuItem.Tag as PluginManager.ICommand).run();

        }

        private void SearchToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var txt = SearchToolStripTextBox.Text;

                if (string.IsNullOrEmpty(txt))
                {
                    loadFAF(Properties.Settings.Default.lastPath);
                    return;
                }
                else if (Directory.Exists(txt))
                {
                    PathToolStripLabel.Tag = txt; 
                    PathToolStripLabel.Text = $"PC >> {txt}";
                    ItemsNumberLabel.Text = $"File: {Tools.Entities.SetEntities(ExplorerMListView, txt)}";
                }
            }
            catch (Exception ex)
            {
                Extentions.MessageBox.Run(ex.Message, "Loading file error");
                Properties.Settings.Default.lastPath = "";
                Properties.Settings.Default.Save();
            }
        }

        #region Methods

        private void ToolsVisible(bool state)
        {
            BackToolStripButton.Enabled = state;
            HomeToolStripButton.Enabled = state;
            FileDropDownButton.Enabled  = state;
        }

        private void loadFAF(string path)
        {
            try
            {
                ToolsVisible(true);
                PathToolStripLabel.Tag = path;
                PathToolStripLabel.Text = $"PC >> {path}";

                Properties.Settings.Default.lastPath = path;
                Properties.Settings.Default.Save();

                ItemsNumberLabel.Text = $"Item(s): {Tools.Entities.SetEntities(ExplorerMListView, path)}";
            }
            catch (Exception ex)
            {
                Extentions.MessageBox.Run(ex.Message, "Loading file error");
                Properties.Settings.Default.lastPath = "";
                Properties.Settings.Default.Save();
            }
        }

        private void primarySetListView()
        {
            try
            {
                ToolsVisible(false);
                ItemsNumberLabel.Text = Tools.Entities.SetEntities(ExplorerMListView, "Drives").ToString();
                PathToolStripLabel.Text = "PC";
            }
            catch (Exception ex)
            {
                Extentions.MessageBox.Run(ex.Message, "Drives load error");
                Properties.Settings.Default.lastPath = "";
                Properties.Settings.Default.Save();
            }
        }

        private void loadPlugins()
        {
            try
            {
                string pluginsPath = Path.Combine(Application.StartupPath, "Plugins");

                if (!Directory.Exists(pluginsPath))
                    Directory.CreateDirectory(pluginsPath);

                var plugins = Directory.GetFiles(pluginsPath, "*.dll");

                if (plugins.Length == 0) return;

                foreach (var plugin in plugins)
                {
                    try
                    {
                        Assembly pluginAssembly = Assembly.LoadFile(plugin);

                        var pluginTypes = pluginAssembly.GetTypes().Where(type => typeof(PluginManager.ICommand).IsAssignableFrom(type));
                        if (pluginTypes == null)
                            continue;

                        foreach (var type in pluginTypes)
                        {
                            var commandAttribute = type.GetCustomAttribute<PluginManager.CommandAttribute>();
                            var shortCutAttribute = type.GetCustomAttribute<PluginManager.ShortcutKeysAttribute>();
                            var toolTipAttribute = type.GetCustomAttribute<PluginManager.ToolTipTextAttribute>();

                            if (commandAttribute == null) continue;

                            var toolStripMenuItem = new ToolStripMenuItem(commandAttribute.pluginName);

                            if (shortCutAttribute != null)
                                toolStripMenuItem.ShortcutKeys = shortCutAttribute.getShourtCut();
                            if (toolTipAttribute != null)
                                toolStripMenuItem.ToolTipText = toolTipAttribute.Text;

                            var instace = Activator.CreateInstance(type) as PluginManager.ICommand;

                            toolStripMenuItem.Image = instace.setImage();
                            toolStripMenuItem.Tag = instace;

                            toolStripMenuItem.Font = this.Font;

                            toolStripMenuItem.Click += ToolStripMenuItem_Click;

                            PluginsDropDownButton.DropDownItems.Add(toolStripMenuItem);
                        }
                    }
                    catch (Exception ex)
                    {
                        Extentions.MessageBox.Run(ex.Message, $"{Path.GetFileName(plugin)} can not load.");
                    }
                }
            }
            catch (Exception ex)
            {
                Extentions.MessageBox.Run(ex.Message, "Plugins load error");
            }
        }
        #endregion
    }
}
