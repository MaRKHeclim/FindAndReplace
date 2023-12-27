// <copyright file="ENMFindMode.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.Core.DataStructures
{
	/// <summary>
	///   <br />
	/// </summary>
	public enum ENMFindMode
	{
		/// <summary>Normal
		/// - Match Characters As-Is</summary>
		Normal,

		/// <summary>Extended
		/// - Match Special Characters</summary>
		Extended,

		/// <summary>Regular expression
		/// - Regex based search</summary>
		RegularExpression,
	}
}