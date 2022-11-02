namespace hangman_core_engine
{
    public class ConfigurationClass
    {
        string _dataFileFullPath;

        public ConfigurationClass()
        {
            _dataFileFullPath = "";
        }

        public void SetFilePath(string DataFileFullPath)
        {
            _dataFileFullPath = DataFileFullPath;
        }

        public string GetFilePath()
        {
            return _dataFileFullPath;
        }
    }
}