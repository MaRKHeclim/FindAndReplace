namespace FindAndReplace.Core.Ports.Outgoing
{
	internal interface IFCReadFolder
	{
		public List<string> fncReadFolderAsFilePathArray(string p_vstAbsoluteFolderPath, bool p_vbnIncludeFolders, bool p_vbnRecurse);

		public FileSystemInfo[] fncReadFolderAsObjectArray(string p_vstAbsoluteFolderPath, bool p_vbnIncludeFolders);
	}
}
