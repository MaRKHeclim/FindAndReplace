namespace FindAndReplace.SecondaryAdapters
{
    using CsvHelper;
    using System.Data;
    using System.IO;

    internal class CLSReadFile : Core.Ports.Outgoing.IFCReadFile
    {
        public string fncReadFileAsString(string p_vstAbsoluteFilePath)
        {
            StreamReader stmStreamReader = new StreamReader(p_vstAbsoluteFilePath);
            string vstFileContent = stmStreamReader.ReadToEnd();
            stmStreamReader.Close();
            return vstFileContent;
        }

        public string[] fncReadFileAsStringArray(string p_vstAbsoluteFilePath)
        {
            StreamReader stmStreamReader = new StreamReader(p_vstAbsoluteFilePath);
            string[] aryFileContent = stmStreamReader.ReadToEnd().Split('\n');

            // TODO: should we reappend the '\n' to each line?
            stmStreamReader.Close();
            return aryFileContent;
        }

        public DataTable fncReadCSVFileAsDataTable(string p_vstAbsoluteFilePath)
        {
            StreamReader stmStreamReader = new StreamReader(p_vstAbsoluteFilePath);
            CsvReader stmCsvReader = new CsvReader(stmStreamReader, System.Globalization.CultureInfo.InvariantCulture);
            CsvDataReader stmCsvDataReader = new CsvDataReader(stmCsvReader);
            DataTable tblData = new DataTable();
            tblData.Load(stmCsvDataReader);
            stmCsvDataReader.Close();
            stmCsvReader.Dispose();
            stmStreamReader.Close();
            return tblData;
        }

        public object fncReadJSONFileAsObject(string p_vstAbsoluteFilePath)
        {
            throw new NotImplementedException();
        }
    }
}
