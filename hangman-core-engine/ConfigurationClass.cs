namespace hangman_core_engine
{
    public class ConfigurationClass
    {
        private string _dataFileFullPath;

        public ConfigurationClass()
        {
            
        }

        public void SetFilePath(string DataFileFullPath)
        {
            _dataFileFullPath =  DataFileFullPath;
        }

        public string GetFilePath(string DataFileFullPath)
        {
            return _dataFileFullPath;
        }
    }
}