// <copyright file="IFCCsvManagement.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.Core.DataStructures
{
	using System.Collections.Generic;

	internal interface IFCCsvManagement
	{
		public IEnumerable<CLSFindReplaceRecord> fncMakeFindReplaceRecordList(IEnumerable<string> p_enbCSVPaths);

		public void subAddFindReplaceRecord(CLSFindReplaceRecord p_objFindReplaceRecord);

		public void subRemoveFindReplaceRecord();

		public void subSaveFindReplaceRecordList();
	}
}
