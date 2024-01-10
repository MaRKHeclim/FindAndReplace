// <copyright file="CLSInstanceSettings.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.Core.DataStructures
{
	using System;

	internal class CLSInstanceSettings
	{
		public bool vbnDebug;
		public bool vbnRunAsGUIApp;
		public bool vbnRunAsCLIApp;
		public bool vbnRunAsPortListener;

		public CLSInstanceSettings(bool p_vbnDebug = false, bool p_vbnRunAsGUIApp = true, bool p_vbnRunAsCLIApp = false, bool p_vbnRunAsPortListener = false)
		{
			this.vbnDebug = p_vbnDebug;
			this.vbnRunAsGUIApp = p_vbnRunAsGUIApp;
			this.vbnRunAsCLIApp = p_vbnRunAsCLIApp;
			this.vbnRunAsPortListener = p_vbnRunAsPortListener;
		}

		public void subParseCommandLineArguments(string[] p_aryArguments)
		{
			// TODO: Implement this method.
			foreach (string strArgument in p_aryArguments)
			{
				switch (strArgument)
				{
					case "-d":
					case "--debug":
						this.vbnDebug = true;
						break;
					case "-g":
					case "--gui":
						this.vbnRunAsGUIApp = true;
						break;
					case "-c":
					case "--cli":
						this.vbnRunAsCLIApp = true;
						break;
					case "-p":
					case "--port":
						this.vbnRunAsPortListener = true;
						break;
					default:
						throw new ArgumentException($"Unknown argument: {strArgument}");
				}
			}
		}
	}
}
