namespace FindAndReplace.App
{
	using FindAndReplace.Core.DataStructures;

	internal static class CLSStart
	{
		/// <summary>The main entry point for the application.</summary>
		/// <param name="p_aryArguments"></param>
		[STAThread]
		public static void Main(string[] p_aryArguments)
		{
			CLSInstanceSettings objSettings = new CLSInstanceSettings();

			// TODO: Parse arguments

			// Run application
			subRunApp(objSettings);
		}

		private static void subRunApp(CLSInstanceSettings p_objInstanceSettings)
		{
			CLSApplication objApplication = new CLSApplication(p_objInstanceSettings);

			// Starts GUI/Web Server if necessary
			objApplication.subStart();

			// If necessary, do stuff
			// TODO: Determine how to handle running as a CLI app

			// Stop application
			objApplication.subStop();
		}
	}
}