using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using dIcon = System.Drawing.Icon;

namespace Explorer.Icon
{
    internal class IconList
    {
        private IconList() { imageList = new ImageList(); }

        private static IconList instance;

        public static IconList Instance
        {
            get
            {
                if (instance == null)
                {

                    instance = new IconList();
                    instance.AddItem(Properties.Resources.Folder_Windows, "Folder");
                    instance.AddItem(Properties.Resources.Drive_Windows, "Drive");
                }

                return instance;
            }
        }

        private List<string> extentions = new List<string>();
        private ImageList imageList;
        public ImageList ImageList { get => imageList; }


        public int GetIndexOfExtention(string path)
        {
            try
            {
                var extention = Path.GetExtension(path);
                if (string.IsNullOrEmpty(extention)) extention = path;

                foreach (var item in extentions)
                    if (item.CompareTo(extention) == 0)
                        return extentions.IndexOf(item);

                AddItem(path);
                return GetIndexOfExtention(path);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            
        }

        public ImageList AddItem(dIcon icon, string Extention)
        {
            try
            {
                if (extentions.Contains(Extention))
                    return imageList;

                extentions.Add(Extention);
                imageList.Images.Add(icon);
                return imageList;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public ImageList AddItem(string FilePath)
        {
            try
            {
                dIcon icon = dIcon.ExtractAssociatedIcon(FilePath);
                return AddItem(icon, Path.GetExtension(FilePath));
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            
        }

    }
}
