namespace Nanotek.Helpers
{
    public static class DirectoryHelper
    {
        public static string CombinePathAndFile(string path, string file)
        {
            path = path.Trim();
            file = file.Trim();
            if (!path.EndsWith("\\"))
                path = $"{path}\\";
            if (file.StartsWith("\\"))
                file = file.Substring(1);
            return $"{path}{file}";
        }

        public static string CombinePathAndFile(DirectoryInfo path, FileInfo file)
        {
            return CombinePathAndFile(path.FullName, file.Name);
        }
    }
}