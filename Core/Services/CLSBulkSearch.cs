// <copyright file="CLSBulkSearch.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.Core.Services
{
	using System.Collections.Generic;
	using System.Threading.Tasks;
	using FindAndReplace.Core.DataStructures;
	using FindAndReplace.Core.Ports.Incoming;
	using FindAndReplace.Core.Ports.Outgoing;

	/// <inheritdoc/>
	internal class CLSBulkSearch : Core.Ports.Incoming.IFCBulkSearch
	{
		private readonly IFCStringReplaceWithOptions objStringReplaceWithOptions;
		private readonly IFCReadFolder objReadFolder;
		private readonly IFCReadFile objReadFile;
		private readonly IFCWriteFile objWriteFile;

		public CLSBulkSearch(IFCStringReplaceWithOptions p_objStringReplaceWithOptions, IFCReadFolder p_objReadFolder, IFCReadFile p_objReadFile, IFCWriteFile p_objWriteFile)
		{
			this.objStringReplaceWithOptions = p_objStringReplaceWithOptions;
			this.objReadFolder = p_objReadFolder;
			this.objReadFile = p_objReadFile;
			this.objWriteFile = p_objWriteFile;
		}

		/// <inheritdoc/>
		public void subSearchFilesAndFolders(IEnumerable<string> p_enbFileOrFolderPaths, IEnumerable<CLSFindReplaceRecord> p_enbFindReplaceRecords)
		{
			List<string> lstFilePaths = new List<string>();
			foreach (string vstFileOrFolderPath in p_enbFileOrFolderPaths)
			{
				if (System.IO.Path.HasExtension(vstFileOrFolderPath))
				{
					lstFilePaths.Add(vstFileOrFolderPath);
				}
				else
				{
					// TODO: Determine how to determine if we should recurse into subfolders.
					lstFilePaths.AddRange(this.objReadFolder.fncReadFolderAsFilePathArray(vstFileOrFolderPath, false, true));
				}
			}

			this.subSearchFiles(lstFilePaths, p_enbFindReplaceRecords);
		}

		/// <inheritdoc/>
		public void subSearchFiles(IEnumerable<string> p_enbFileList, IEnumerable<CLSFindReplaceRecord> p_enbFindReplaceRecords)
		{
			Parallel.ForEach(p_enbFileList, p_vstFile => this.subSearchFile(p_vstFile, p_enbFindReplaceRecords));
		}

		private void subSearchFile(string p_vstFile, IEnumerable<CLSFindReplaceRecord> p_enbFindReplaceRecords)
		{
			string vstFileContents = this.objReadFile.fncReadFileAsString(p_vstFile);
			string vstFileContentsReplaced = this.objStringReplaceWithOptions.fncStringReplaceList(vstFileContents, p_enbFindReplaceRecords);
			this.objWriteFile.subWriteStringToFile(p_vstFile, vstFileContentsReplaced);
		}
	}
}
