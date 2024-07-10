using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Tools
{
    public static class EntityInfo
    {

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
