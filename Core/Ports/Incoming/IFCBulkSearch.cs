namespace FindAndReplace.Core.Ports.Incoming
{
	using FindAndReplace.Core.DataStructures;
	using System.Collections;

	/// <summary>
	/// Interface for iterating over files and calling string replace operations.
	/// </summary>
	internal interface IFCBulkSearch
	{
		public void subSearchFilesAndFolders(IEnumerable<string> p_enbFilePaths, IEnumerable<CLSFindReplaceRecord> p_enbFindReplaceRecords);

		public void subSearchFiles(IEnumerable<string> p_enbFileList, IEnumerable<CLSFindReplaceRecord> p_enbFindReplaceRecords);
	}
}
