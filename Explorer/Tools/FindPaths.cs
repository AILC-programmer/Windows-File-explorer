using System.Collections.Generic;

namespace Explorer.Tools
{
    public static class FindPaths
    {
        public static List<object> FoundedEntities { get; } = new List<object>();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int FindFiles(string path, string name)
        {
            FoundedEntities.Clear();

            if (string.IsNullOrEmpty(name)) return -1;
            if (string.IsNullOrEmpty(path)) return -1;
            else return findFilesHelper(path, name);
        }

        private static int findFilesHelper(string path, string name)
        {
            var files = Entities.GetFiles(path);

            foreach (var file in files)
            {
                if (file.Name.ToLower().Contains(name.ToLower()))
                    FoundedEntities.Add(file);
            }
            return FoundedEntities.Count;
        }

        public static int FindDirectories(string path, string name)
        {
            FoundedEntities.Clear();

            if (string.IsNullOrEmpty(name)) return -1;
            if (string.IsNullOrEmpty(path)) return -1;
            else return findDirectoriesHelper(path, name);
        }

        private static int findDirectoriesHelper(string path, string name)
        {
            var directories = Entities.GetDirectories(path);

            foreach (var directory in directories)
                if (directory.Name.ToLower().Contains(name.ToLower()))
                    FoundedEntities.Add(directory);

            return FoundedEntities.Count;
        }

        /// <summary>
        /// Finds All directories and files
        /// </summary>
        /// <param name="path">That path wants to fine entities</param>
        /// <param name="name">The name of entities</param>
        /// <returns></returns>
        public static int FindAll(string path, string name)
        {
            FoundedEntities.Clear();

            if (string.IsNullOrEmpty(name)) return -1;
            if (string.IsNullOrEmpty(path)) return -1;
            else return (FindDirectories(path, name) + findFilesHelper(path, name));
        }
    }
}
