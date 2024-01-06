// <copyright file="Testing.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.UnitTests
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
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
			string[] numbersArray = numbers.ToArray().Reverse().ToArray();
			foreach (string number in numbersArray)
			{
				Console.WriteLine(number);
			}

			string[] array = new string[] { "one", "two", "three", "four", "five" };
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine(array[i]);
				Assert.AreEqual(array[i], numbersArray[i]);
			}
		}
	}
}
