using LogHandler.Parser;
using System.Collections.Generic;

namespace LogHandler.Services
{
    public interface IParseCollectionManager
    {
        IEnumerable<T> StringsToObjects<T>(IEnumerable<string> strCollection) where T : Parser<T>, new();
    }
}