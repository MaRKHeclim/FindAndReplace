namespace FindAndReplace.Core.DataStructures
{
	public class CLSFindReplaceRecord
	{
		public string vstFind;
		public string vstReplace;
		public ENMFindMode enmFindMode;
		public bool vbnMatchCase;
		public bool vbnMatchWholeWord;
		public bool vbnDotMatchesNewline;
		public bool vbnTreatLinesAsSeparateStrings;

		public CLSFindReplaceRecord(string p_vstFind = "", string p_vstReplace = "", ENMFindMode p_enmFindMode = ENMFindMode.Normal, bool p_vbnMatchCase = false, bool p_vbnMatchWholeWord = false, bool p_vbnDotMatchesNewline = false, bool p_vbnTreatLinesAsSeparateStrings = false)
		{
			this.vstFind = p_vstFind;
			this.vstReplace = p_vstReplace;
			this.enmFindMode = p_enmFindMode;
			this.vbnMatchCase = p_vbnMatchCase;
			this.vbnMatchWholeWord = p_vbnMatchWholeWord;
			this.vbnDotMatchesNewline = p_vbnDotMatchesNewline;
			this.vbnTreatLinesAsSeparateStrings = p_vbnTreatLinesAsSeparateStrings;
		}
	}
}
