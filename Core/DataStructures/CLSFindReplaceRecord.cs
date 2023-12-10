namespace FindAndReplace.Core.DataStructures
{
	internal class CLSFindReplaceRecord
	{
		public string vstFind;
		public string vstReplace;

		public CLSFindReplaceRecord(string p_vstFind = "", string p_vstReplace = "")
		{
			this.vstFind = p_vstFind;
			this.vstReplace = p_vstReplace;
		}
	}
}
