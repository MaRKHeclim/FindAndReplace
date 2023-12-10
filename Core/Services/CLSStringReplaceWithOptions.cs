// <copyright file="CLSStringReplaceWithOptions.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("FindAndReplace.Core.Tests")]

namespace FindAndReplace.Core.Services
{
	using System.Text.RegularExpressions;
	using FindAndReplace.Core.DataStructures;

	/// <inheritdoc/>
	public class CLSStringReplaceWithOptions : Core.Ports.Incoming.IFCStringReplaceWithOptions
	{
		public static string fncStringReplaceWithOptions(string p_vstUSSearchIn, string p_vstUSFind, string p_vstUSReplace, ENMFindMode p_enmFindMode, bool p_vbnMatchCase = true, bool p_vbnMatchWholeWord = false, bool p_vbnDotMatchesNewline = false, bool p_vbnTreatLinesAsSeparateStrings = true )
		{
			string vstResult = string.Empty;
			if (p_vstUSFind == string.Empty)
			{
				vstResult = p_vstUSSearchIn;
			}
			else if (p_vbnMatchWholeWord)
			{
				string vstUSFind = Regex.Escape(p_vstUSFind);
				vstUSFind = $"\\b{vstUSFind}\\b";
				vstResult = fncRegExReplace(p_vstUSSearchIn, vstUSFind, p_vstUSReplace, p_vbnMatchCase, p_vbnDotMatchesNewline, p_vbnTreatLinesAsSeparateStrings);
			}
			else if (p_enmFindMode == ENMFindMode.Normal)
			{
				// For ENMFindMode.Normal, treat all characters as literals - DO NOT convert escape sequences to their escaped character.
				string vstSearchIn = Regex.Escape(p_vstUSSearchIn);
				vstResult = vstSearchIn.Replace(p_vstUSFind, p_vstUSReplace, !p_vbnMatchCase, null);
				vstResult = Regex.Unescape(vstResult);
			}
			else if (p_enmFindMode == ENMFindMode.Extended)
			{
				// For ENMFindMode.Extended, treat all characters as literals except for the following:
				// \n - newline
				// \r - carriage return
				// \t - tab
				// \' - single quote
				// \" - double quote
				// \\ - backslash
				// \0 - null
				// \a - alert (bell)
				// \b - backspace
				// \f - form feed
				// \v - vertical tab
				vstResult = p_vstUSSearchIn.Replace(p_vstUSFind, p_vstUSReplace, !p_vbnMatchCase, null);
			}
			else if (p_enmFindMode == ENMFindMode.RegularExpression)
			{
				vstResult = fncRegExReplace(p_vstUSSearchIn, p_vstUSFind, p_vstUSReplace, p_vbnMatchCase, p_vbnDotMatchesNewline, p_vbnTreatLinesAsSeparateStrings);
			}

			return vstResult;
		}

		/// <summary>RegEx Replace.</summary>
		/// <param name="p_vstUSSearchIn">The string to search in.</param>
		/// <param name="p_vstUSFind">The string to find.</param>
		/// <param name="p_vstUSReplace">The string to replace with.</param>
		/// <param name="p_vbnMatchCase">Case-sensitive matching if set to <c>true</c>.</param>
		/// <param name="p_vbnDotMatchesNewline">Expands "." to also match newline characters if set to <c>true</c>.</param>
		/// <param name="p_vbnTreatLinesAsSeparateStrings">
		///   <para>
		/// Creates ^ and $ anchors for each line if set to <c>true</c>. If set to <c>false</c>, ^ only matches the beginning of the string, and $ only matches the end of the string.
		/// </para>
		///   <para>Note: Windows newline characters are of the form \r\n and the $ anchor only takes the place of \n . Consider replacing $ with (?=\r)?$ or \r?$ .</para>
		/// </param>
		/// <returns>The string resulting from performing the find and replace operation.</returns>
		internal static string fncRegExReplace(string p_vstUSSearchIn, string p_vstUSFind, string p_vstUSReplace, bool p_vbnMatchCase, bool p_vbnDotMatchesNewline, bool p_vbnTreatLinesAsSeparateStrings)
		{
			string vstResult = string.Empty;
			RegexOptions enmRegexOptions = RegexOptions.None;
			if (!p_vbnMatchCase)
			{
				enmRegexOptions |= RegexOptions.IgnoreCase;
			}

			if (p_vbnDotMatchesNewline)
			{
				enmRegexOptions |= RegexOptions.Singleline;
			}

			if (p_vbnTreatLinesAsSeparateStrings)
			{
				enmRegexOptions |= RegexOptions.Multiline;
			}

			if (p_vstUSFind == string.Empty)
			{
				vstResult = p_vstUSSearchIn;
			}
			else
			{
				vstResult = Regex.Replace(p_vstUSSearchIn, p_vstUSFind, p_vstUSReplace, enmRegexOptions);
			}

			return vstResult;
		}
	}
}
