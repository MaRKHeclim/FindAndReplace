// <copyright file="IFCCsvManagement.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.Core.DataStructures
{

	public interface IFCCsvManagement
	{
		public System.Collections.Generic.IEnumerable<CLSFindReplaceRecord> fncMakeFindReplaceRecordList(System.Collections.Generic.IEnumerable<string> p_enbCSVPaths);

		public void subAddFindReplaceRecord(CLSFindReplaceRecord p_objFindReplaceRecord);

		public void subRemoveFindReplaceRecord();

		public void subSaveFindReplaceRecordList(string p_vstAbsoluteFilePath);
	}
}
