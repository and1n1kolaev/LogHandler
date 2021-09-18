using LogHandler.Parser;
using System;
using System.Collections.Generic;

namespace LogHandler.Services
{
    public class ParseCollectionManager : IParseCollectionManager
    {
        public IEnumerable<T> StringsToObjects<T>(IEnumerable<string> strCollection) where T : Parser<T>, new()
        {
            T obj = new();
            string line = String.Empty;
            foreach (var str in strCollection)
            {
                var stringLine = str.TrimStart();
                if (obj.IsParsed(stringLine))
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        yield return obj.Parse(line);
                        line = String.Empty;
                    }
                    line = stringLine;
                }
                else
                {
                    line += stringLine;
                }
            }
        }
    }
}
