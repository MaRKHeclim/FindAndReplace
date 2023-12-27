// <copyright file="CLSCsvManagement.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.Core.DataStructures
{
	using System.Collections.Generic;

	/// <inheritdoc/>
	internal class CLSCsvManagement : IFCCsvManagement
	{
		private Stack<CLSFindReplaceRecord> stcFindReplaceRecords;

		/// <summary>
		/// Initializes a new instance of the <see cref="CLSCsvManagement"/> class.
		/// </summary>
		public CLSCsvManagement()
		{
			this.stcFindReplaceRecords = new Stack<CLSFindReplaceRecord>();
		}

		/// <inheritdoc/>
		public IEnumerable<CLSFindReplaceRecord> fncMakeFindReplaceRecordList(IEnumerable<string> p_enbCSVPaths)
		{
			// TODO: Implement this method.
			throw new System.NotImplementedException();
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

		public void subSaveFindReplaceRecordList()
		{
			// TODO: Implement this method.
			throw new System.NotImplementedException();
		}
    }
}
