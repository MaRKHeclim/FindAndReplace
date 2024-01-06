// <copyright file="CLSCsvManagement.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.Core.DataStructures
{
	using System.Collections.Generic;
	using System.Linq;
	using FindAndReplace.Core.Ports.Outgoing;

	/// <inheritdoc/>
	internal class CLSCsvManagement : IFCCsvManagement
	{
		private readonly IFCReadFile objReadFile;
		private readonly IFCWriteFile objWriteFile;

		private Stack<CLSFindReplaceRecord> stcFindReplaceRecords;

		/// <summary>
		/// Initializes a new instance of the <see cref="CLSCsvManagement"/> class.
		/// </summary>
		public CLSCsvManagement(IFCReadFile p_objReadFile, IFCWriteFile p_objWriteFile)
		{
			this.stcFindReplaceRecords = new Stack<CLSFindReplaceRecord>();
			this.objReadFile = p_objReadFile;
			this.objWriteFile = p_objWriteFile;
		}

		/// <inheritdoc/>
		public IEnumerable<CLSFindReplaceRecord> fncMakeFindReplaceRecordList(IEnumerable<string> p_enbCSVPaths)
		{
			foreach (string vstCSVPath in p_enbCSVPaths)
			{
				IEnumerable<CLSFindReplaceRecord> enbFindReplaceRecordFile = this.objReadFile.fncReadCSVFileAsEnumerable<CLSFindReplaceRecord>(vstCSVPath);
				foreach (CLSFindReplaceRecord objFindReplaceRecord in enbFindReplaceRecordFile)
				{
					this.stcFindReplaceRecords.Push(objFindReplaceRecord);
				}
			}

			return this.stcFindReplaceRecords.ToArray().Reverse();
		}

		public void subAddFindReplaceRecord(CLSFindReplaceRecord p_objFindReplaceRecord)
		{
            this.stcFindReplaceRecords.Push(p_objFindReplaceRecord);

			// TODO: Determine if the output file needs to be on record add/remove or on save button click.
        }

		public void subRemoveFindReplaceRecord()
		{
            this.stcFindReplaceRecords.Pop();

            // TODO: Determine if the output file needs to be on record add/remove or on save button click.
        }

		public void subSaveFindReplaceRecordList(string p_vstAbsoluteFilePath)
		{
			IEnumerable<CLSFindReplaceRecord> enbFindReplaceRecords = this.stcFindReplaceRecords.ToArray().Reverse();
			this.objWriteFile.subWriteEnumerableToFileAsCSV(p_vstAbsoluteFilePath, enbFindReplaceRecords);
		}
    }
}
