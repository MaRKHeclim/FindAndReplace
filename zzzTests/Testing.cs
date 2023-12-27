// <copyright file="Testing.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.UnitTests
{
	using System.Collections.Generic;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class CLSTesting
	{
		[TestMethod]
		public void fncTest()
		{
			Stack<string> numbers = new Stack<string>();
			numbers.Push("one");
			numbers.Push("two");
			numbers.Push("three");
			numbers.Push("four");
			numbers.Push("five");

			string[] array = new string[] { "one", "two", "three", "four", "five" };

			Assert.AreEqual(array, numbers.ToArray());
		}
	}
}
