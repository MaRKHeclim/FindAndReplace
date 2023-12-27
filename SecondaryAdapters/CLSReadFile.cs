namespace FindAndReplace.SecondaryAdapters
{
	using System.Data;
	using System.IO;
	using CsvHelper;

	/// <summary>
	/// Normal implementation of <see cref="Core.Ports.Outgoing.IFCReadFile"/>.
	/// </summary>
	/// <seealso cref="FindAndReplace.Core.Ports.Outgoing.IFCReadFile" />
	internal class CLSReadFile : Core.Ports.Outgoing.IFCReadFile
	{
		/// <inheritdoc/>
		public string fncReadFileAsString(string p_vstAbsoluteFilePath)
		{
			StreamReader stmStreamReader = new StreamReader(p_vstAbsoluteFilePath);
			string vstFileContent = stmStreamReader.ReadToEnd();
			stmStreamReader.Close();
			return vstFileContent;
		}

		/// <inheritdoc/>
		public string[] fncReadFileAsStringArray(string p_vstAbsoluteFilePath)
		{
			StreamReader stmStreamReader = new StreamReader(p_vstAbsoluteFilePath);
			string[] aryFileContent = stmStreamReader.ReadToEnd().Split('\n');

			// TODO: should we reappend the '\n' to each line?
			stmStreamReader.Close();
			return aryFileContent;
		}

		/// <inheritdoc/>
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

		/// <inheritdoc/>
		public IEnumerable<T> fncReadCSVFileAsEnumerable<T>(string p_vstAbsoluteFilePath)
		{
			StreamReader stmStreamReader = new StreamReader(p_vstAbsoluteFilePath);
			CsvReader stmCsvReader = new CsvReader(stmStreamReader, System.Globalization.CultureInfo.InvariantCulture);
			IEnumerable<T> enbData = stmCsvReader.GetRecords<T>();
			stmCsvReader.Dispose();
			stmStreamReader.Close();
			return enbData;
		}

		/// <inheritdoc/>
		public object fncReadJSONFileAsObject(string p_vstAbsoluteFilePath)
		{
			// TODO: Implement this method.
			throw new NotImplementedException();
		}
	}
}
