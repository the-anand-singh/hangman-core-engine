using hangman_core_engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman_core_engine.Implementations
{
    public class DataFileRepository : IDataFileRepository
    {
        private readonly IFileOperationsManager m_FileOperationsManager;
        private readonly string m_DataFileFullPath;
        ConfigurationClass configurations = new();

        public DataFileRepository(IFileOperationsManager fileOperationsManager, string dataFileFullPath)
        {
            m_FileOperationsManager = fileOperationsManager;
            m_DataFileFullPath = configurations.GetFilePath();
        }

        public IEnumerable<string> GetAllFileData()
        {
            return m_FileOperationsManager.ReadAllLines(m_DataFileFullPath);
        }
    }
}
