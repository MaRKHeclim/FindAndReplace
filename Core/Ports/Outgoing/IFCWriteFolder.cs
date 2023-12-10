using System.Data;

namespace FindAndReplace.Core.Ports.Outgoing
{
	internal interface IFCWriteFolder
	{
		public void subCreateFolder(string p_vstAbsoluteFolderPath);

		public void subRenameFolder(string p_vstAbsoluteFolderPath, string p_vstNewFolderName);
	}
}
