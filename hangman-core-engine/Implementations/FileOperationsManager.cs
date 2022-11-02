using hangman_core_engine.Interfaces;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;


namespace hangman_core_engine.Implementations
{
    [ExcludeFromCodeCoverage]
    public class FileOperationsManager : IFileOperationsManager
    {
        public string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
