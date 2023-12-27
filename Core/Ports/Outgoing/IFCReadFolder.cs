// <copyright file="IFCReadFolder.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.Core.Ports.Outgoing
{
	internal interface IFCReadFolder
	{
		public System.Collections.Generic.List<string> fncReadFolderAsFilePathArray(string p_vstAbsoluteFolderPath, bool p_vbnIncludeFolders, bool p_vbnRecurse);

		public System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo> fncReadFolderAsObjectArray(string p_vstAbsoluteFolderPath, bool p_vbnIncludeFolders);
	}
}
