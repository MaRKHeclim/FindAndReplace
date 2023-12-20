namespace FindAndReplace.SecondaryAdapters
{
	using System.IO;

	/// <summary>
	/// Functional implementation of <see cref="Core.Ports.Outgoing.IFCReadFolder"/>.
	/// </summary>
	/// <seealso cref="FindAndReplace.Core.Ports.Outgoing.IFCReadFolder" />
	internal class CLSReadFolder : Core.Ports.Outgoing.IFCReadFolder
	{
		/// <inheritdoc/>
		public List<string> fncReadFolderAsFilePathArray(string p_vstAbsoluteFolderPath, bool p_vbnIncludeFolders, bool p_vbnRecurse)
		{
			List<string> lstFilePaths = new List<string>();
			if (p_vbnRecurse)
			{
				foreach (string vstSubFolderPath in Directory.EnumerateDirectories(p_vstAbsoluteFolderPath))
				{
					lstFilePaths.AddRange(this.fncReadFolderAsFilePathArray(vstSubFolderPath, p_vbnIncludeFolders, p_vbnRecurse));
				}

				if (p_vbnIncludeFolders)
				{
					lstFilePaths.AddRange(Directory.EnumerateFileSystemEntries(p_vstAbsoluteFolderPath));
				}
				else
				{
					lstFilePaths.AddRange(Directory.EnumerateFiles(p_vstAbsoluteFolderPath));
				}
			}

			return lstFilePaths;
		}

		/// <inheritdoc/>
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
