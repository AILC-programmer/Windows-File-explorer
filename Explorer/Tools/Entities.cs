using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;


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

    }
}
