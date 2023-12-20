// <copyright file="IFCStringReplaceWithOptions.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.Core.Ports.Incoming
{
	using FindAndReplace.Core.DataStructures;
	using System.Collections;

	/// <summary>
	/// Interface for single string replace operations.
	/// </summary>
	public interface IFCStringReplaceWithOptions
	{
		// TODO: Add Documentation
		public string fncStringReplaceList(string p_vstUSSearchIn, IEnumerable<CLSFindReplaceRecord> p_enbFindReplaceRecords);

		/// <summary>Manual entry text search. Performes a find and replace operation with the provided parameters.</summary>
		/// <param name="p_vstUSSearchIn">The string to search in.</param>
		/// <param name="p_vstUSFind">The string to find.</param>
		/// <param name="p_vstUSReplace">The string to replace with.</param>
		/// <param name="p_enmFindMode">The find mode.</param>
		/// <param name="p_vbnMatchCase">Case-sensitive matching if set to <c>true</c>.</param>
		/// <param name="p_vbnMatchWholeWord">Require word/not-word boundary on both sides of match if set to <c>true</c>.</param>
		/// <param name="p_vbnDotMatchesNewline">If using Regex, expands "." to also match newline characters if set to <c>true</c>.</param>
		/// <param name="p_vbnTreatLinesAsSeparateStrings">
		/// If using Regex, creates ^ and $ anchors for each line if set to <c>true</c>. If set to <c>false</c>, ^ only matches the beginning of the string, and $ only matches the end of the string.
		/// </param>
		/// <returns>The string resulting from performing the find and replace operation.</returns>
		public string fncStringReplaceWithOptions(string p_vstUSSearchIn, string p_vstUSFind, string p_vstUSReplace, ENMFindMode p_enmFindMode, bool p_vbnMatchCase, bool p_vbnMatchWholeWord, bool p_vbnDotMatchesNewline, bool p_vbnTreatLinesAsSeparateStrings);
	}
}
