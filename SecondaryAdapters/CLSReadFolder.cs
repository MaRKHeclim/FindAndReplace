namespace FindAndReplace.SecondaryAdapters
{
    using System.IO;

    internal class CLSReadFolder : Core.Ports.Outgoing.IFCReadFolder
    {
        public string[] fncReadFolderAsFilePathArray(string p_vstAbsoluteFolderPath, bool p_vbnIncludeFolders)
        {
            string[] aryFilePaths;
            if (p_vbnIncludeFolders)
            {
                aryFilePaths = Directory.EnumerateFileSystemEntries(p_vstAbsoluteFolderPath).ToArray();
            }
            else
            {
                aryFilePaths = Directory.EnumerateFiles(p_vstAbsoluteFolderPath).ToArray();
            }

            return aryFilePaths;
        }

        public FileSystemInfo[] fncReadFolderAsObjectArray(string p_vstAbsoluteFolderPath, bool p_vbnIncludeFolders)
        {
            FileSystemInfo[] aryFileSystemInfos;
            if (p_vbnIncludeFolders)
            {
                aryFileSystemInfos = new DirectoryInfo(p_vstAbsoluteFolderPath).EnumerateFileSystemInfos().ToArray();
            }
            else
            {
                aryFileSystemInfos = new DirectoryInfo(p_vstAbsoluteFolderPath).EnumerateFiles().ToArray();
            }

            return aryFileSystemInfos;
        }
    }
}
