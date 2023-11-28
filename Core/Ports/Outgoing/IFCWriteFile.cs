namespace FindAndReplace.Core.Ports.Outgoing
{
    internal interface IFCWriteFile
    {
        public void fncWriteStringToFile(string p_vstAbsoluteFilePath, string p_vstFileContent);

        public void fncWriteObjectAsJSONToFile(string p_vstAbsoluteFilePath, object p_objFileContent);

        public void fncWriteObjectAsCSVToFile(string p_vstAbsoluteFilePath, object p_objFileContent);

        public void fncCreateBAKOfFile(string p_vstAbsoluteFilePath);

        public void fncRestoreBAKOfFile(string p_vstAbsoluteFilePath);

        public void fncDeleteFile(string p_vstAbsoluteFilePath);

        public void fncRenameFile(string p_vstAbsoluteFilePath, string p_vstNewFileName);
    }
}
