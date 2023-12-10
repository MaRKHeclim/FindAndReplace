namespace FindAndReplace.Core.Ports.Outgoing
{
	internal interface IFCReadFile
	{
		public string fncReadFileAsString(string p_vstAbsoluteFilePath);

		public string[] fncReadFileAsStringArray(string p_vstAbsoluteFilePath);

		public System.Data.DataTable fncReadCSVFileAsDataTable(string p_vstAbsoluteFilePath);

		public IEnumerable<T> fncReadCSVFileAsEnumerable<T>(string p_vstAbsoluteFilePath);

		public object fncReadJSONFileAsObject(string p_vstAbsoluteFilePath);
	}
}
