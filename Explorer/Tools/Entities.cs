using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

using MyIcon = Explorer.Icon.IconList;

namespace Explorer.Tools
{
    internal static class Entities
    {
        public static List<DriveInfo> GetDrives()
        {
            List<DriveInfo> values = new List<DriveInfo>();
            var drives = Environment.GetLogicalDrives();
            foreach (var drive in drives)
                values.Add(new DriveInfo(drive));
            
            Properties.Settings.Default.lastPath = String.Empty;
            Properties.Settings.Default.Save();
            return values;
        }

        public static List<DirectoryInfo> GetDirectories(string path)
        {
            List<DirectoryInfo> values = new List<DirectoryInfo>();

            var dirs = Directory.GetDirectories(path);
            foreach (var dir in dirs)
                values.Add(new DirectoryInfo(dir));

            return values;
        }

        public static List<FileInfo> GetFiles(string path)
        {
            List<FileInfo> values = new List<FileInfo>();
            var files = Directory.GetFiles(path);
            foreach (var file in files)
                values.Add(new FileInfo(file));
            
            return values;
        }

        public static void Delete(IEnumerable<object> values)
        {
            if (MessageBox.Show("Are you sure about delete it!", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (var item in values)
                {
                    if (item is DirectoryInfo)
                    {
                        var directoryInfo = item as DirectoryInfo;
                        Directory.Delete(directoryInfo.FullName, true);
                    }
                    else if (item is FileInfo)
                    {
                        var fileInfo = item as FileInfo;

                        File.Delete(fileInfo.FullName);
                    }
                }
            }
        }

        public static string GetDriveInfo(DriveInfo info)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"Volume label: {info.VolumeLabel}" + Environment.NewLine);
            builder.Append($"Name: {info.Name}" + Environment.NewLine);
            builder.Append($"Size: {info.TotalSize} bytes" + Environment.NewLine);
            builder.Append($"Type: {info.DriveType}" + Environment.NewLine);
            builder.Append($"Format: {info.DriveFormat}" + Environment.NewLine);

            return builder.ToString();
        }

        public static string GetDirectoryInfo(DirectoryInfo info)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"Name: {info.Name}" + Environment.NewLine);
            builder.Append($"creation time: {info.CreationTime}" + Environment.NewLine);
            return builder.ToString();
        }
        /// <summary>
        /// Sets the items in the list view control with icons.
        /// </summary>
        /// <param name="listView">MetroListView control for UI</param>
        /// <param name="path">
        /// The root path set files and folders in that path.
        /// If you pass "Drives" value, sets Drives in the list view control.
        /// </param>
        /// <returns>returns the number of set entities.</returns>
        public static int SetEntities(MetroListView listView, string path)
        {
            try
            {
                if (path.ToLower().CompareTo("drives") == 0)
                {
                    var drives = GetDrives();

                    listView.Items.Clear();
                    foreach (var drive in drives)
                    {
                        if (drive.IsReady)
                            listView.Items.Add(new ListViewItem(drive.VolumeLabel + " (" + drive.Name + ")")
                            {
                                Tag = drive,
                                ToolTipText = GetDriveInfo(drive),
                                ImageIndex = MyIcon.Instance.GetIndexOfExtention("Drive")
                            });
                        else
                            listView.Items.Add(new ListViewItem(drive.Name));
                    }
                    return drives.Count;
                }
                
                // Else

                var dirs = GetDirectories(path);
                var files = GetFiles(path);

                listView.LargeImageList = listView.SmallImageList = listView.StateImageList
                    = MyIcon.Instance.AddItem(Properties.Resources.Folder_Windows, "Folder");

                listView.Items.Clear();

                foreach (var directory in dirs)
                    listView.Items.Add(new ListViewItem(Extentions.Tools.NameHandler.LogicalName(directory.Name, 30))
                    {
                        Tag = directory,
                        ToolTipText = GetDirectoryInfo(directory),
                        ImageIndex = MyIcon.Instance.GetIndexOfExtention("Folder"),
                    });

                foreach (var file in files)
                {
                    if (string.IsNullOrEmpty(Path.GetExtension(file.FullName))) continue;
                    listView.Items.Add(new ListViewItem(Extentions.Tools.NameHandler.LogicalFileNmae(file.Name, 30))
                    {
                        Tag = file,
                        ToolTipText = GetFileInfo(file),
                        ImageIndex = MyIcon.Instance.GetIndexOfExtention(file.FullName),
                    });
                }

                return dirs.Count + files.Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetFileInfo(FileInfo info)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"Name: {info.Name}" + Environment.NewLine);
            builder.Append($"Size: {info.Length} bytes" + Environment.NewLine);
            builder.Append($"Creation time: {info.CreationTime}" + Environment.NewLine);
            return builder.ToString();

        }

    }
}
