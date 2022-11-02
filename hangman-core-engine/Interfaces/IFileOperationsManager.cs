using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman_core_engine.Interfaces
{
    public interface IFileOperationsManager
    {
        string[] ReadAllLines(string path);
    }
}
