using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MyIcon = Explorer.Icon.IconList;

namespace Explorer.Tools
{
    public static class Framework
    {
        /// <summary>
        /// Sets the items in the list view control with icons.
        /// </summary>
        /// <param name="listView">MetroListView control for UI</param>
        /// <param name="path">
        /// The root path set files and folders in that path. If you pass "Drives" value, sets Drives in the list view control.
        /// </param>
        /// <returns>returns the number of set entities.</returns>
        public static int SetEntities(MetroListView listView, string path)
        {
            try
            {
                if (path.ToLower().CompareTo("drives") == 0)
                    return SetDrives(listView);

                // Else

                var dirs = Entities.GetDirectories(path);
                var files = Entities.GetFiles(path);

                listView.LargeImageList = listView.SmallImageList = listView.StateImageList
                    = MyIcon.Instance.AddItem(Properties.Resources.Folder_Windows, "Folder");

                listView.Items.Clear();

                foreach (var directory in dirs)
                    setEntitiesHelper(listView, directory);

                foreach (var file in files)
                    setEntitiesHelper(listView, file);

                return dirs.Count + files.Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Sets drives to listView.
        /// </summary>
        /// <param name="listView">MetroListView control for UI</param>
        /// <returns>The number of drives.</returns>
        public static int SetDrives(MetroListView listView)
        {
            try
            {
                var drives = Entities.GetDrives();

                listView.Items.Clear();

                foreach (var drive in drives)
                    setEntitiesHelper(listView, drive);

                return drives.Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Sets entities to ListView.
        /// </summary>
        /// <param name="listView">MetroListView control for UI</param>
        /// <param name="entities">List of those entities wants to be set to the listView</param>
        public static void SetEntities(MetroListView listView, List<object> entities)
        {
            try
            {
                listView.Items.Clear();

                foreach (var entity in entities)
                    setEntitiesHelper(listView, entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // Helper methods

        private static void setEntitiesHelper(MetroListView listView, object entity)
        {
            try
            {
                if (entity is DriveInfo)
                {
                    var drive = entity as DriveInfo;
                    if (drive.IsReady)
                        listView.Items.Add(new ListViewItem(drive.VolumeLabel + " (" + drive.Name + ")")
                        {
                            Tag = drive,
                            ToolTipText = EntityInfo.GetDriveInfo(drive),
                            ImageIndex = MyIcon.Instance.GetIndexOfExtention("Drive")
                        });
                    else
                        listView.Items.Add(new ListViewItem(drive.Name));
                }
                else if (entity is DirectoryInfo)
                {
                    var directory = entity as DirectoryInfo;

                    listView.Items.Add(new ListViewItem(Extentions.Tools.NameHandler.LogicalName(directory.Name, 30))
                    {
                        Tag = directory,
                        ToolTipText = EntityInfo.GetDirectoryInfo(directory),
                        ImageIndex = MyIcon.Instance.GetIndexOfExtention("Folder"),
                    });
                }
                else if (entity is FileInfo)
                {
                    var file = entity as FileInfo;

                    if (string.IsNullOrEmpty(Path.GetExtension(file.FullName))) return;

                    listView.Items.Add(new ListViewItem(Extentions.Tools.NameHandler.LogicalFileNmae(file.Name, 30))
                    {
                        Tag = file,
                        ToolTipText = EntityInfo.GetFileInfo(file),
                        ImageIndex = MyIcon.Instance.GetIndexOfExtention(file.FullName),
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
