namespace FindAndReplace.Core.Ports.Outgoing
{
    using System.Data;

    internal interface IFCReadFile
    {
        public string fncReadFileAsString(string p_vstAbsoluteFilePath);

        public string[] fncReadFileAsStringArray(string p_vstAbsoluteFilePath);

        public DataTable fncReadCSVFileAsDataTable(string p_vstAbsoluteFilePath);

        public object fncReadJSONFileAsObject(string p_vstAbsoluteFilePath);
    }
}
