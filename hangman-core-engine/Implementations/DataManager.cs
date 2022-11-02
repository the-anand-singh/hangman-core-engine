using hangman_core_engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman_core_engine.Implementations
{
    internal class DataManager : IDataManager
    {
        private readonly IDataFileRepository m_DataFileRepository;

        public DataManager(IDataFileRepository dataFileRepository)
        {
            m_DataFileRepository = dataFileRepository;
        }

        public IEnumerable<string> GetAllData()
        {
            return m_DataFileRepository.GetAllFileData();
        }
    }
}
