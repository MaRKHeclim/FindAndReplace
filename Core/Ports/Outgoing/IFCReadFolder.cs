namespace FindAndReplace.Core.Ports.Outgoing
{
	internal interface IFCReadFolder
	{
		public string[] fncReadFolderAsFilePathArray(string p_vstAbsoluteFolderPath, bool p_vbnIncludeFolders);

		public FileSystemInfo[] fncReadFolderAsObjectArray(string p_vstAbsoluteFolderPath, bool p_vbnIncludeFolders);
	}
}
