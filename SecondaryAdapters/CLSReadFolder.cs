// <copyright file="CLSReadFolder.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.SecondaryAdapters
{
	using System.Collections.Generic;
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
		public IEnumerable<FileSystemInfo> fncReadFolderAsObjectArray(string p_vstAbsoluteFolderPath, bool p_vbnIncludeFolders)
		{
			IEnumerable<FileSystemInfo> aryFileSystemInfos;
			if (p_vbnIncludeFolders)
			{
				aryFileSystemInfos = new DirectoryInfo(p_vstAbsoluteFolderPath).EnumerateFileSystemInfos();
			}
			else
			{
				aryFileSystemInfos = new DirectoryInfo(p_vstAbsoluteFolderPath).EnumerateFiles();
			}

			return aryFileSystemInfos;
		}
	}
}
