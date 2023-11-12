namespace FindAndReplace.SecondaryAdapters
{
    internal class CLSWriteFile : Core.Ports.Outgoing.IFCWriteFile
    {
        public void fncCreateBAKOfFile(string p_vstFilePath)
        {
            throw new NotImplementedException();
        }

        public void fncDeleteFile(string p_vstFilePath)
        {
            throw new NotImplementedException();
        }

        public void fncRenameFile(string p_vstFilePath, string p_vstNewFileName)
        {
            throw new NotImplementedException();
        }

        public void fncRestoreBAKOfFile(string p_vstFilePath)
        {
            throw new NotImplementedException();
        }

        public void fncWriteObjectAsCSVToFile(string p_vstFilePath, object p_objObject)
        {
            throw new NotImplementedException();
        }

        public void fncWriteObjectAsJSONToFile(string p_vstFilePath, object p_objObject)
        {
            throw new NotImplementedException();
        }

        public void fncWriteStringToFile(string p_vstFilePath, string p_vstFileContent)
        {
            throw new NotImplementedException();
        }
    }
}
