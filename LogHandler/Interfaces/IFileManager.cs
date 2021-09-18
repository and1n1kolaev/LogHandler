using System.Collections.Generic;

namespace LogHandler.Services
{
    public interface IFileManager
    {
        IEnumerable<string> ReadFile(string filePath);
    }
}