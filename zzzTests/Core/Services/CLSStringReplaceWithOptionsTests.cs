// <copyright file="CLSStringReplaceWithOptionsTests.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.Core.Services.Tests
{
	using System;
	using FindAndReplace.Core.DataStructures;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass()]
	public class CLSStringReplaceWithOptionsTests
	{
		string? vstUSSearchIn;
		string? vstUSFind;
		string? vstUSReplace;
		bool vbnMatchCase;
		bool vbnDotMatchesNewline;
		bool vbnTreatLinesAsSeparateStrings;
		string? vstResult;
		string? vstExpected;

		CLSStringReplaceWithOptions clsStringReplaceWithOptions = new CLSStringReplaceWithOptions();

		#region fncRegExReplace
		[TestMethod()]
		public void fncRegExReplace_ParametersAreNull_ThrowsException()
		{
			//Prepare
			
			//Call Function Being Tested
			
			//Check Results
			Assert.ThrowsException<ArgumentNullException>(() => clsStringReplaceWithOptions.fncRegExReplace(vstUSSearchIn, vstUSFind, vstUSReplace, vbnMatchCase, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings));

			//Clean Up
		}

		[TestMethod()]
		public void fncRegExReplace_AllStringsAreEmpty_ReturnsEmptyString()
		{
			//Prepare
			vstUSSearchIn = string.Empty;
			vstUSFind = string.Empty;
			vstUSReplace = string.Empty;
			vbnMatchCase = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncRegExReplace(vstUSSearchIn, vstUSFind, vstUSReplace, vbnMatchCase, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual(string.Empty, vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncRegExReplace_SearchInIsEmpty_ReturnsEmptyString()
		{
			//Prepare
			vstUSSearchIn = string.Empty;
			vstUSFind = "foo";
			vstUSReplace = "bar";
			vbnMatchCase = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncRegExReplace(vstUSSearchIn, vstUSFind, vstUSReplace, vbnMatchCase, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual(string.Empty, vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncRegExReplace_FindIsEmpty_ReturnsInitialString()
		{
			//Prepare
			vstUSSearchIn = "foo";
			vstUSFind = string.Empty;
			vstUSReplace = "bar";
			vbnMatchCase = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncRegExReplace(vstUSSearchIn, vstUSFind, vstUSReplace, vbnMatchCase, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual("foo", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncRegExReplace_ReplaceIsEmpty_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "foobar";
			vstUSFind = "bar";
			vstUSReplace = string.Empty;
			vbnMatchCase = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncRegExReplace(vstUSSearchIn, vstUSFind, vstUSReplace, vbnMatchCase, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual("foo", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncRegExReplace_SimpleFindReplace_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "foobar";
			vstUSFind = "bar";
			vstUSReplace = "foo";
			vbnMatchCase = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncRegExReplace(vstUSSearchIn, vstUSFind, vstUSReplace, vbnMatchCase, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual("foofoo", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncRegExReplace_SimpleMultipleFindReplace_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "barfoobar";
			vstUSFind = "bar";
			vstUSReplace = "foo";
			vbnMatchCase = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncRegExReplace(vstUSSearchIn, vstUSFind, vstUSReplace, vbnMatchCase, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual("foofoofoo", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncRegExReplace_ExtendableMultipleFindReplace_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "foooobar";
			vstUSFind = "foo";
			vstUSReplace = "fo";
			vbnMatchCase = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncRegExReplace(vstUSSearchIn, vstUSFind, vstUSReplace, vbnMatchCase, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual("fooobar", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncRegExReplace_RegExFindSimpleReplace_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "foooobar";
			vstUSFind = "fo+";
			vstUSReplace = "fo";
			vbnMatchCase = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncRegExReplace(vstUSSearchIn, vstUSFind, vstUSReplace, vbnMatchCase, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual("fobar", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncRegExReplace_RegExFindRegExReplace1_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "Edit the Expression";
			vstUSFind = "([A-Z])\\w+";
			vstUSReplace = "<< $& >>";
			vbnMatchCase = true;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncRegExReplace(vstUSSearchIn, vstUSFind, vstUSReplace, vbnMatchCase, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual("<< Edit >> the << Expression >>", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncRegExReplace_CaseInsensitiveFind_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "Pump1FTS PumpsFTS pump2FTS";
			vstUSFind = "Pump(\\d)";
			vstUSReplace = "Blower$1";
			vbnMatchCase = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncRegExReplace(vstUSSearchIn, vstUSFind, vstUSReplace, vbnMatchCase, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual("Blower1FTS PumpsFTS Blower2FTS", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncRegExReplace_CaseSensitiveFind_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "Pump1FTS PumpsFTS pump2FTS";
			vstUSFind = "Pump(\\d)";
			vstUSReplace = "Blower$1";
			vbnMatchCase = true;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncRegExReplace(vstUSSearchIn, vstUSFind, vstUSReplace, vbnMatchCase, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual("Blower1FTS PumpsFTS pump2FTS", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncRegExReplace_DotDoesNotMatchNewline_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = $"Multiline Statement First Line{Environment.NewLine}" +
							$"Second line{Environment.NewLine}" + 
							$"Third {Environment.NewLine}" + 
							$"Line";
			vstUSFind = "d.*?line";
			vstUSReplace = "d-Line";
			vbnMatchCase = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			vstExpected = $"Multiline Statement First Line{Environment.NewLine}" +
						  $"Second-Line{Environment.NewLine}" +
						  $"Third {Environment.NewLine}" +
						  $"Line";

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncRegExReplace(vstUSSearchIn, vstUSFind, vstUSReplace, vbnMatchCase, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual(vstExpected, vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncRegExReplace_DotMatchesNewline_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = $"Multiline Statement First Line{Environment.NewLine}" +
							$"Second line{Environment.NewLine}" +
							$"Third {Environment.NewLine}" +
							$"Line";
			vstUSFind = "d.*?line";
			vstUSReplace = "d-Line";
			vbnMatchCase = false;
			vbnDotMatchesNewline = true;
			vbnTreatLinesAsSeparateStrings = false;

			vstExpected = $"Multiline Statement First Line{Environment.NewLine}" +
						  $"Second-Line{Environment.NewLine}" +
						  $"Third-Line";

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncRegExReplace(vstUSSearchIn, vstUSFind, vstUSReplace, vbnMatchCase, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual(vstExpected, vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncRegExReplace_TreatAsSingleString_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = $"Multiline Statement First Line{Environment.NewLine}" +
							$"Second line{Environment.NewLine}" +
							$"Third Line";
			vstUSFind = "d\\sline(?=\\r?$)";
			vstUSReplace = "d-Line";
			vbnMatchCase = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			vstExpected = $"Multiline Statement First Line{Environment.NewLine}" +
						  $"Second line{Environment.NewLine}" +
						  $"Third-Line";

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncRegExReplace(vstUSSearchIn, vstUSFind, vstUSReplace, vbnMatchCase, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual(vstExpected, vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncRegExReplace_TreatAsMultipleStrings_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = $"Multiline Statement First Line{Environment.NewLine}" +
							$"Second line{Environment.NewLine}" +
							$"Third Line";
			vstUSFind = "d\\sline(?=\\r?$)";
			vstUSReplace = "d-Line";
			vbnMatchCase = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = true;

			vstExpected = $"Multiline Statement First Line{Environment.NewLine}" +
						  $"Second-Line{Environment.NewLine}" +
						  $"Third-Line";

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncRegExReplace(vstUSSearchIn, vstUSFind, vstUSReplace, vbnMatchCase, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual(vstExpected, vstResult);

			//Clean Up
		}

		#endregion

		ENMFindMode enmFindMode;
		bool vbnMatchWholeWord;

		#region fncStringReplaceWithOptions
		[TestMethod()]
		public void fncStringReplaceWithOptions_ParametersAreNull_ThrowsException()
		{
			//Prepare

			//Call Function Being Tested

			//Check Results
			Assert.ThrowsException<ArgumentNullException>(() => clsStringReplaceWithOptions.fncStringReplaceWithOptions(vstUSSearchIn, vstUSFind, vstUSReplace, enmFindMode, vbnMatchCase, vbnMatchWholeWord, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings));

			//Clean Up
		}

		[TestMethod()]
		public void fncStringReplaceWithOptions_AllStringsAreEmpty_ReturnsEmptyString()
		{
			//Prepare
			vstUSSearchIn = string.Empty;
			vstUSFind = string.Empty;
			vstUSReplace = string.Empty;
			enmFindMode = ENMFindMode.Normal;
			vbnMatchCase = false;
			vbnMatchWholeWord = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncStringReplaceWithOptions(vstUSSearchIn, vstUSFind, vstUSReplace, enmFindMode, vbnMatchCase, vbnMatchWholeWord, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual(string.Empty, vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncStringReplaceWithOptions_SearchInIsEmpty_ReturnsEmptyString()
		{
			//Prepare
			vstUSSearchIn = string.Empty;
			vstUSFind = "foo";
			vstUSReplace = "bar";
			enmFindMode = ENMFindMode.Normal;
			vbnMatchCase = false;
			vbnMatchWholeWord = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncStringReplaceWithOptions(vstUSSearchIn, vstUSFind, vstUSReplace, enmFindMode, vbnMatchCase, vbnMatchWholeWord, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);
			//Check Results
			Assert.AreEqual(string.Empty, vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncStringReplaceWithOptions_FindIsEmpty_ReturnsInitialString()
		{
			//Prepare
			vstUSSearchIn = "foo";
			vstUSFind = string.Empty;
			vstUSReplace = "bar";
			enmFindMode = ENMFindMode.Normal;
			vbnMatchCase = false;
			vbnMatchWholeWord = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncStringReplaceWithOptions(vstUSSearchIn, vstUSFind, vstUSReplace, enmFindMode, vbnMatchCase, vbnMatchWholeWord, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);

			//Check Results
			Assert.AreEqual("foo", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncStringReplaceWithOptions_ReplaceIsEmpty_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "foobar";
			vstUSFind = "bar";
			vstUSReplace = string.Empty;
			enmFindMode = ENMFindMode.Normal;
			vbnMatchCase = false;
			vbnMatchWholeWord = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncStringReplaceWithOptions(vstUSSearchIn, vstUSFind, vstUSReplace, enmFindMode, vbnMatchCase, vbnMatchWholeWord, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);

			//Check Results
			Assert.AreEqual("foo", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncStringReplaceWithOptions_SimpleFindReplace_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "foobar";
			vstUSFind = "bar";
			vstUSReplace = "foo";
			enmFindMode = ENMFindMode.Normal;
			vbnMatchCase = false;
			vbnMatchWholeWord = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncStringReplaceWithOptions(vstUSSearchIn, vstUSFind, vstUSReplace, enmFindMode, vbnMatchCase, vbnMatchWholeWord, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);

			//Check Results
			Assert.AreEqual("foofoo", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncStringReplaceWithOptions_SimpleMultipleFindReplace_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "barfoobar";
			vstUSFind = "bar";
			vstUSReplace = "foo";
			enmFindMode = ENMFindMode.Normal;
			vbnMatchCase = false;
			vbnMatchWholeWord = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncStringReplaceWithOptions(vstUSSearchIn, vstUSFind, vstUSReplace, enmFindMode, vbnMatchCase, vbnMatchWholeWord, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);

			//Check Results
			Assert.AreEqual("foofoofoo", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncStringReplaceWithOptions_ExtendableMultipleFindReplace_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "foooobar";
			vstUSFind = "foo";
			vstUSReplace = "fo";
			enmFindMode = ENMFindMode.Normal;
			vbnMatchCase = false;
			vbnMatchWholeWord = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncStringReplaceWithOptions(vstUSSearchIn, vstUSFind, vstUSReplace, enmFindMode, vbnMatchCase, vbnMatchWholeWord, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);

			//Check Results
			Assert.AreEqual("fooobar", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncStringReplaceWithOptions_RegExFindSimpleReplace_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "foooobar";
			vstUSFind = "fo+";
			vstUSReplace = "fo";
			enmFindMode = ENMFindMode.RegularExpression;
			vbnMatchCase = false;
			vbnMatchWholeWord = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncStringReplaceWithOptions(vstUSSearchIn, vstUSFind, vstUSReplace, enmFindMode, vbnMatchCase, vbnMatchWholeWord, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);

			//Check Results
			Assert.AreEqual("fobar", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncStringReplaceWithOptions_CaseInsensitiveFind_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "Pump1FTS PumpsFTS pump2FTS";
			vstUSFind = "Pump";
			vstUSReplace = "Blower";
			enmFindMode = ENMFindMode.Normal;
			vbnMatchCase = false;
			vbnMatchWholeWord = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncStringReplaceWithOptions(vstUSSearchIn, vstUSFind, vstUSReplace, enmFindMode, vbnMatchCase, vbnMatchWholeWord, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);

			//Check Results
			Assert.AreEqual("Blower1FTS BlowersFTS Blower2FTS", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncStringReplaceWithOptions_CaseSensitiveFind_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "Pump1FTS PumpsFTS pump2FTS";
			vstUSFind = "Pump";
			vstUSReplace = "Blower";
			enmFindMode = ENMFindMode.Normal;
			vbnMatchCase = true;
			vbnMatchWholeWord = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncStringReplaceWithOptions(vstUSSearchIn, vstUSFind, vstUSReplace, enmFindMode, vbnMatchCase, vbnMatchWholeWord, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);

			//Check Results
			Assert.AreEqual("Blower1FTS BlowersFTS pump2FTS", vstResult);

			//Clean Up
		}

		[TestMethod()]
		public void fncStringReplaceWithOptions_MatchWholeWord_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "Pump1FTS PumpsFTS pump";
			vstUSFind = "Pump";
			vstUSReplace = "Blower";
			enmFindMode = ENMFindMode.Normal;
			vbnMatchCase = false;
			vbnMatchWholeWord = true;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncStringReplaceWithOptions(vstUSSearchIn, vstUSFind, vstUSReplace, enmFindMode, vbnMatchCase, vbnMatchWholeWord, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);

			//Check Results
			Assert.AreEqual("Pump1FTS PumpsFTS Blower", vstResult);

			//Clean Up
		}

		// TODO: Double Check vstUSSearchIn With User Input
		[TestMethod()]
		public void fncStringReplaceWithOptions_ExtendedCharsFindModeNormal_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "Pump1FTS\r\n\tPumpsFTS\\pump";
			vstUSFind = @"\";
			vstUSReplace = "_";
			enmFindMode = ENMFindMode.Normal;
			vbnMatchCase = false;
			vbnMatchWholeWord = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncStringReplaceWithOptions(vstUSSearchIn, vstUSFind, vstUSReplace, enmFindMode, vbnMatchCase, vbnMatchWholeWord, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);

			//Check Results
			Assert.AreEqual("Pump1FTS_r_n_tPumpsFTS__pump", vstResult);

			//Clean Up
		}

		// TODO: Double Check vstUSSearchIn With User Input
		[TestMethod()]
		public void fncStringReplaceWithOptions_ExtendedCharsFindModeExtended_ReturnsAppropriateString()
		{
			//Prepare
			vstUSSearchIn = "Pump1FTS\r\n\tPumpsFTS\\pump";
			vstUSFind = @"\";
			vstUSReplace = "_";
			enmFindMode = ENMFindMode.Extended;
			vbnMatchCase = false;
			vbnMatchWholeWord = false;
			vbnDotMatchesNewline = false;
			vbnTreatLinesAsSeparateStrings = false;

			//Call Function Being Tested
			vstResult = clsStringReplaceWithOptions.fncStringReplaceWithOptions(vstUSSearchIn, vstUSFind, vstUSReplace, enmFindMode, vbnMatchCase, vbnMatchWholeWord, vbnDotMatchesNewline, vbnTreatLinesAsSeparateStrings);

			//Check Results
			Assert.AreEqual("Pump1FTS\r\n\tPumpsFTS_pump", vstResult);

			//Clean Up
		}
		#endregion
	}
}