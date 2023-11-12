namespace FindAndReplace.Core.Ports.Outgoing
{
    internal interface IFCWriteFile
    {
        public void fncWriteStringToFile(string p_vstFilePath, string p_vstFileContent);

        public void fncWriteObjectAsJSONToFile(string p_vstFilePath, object p_objFileContent);

        public void fncWriteObjectAsCSVToFile(string p_vstFilePath, object p_objFileContent);

        public void fncCreateBAKOfFile(string p_vstFilePath);

        public void fncRestoreBAKOfFile(string p_vstFilePath);

        public void fncDeleteFile(string p_vstFilePath);

        public void fncRenameFile(string p_vstFilePath, string p_vstNewFileName);
    }
}
