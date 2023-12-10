namespace FindAndReplace.SecondaryAdapters
{
	using System.Collections;
	using System.IO;
	using CsvHelper;

	/// <inheritdoc/>
	internal class CLSWriteFile : Core.Ports.Outgoing.IFCWriteFile
	{
		/// <inheritdoc/>
		public void subCreateBAKOfFile(string p_vstAbsoluteFilePath)
		{
			FileInfo filFileToBackup = new FileInfo(p_vstAbsoluteFilePath);
			filFileToBackup.CopyTo(p_vstAbsoluteFilePath + ".bak", true);
		}

		/// <inheritdoc/>
		public void subCreateFile(string p_vstAbsoluteFilePath)
		{
			if (!File.Exists(p_vstAbsoluteFilePath))
			{
				if (!Directory.Exists(Path.GetDirectoryName(p_vstAbsoluteFilePath)))
				{
					this.subCreateFolder(Path.GetDirectoryName(p_vstAbsoluteFilePath));
				}

				File.Create(p_vstAbsoluteFilePath);
			}
		}

		/// <inheritdoc/>
		public void subCreateFolder(string p_vstAbsoluteFolderPath)
		{
			DirectoryInfo dirDirectoryToCreate = new DirectoryInfo(p_vstAbsoluteFolderPath);
			dirDirectoryToCreate.Create();
		}

		/// <inheritdoc/>
		public void subDeleteFile(string p_vstAbsoluteFilePath)
		{
			DirectoryInfo dirDirectoryToDelete = new DirectoryInfo(p_vstAbsoluteFilePath);
			dirDirectoryToDelete.Delete();
		}

		/// <inheritdoc/>
		public void subRenameFile(string p_vstAbsoluteFilePath, string p_vstNewFileName)
		{
			string? vstParentDirectoryName = Path.GetDirectoryName(p_vstAbsoluteFilePath);
			if (vstParentDirectoryName == null)
			{
				vstParentDirectoryName = Path.GetPathRoot(p_vstAbsoluteFilePath);
			}

			string vstAbsoluteFilePathNew = vstParentDirectoryName + Path.DirectorySeparatorChar + p_vstNewFileName;
			File.Move(p_vstAbsoluteFilePath, vstAbsoluteFilePathNew);
		}

		/// <inheritdoc/>
		// TODO: Add capability to store the .bak files in a subfolder: \Backup(FindAndReplaceMRK)\Timestamp?
		public void subRestoreBAKOfFile(string p_vstAbsoluteFilePath)
		{
			if (p_vstAbsoluteFilePath.EndsWith(".bak"))
			{
				string vstParentDirectoryName = Path.GetDirectoryName(p_vstAbsoluteFilePath);
				string vstFileName = Path.GetFileNameWithoutExtension(p_vstAbsoluteFilePath);
				string vstAbsoluteFilePathNew = vstParentDirectoryName + Path.DirectorySeparatorChar + vstFileName;
				File.Move(p_vstAbsoluteFilePath, vstAbsoluteFilePathNew);
			}
			else if (Path.Exists(p_vstAbsoluteFilePath + ".bak"))
			{
				File.Move(p_vstAbsoluteFilePath + ".bak", p_vstAbsoluteFilePath);
			}
			else
			{
				throw new FileNotFoundException("No backup file found for " + p_vstAbsoluteFilePath);
			}
		}

		/// <inheritdoc/>
		public void subWriteEnumerableToFileAsCSV(string p_vstAbsoluteFilePath, IEnumerable p_enbFileContent)
		{
			StreamWriter stmStreamWriter = new StreamWriter(p_vstAbsoluteFilePath);
			CsvWriter stmCsvWriter = new CsvWriter(stmStreamWriter, System.Globalization.CultureInfo.InvariantCulture);
			stmCsvWriter.WriteRecords(p_enbFileContent);
			stmCsvWriter.Flush();
			stmCsvWriter.Dispose();
			stmStreamWriter.Close();
		}

		/// <inheritdoc/>
		public void subWriteObjectAsJSONToFile(string p_vstAbsoluteFilePath, object p_objFileContent)
		{
			throw new NotImplementedException();
		}

		/// <inheritdoc/>
		public void subWriteStringToFile(string p_vstAbsoluteFilePath, string p_vstFileContent)
		{
			File.WriteAllText(p_vstAbsoluteFilePath, p_vstFileContent);
		}
	}
}
