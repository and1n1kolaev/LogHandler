using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogHandler
{
    public class ImportStatistic
    {
        public long CountTypeI { get; private set; }
        public long CountTypeD { get; private set; }
        public long CountTypeW { get; private set; }
        public long CountTypeE { get; private set; }
        public long AmountComputed { get; private set; }
        public long AmountImported { get; private set; }

        public void UpdateStatistic(LogItem log, bool isImported)
        {
            if (log == null)
                throw new NullReferenceException(nameof(log));

            if (isImported)
            {
                switch (log.Type)
                {
                    case 'I': CountTypeI++; break;
                    case 'D': CountTypeD++; break;
                    case 'W': CountTypeW++; break;
                    case 'E': CountTypeE++; break;
                    default:
                        break;
                }
                AmountImported++;
            }

            AmountComputed++;      
        }
    }
}
