namespace FindAndReplace.Core.Ports.Outgoing
{
    internal interface IFCReadFolder
    {
        public string[] fncReadFolderAsFilePathArray(string p_vstFolderPath, bool p_vbnIncludeFolders);

        public object[] fncReadFolderAsObjectArray(string p_vstFolderPath, bool p_vbnIncludeFolders);
    }
}
