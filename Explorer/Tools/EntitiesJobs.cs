using CopyDirectory;
using Extentions.Enums;
using System;
using System.Collections.Generic;
using System.IO;

namespace Explorer.Tools
{
    internal static class EntitiesJobs
    {
        private static List<object> copyed = new List<object>();
        private static List<object> cuted = new List<object>();

        public static void Copy(IEnumerable<object> values)
        {
            cuted.Clear();
            copyed.Clear();
            foreach (var item in values)
            {
                copyed.Add(item);
            }
        }

        public static void Cut(IEnumerable<object> values)
        {
            copyed.Clear();
            cuted.Clear();
            foreach (var item in values)
            {
                cuted.Add(item);
            }
        }

        public static void Paste(string currentPath)
        {
            try
            {
                bool forAll = false;
                if (copyed.Count > 0)
                {
                    DialogResult result = DialogResult.One;
                    DirectoryInfo directoryInfo;
                    FileInfo fileInfo;
                    string newPath = "";

                    foreach (var item in copyed)
                    {
                        if (item is FileInfo)
                        {
                            fileInfo = item as FileInfo;

                            newPath = Path.Combine(currentPath, fileInfo.Name);

                            if (File.Exists(newPath))
                            {
                                if (!forAll)
                                    result = MsgBox(fileInfo.Name, "Copy");

                                if (result == DialogResult.OneToAll || result == DialogResult.TwoToAll || result == DialogResult.ThreeToAll)
                                    forAll = true;
                                else
                                    forAll = false;

                                if (result == DialogResult.OneToAll)
                                    break;
                                else if (result == DialogResult.One || result == DialogResult.Two || result == DialogResult.TwoToAll)
                                    continue;
                                else if (result == DialogResult.Three || result == DialogResult.ThreeToAll)
                                {
                                    newPath = Path.Combine(currentPath, Extentions.Tools.NameHandler.GetCopyOfName(fileInfo));
                                    File.Copy(fileInfo.FullName, newPath);
                                }
                            }
                            else
                                File.Copy(fileInfo.FullName, newPath);
                        }
                        else if (item is DirectoryInfo)
                        {
                            directoryInfo = item as DirectoryInfo;
                            newPath = Path.Combine(currentPath, directoryInfo.Name);
                            if (Directory.Exists(newPath))
                            {
                                if (!forAll)
                                    result = MsgBox(directoryInfo.Name, "Copy");

                                if (result == DialogResult.OneToAll || result == DialogResult.TwoToAll || result == DialogResult.ThreeToAll)
                                    forAll = true;
                                else
                                    forAll = false;

                                if (result == DialogResult.OneToAll)
                                    break;
                                else if (result == DialogResult.One || result == DialogResult.Two || result == DialogResult.TwoToAll)
                                    continue;
                                else if (result == DialogResult.Three || result == DialogResult.ThreeToAll)
                                {
                                    newPath = Path.Combine(currentPath, Extentions.Tools.NameHandler.GetCopyOfName(directoryInfo));
                                    IO.CopyDirectory(directoryInfo.FullName, newPath);
                                }
                            }
                            IO.CopyDirectory(directoryInfo.FullName, newPath, true);
                        }
                    }
                }
                else if (cuted.Count > 0)
                {
                    DialogResult result = DialogResult.One;
                    DirectoryInfo directoryInfo;
                    FileInfo fileInfo;
                    string newPath = "";

                    foreach (var item in cuted)
                    {
                        if (item is FileInfo)
                        {
                            fileInfo = item as FileInfo;
                            newPath = Path.Combine(currentPath, fileInfo.Name);
                            if (fileInfo.FullName.CompareTo(newPath) == 0) continue;
                            else if (File.Exists(newPath))
                            {
                                if (!forAll)
                                    result = MsgBox(fileInfo.Name, "Replace");

                                if (result == DialogResult.OneToAll || result == DialogResult.TwoToAll || result == DialogResult.ThreeToAll)
                                    forAll = true;
                                else
                                    forAll = false;

                                if (result == DialogResult.OneToAll)
                                    break;
                                else if (result == DialogResult.One || result == DialogResult.Two || result == DialogResult.TwoToAll)
                                    continue;
                                else if (result == DialogResult.Three || result == DialogResult.ThreeToAll)
                                {
                                    File.Delete(newPath);
                                    File.Move(fileInfo.FullName, newPath);
                                }
                            }
                            else
                                File.Move(fileInfo.FullName, newPath);
                        }
                        else if (item is DirectoryInfo)
                        {
                            directoryInfo = item as DirectoryInfo;
                            newPath = Path.Combine(currentPath, directoryInfo.Name);
                            if (directoryInfo.FullName.CompareTo(newPath) == 0) continue;
                            else if (Directory.Exists(newPath))
                            {
                                if (!forAll)
                                    result = MsgBox(directoryInfo.Name, "Replace");

                                if (result == DialogResult.OneToAll || result == DialogResult.TwoToAll || result == DialogResult.ThreeToAll)
                                    forAll = true;
                                else
                                    forAll = false;

                                if (result == DialogResult.OneToAll)
                                    break;
                                else if (result == DialogResult.One || result == DialogResult.Two || result == DialogResult.TwoToAll)
                                    continue;
                                else if (result == DialogResult.Three || result == DialogResult.ThreeToAll)
                                {
                                    Directory.Delete(newPath);
                                    Directory.Move(directoryInfo.FullName, newPath);
                                }
                            }
                            else
                                Directory.Move(directoryInfo.FullName, newPath);
                        }
                    }

                    cuted.Clear();
                }
                else return;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(IEnumerable<object> values)
        {
            if (Extentions.MessageBox.Run("Are you sure about delete it!", "Delete", null, "Yes", "No") == DialogResult.One)
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

        private static DialogResult MsgBox(string fileName, string button3)
        {
            return Extentions.MessageBox.Run($"The destination already has a file named {fileName}.", "Similar file(s)",
                "Apply to all", "Cancel", "Skip", button3);
        }

    }
}
