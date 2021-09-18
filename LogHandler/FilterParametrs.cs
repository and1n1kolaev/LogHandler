using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogHandler
{
    public class FilterParametrs
    {
        public DateTime DateTimeFrom { get; set; }
        public DateTime DateTimeTo { get; set; }
        public string Sybsystem { get; set; }
        public List<char> Types { get; set; }

        public FilterParametrs()
        {
            Types = new List<char>();
        }
    }
}
