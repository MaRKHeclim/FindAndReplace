// <copyright file="IFCBulkSearch.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.Core.Ports.Incoming
{
	using FindAndReplace.Core.DataStructures;
	using System.Collections.Generic;

	/// <summary>
	/// Interface for iterating over files and calling string replace operations.
	/// </summary>
	public interface IFCBulkSearch
	{
		public void subSearchFilesAndFolders(IEnumerable<string> p_enbFilePaths, IEnumerable<CLSFindReplaceRecord> p_enbFindReplaceRecords);

		public void subSearchFiles(IEnumerable<string> p_enbFileList, IEnumerable<CLSFindReplaceRecord> p_enbFindReplaceRecords);
	}
}
