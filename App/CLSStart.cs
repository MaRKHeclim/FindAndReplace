// <copyright file="CLSStart.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.App
{
	using System;
	using FindAndReplace.Core.DataStructures;

	/// <summary>
	/// The main entry point for the application.
	/// </summary>
	internal static class CLSStart
	{
		/// <summary>The main entry point for the application.</summary>
		/// <param name="p_aryArguments">Command-line arguments passed to the program.</param>
		[STAThread]
		public static void Main(string[] p_aryArguments)
		{
			if (p_aryArguments.Length < 1)
			{
				subDisplayHelp();
				return;
			}

			CLSInstanceSettings objInstanceSettings = new CLSInstanceSettings();
			objInstanceSettings.subParseCommandLineArguments(p_aryArguments);

			// Run application
			CLSApplication objApplication = new CLSApplication(objInstanceSettings);

			// Starts GUI/Web Server if necessary
			objApplication.subStart();

			// If necessary, do stuff
			// TODO: Determine how to handle running as a CLI app

			// Stop application
			// objApplication.subStop();
		}

		private static void subDisplayHelp()
		{
			Console.WriteLine("Usage: FindAndReplace [options]");
		}
	}
}

// TODO: Change Create Backups checkbox to groupbox with radio buttons: Disabled, In Same Folder, In Subfolder
// TODO: Test Mode?
// TODO: Allow search in Office Files?
// TODO: Undo Operation
// TODO: Count replacements
// TODO: Tie UI to APP
// TODO: Add more testing
// TODO: Finish Documentation
// TODO: Add support for renaming files/folders
// 			Going to require re-evaluating filepaths in the UI
// 			Don't open files if only renaming
// 				List.TrueForAll?