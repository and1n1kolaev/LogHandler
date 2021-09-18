using System;
using System.Collections.Generic;
using System.IO;

namespace LogHandler.Services
{
    public class FileManager : IFileManager
    {
        public IEnumerable<string> ReadFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                throw new ArgumentNullException(nameof(filePath));

            if(File.Exists(filePath))          
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        yield return line;
                    }
                }
            }
        }
    }
}
