// <copyright file="IFCWriteFile.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.Core.Ports.Outgoing
{
	internal interface IFCWriteFile
	{
		public void subWriteStringToFile(string p_vstAbsoluteFilePath, string p_vstFileContent);

		public void subWriteObjectAsJSONToFile(string p_vstAbsoluteFilePath, object p_objFileContent);

		public void subWriteEnumerableToFileAsCSV(string p_vstAbsoluteFilePath, System.Collections.IEnumerable p_lstFileContent);

		public void subCreateBAKOfFile(string p_vstAbsoluteFilePath);

		public void subRestoreBAKOfFile(string p_vstAbsoluteFilePath);

		public void subDeleteFile(string p_vstAbsoluteFilePath);

		public void subRenameFile(string p_vstAbsoluteFilePath, string p_vstNewFileName);

		public void subCreateFile(string p_vstAbsoluteFilePath);
	}
}
