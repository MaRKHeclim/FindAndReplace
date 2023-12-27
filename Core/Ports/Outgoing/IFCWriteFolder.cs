// <copyright file="IFCWriteFolder.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.Core.Ports.Outgoing
{
	internal interface IFCWriteFolder
	{
		public void subCreateFolder(string p_vstAbsoluteFolderPath);

		public void subRenameFolder(string p_vstAbsoluteFolderPath, string p_vstNewFolderName);
	}
}
