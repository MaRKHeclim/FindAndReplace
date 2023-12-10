namespace FindAndReplace.Core.DataStructures
{
	internal class CLSInstanceSettings
	{
		public bool vbnDebug;
		public bool vbnRunAsGUIApp;
		public bool vbnRunAsCLIApp;
		public bool vbnRunAsPortListener;

		// TODO: Determine if any methods are created for this class. If not, change to a struct.
		public CLSInstanceSettings(bool p_vbnDebug = false, bool p_vbnRunAsGUIApp = true, bool p_vbnRunAsCLIApp = false, bool p_vbnRunAsPortListener = false)
		{
			this.vbnDebug = p_vbnDebug;
			this.vbnRunAsGUIApp = p_vbnRunAsGUIApp;
			this.vbnRunAsCLIApp = p_vbnRunAsCLIApp;
			this.vbnRunAsPortListener = p_vbnRunAsPortListener;
		}
	}
}
