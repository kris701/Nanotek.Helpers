namespace Nanotek.Helpers
{
    public static class DirectoryHelper
    {
        public static DirectoryInfo GetDirectory(string dir) => GetDirectory(dir, "");
        public static DirectoryInfo GetDirectory(string baseDir, string dir) => new DirectoryInfo(Path.Join(baseDir, dir));
        public static DirectoryInfo GetDirectory(DirectoryInfo baseDir, string dir) => GetDirectory(baseDir.FullName, dir);
        public static DirectoryInfo GetDirectory(DirectoryInfo baseDir, DirectoryInfo dir) => GetDirectory(baseDir.FullName, dir.FullName);

        public static FileInfo GetFile(string path) => new FileInfo(path);
        public static FileInfo GetFile(string baseDir, string fileName) => new FileInfo(Path.Join(baseDir, fileName));
        public static FileInfo GetFile(DirectoryInfo baseDir, string fileName) => GetFile(baseDir.FullName, fileName);
        public static FileInfo GetFile(DirectoryInfo baseDir, FileInfo fileName) => GetFile(baseDir.FullName, fileName.Name);
    }
}