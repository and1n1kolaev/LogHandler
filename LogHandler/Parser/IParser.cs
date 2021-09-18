using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogHandler.Parser
{
    public interface IParser<T>
    {
       T Parse(string line);
        bool IsParsered(string line, out string[] result);
    }
}
