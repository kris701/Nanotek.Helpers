namespace Nanotek.Helpers
{
    /// <summary>
    /// A helper class to make it a bit easier to work with <seealso cref="Directory"/>s and <seealso cref="File"/>s
    /// </summary>
    public static class DirectoryHelper
    {
        #region GetDirectory

        /// <summary>
        /// Get a <seealso cref="DirectoryInfo"/> from a string.
        /// </summary>
        /// <param name="dir">String representing the path to the directory</param>
        /// <returns>A new <seealso cref="DirectoryInfo"/></returns>
        public static DirectoryInfo GetDirectory(string dir) => GetDirectory(dir, "");
        /// <summary>
        /// Get a <seealso cref="DirectoryInfo"/> from two strings, one base and one extension
        /// </summary>
        /// <param name="baseDir">Origin directory</param>
        /// <param name="dir">Additional directory</param>
        /// <returns>A new <seealso cref="DirectoryInfo"/></returns>
        public static DirectoryInfo GetDirectory(string baseDir, string dir) => new DirectoryInfo(Path.Join(baseDir, dir));
        /// <summary>
        /// Get a <seealso cref="DirectoryInfo"/> from another <seealso cref="DirectoryInfo"/> and a string
        /// </summary>
        /// <param name="baseDir">Origin directory</param>
        /// <param name="dir">Additional directory</param>
        /// <returns>A new <seealso cref="DirectoryInfo"/></returns>
        public static DirectoryInfo GetDirectory(DirectoryInfo baseDir, string dir) => GetDirectory(baseDir.FullName, dir);
        /// <summary>
        /// Get a <seealso cref="DirectoryInfo"/> from two <seealso cref="DirectoryInfo"/>s
        /// </summary>
        /// <param name="baseDir">Origin directory</param>
        /// <param name="dir">Additional directory</param>
        /// <returns>A new <seealso cref="DirectoryInfo"/></returns>
        public static DirectoryInfo GetDirectory(DirectoryInfo baseDir, DirectoryInfo dir) => GetDirectory(baseDir.FullName, dir.FullName);

        #endregion

        #region GetFile

        /// <summary>
        /// Gets a new <seealso cref="FileInfo"/> from a string path
        /// </summary>
        /// <param name="path">Path to the file</param>
        /// <returns>A new <seealso cref="FileInfo"/></returns>
        public static FileInfo GetFile(string path) => new FileInfo(path);
        /// <summary>
        /// Gets a new <seealso cref="FileInfo"/> from the combination of two string paths
        /// </summary>
        /// <param name="baseDir">Origin directory</param>
        /// <param name="fileName">Name of the file</param>
        /// <returns>A new <seealso cref="FileInfo"/></returns>
        public static FileInfo GetFile(string baseDir, string fileName) => new FileInfo(Path.Join(baseDir, fileName));
        /// <summary>
        /// Gets a new <seealso cref="FileInfo"/> from the combination of a <seealso cref="DirectoryInfo"/> and a file name string
        /// </summary>
        /// <param name="baseDir">Origin directory</param>
        /// <param name="fileName">Name of the file</param>
        /// <returns>A new <seealso cref="FileInfo"/></returns>
        public static FileInfo GetFile(DirectoryInfo baseDir, string fileName) => GetFile(baseDir.FullName, fileName);
        /// <summary>
        /// Gets a new <seealso cref="FileInfo"/> from the combination of a <seealso cref="DirectoryInfo"/> and a <seealso cref="FileInfo"/>
        /// </summary>
        /// <param name="baseDir">Origin directory</param>
        /// <param name="fileName">Name of the file</param>
        /// <returns>A new <seealso cref="FileInfo"/></returns>
        public static FileInfo GetFile(DirectoryInfo baseDir, FileInfo fileName) => GetFile(baseDir.FullName, fileName.Name);

        #endregion
    }
}