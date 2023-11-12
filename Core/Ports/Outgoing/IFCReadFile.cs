namespace FindAndReplace.Core.Ports.Outgoing
{
    internal interface IFCReadFile
    {
        public string fncReadFileAsString(string p_vstFilePath);

        public object fncReadCSVFileAsObject(string p_vstFilePath);

        public object fncReadJSONFileAsObject(string p_vstFilePath);
    }
}
