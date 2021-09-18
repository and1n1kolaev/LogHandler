using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogHandler.Parser
{
    public abstract class Parser<T> 
    {
        protected Regex Reg { get; set; }  
        public bool IsParsed(string line)
        {
            if (Reg == null)
                throw new ArgumentNullException(nameof(Reg));

            if(line == null)
                throw new ArgumentNullException(nameof(line));

            return Reg.IsMatch(line);
        }

        public abstract T Parse(string line);
    }


}
