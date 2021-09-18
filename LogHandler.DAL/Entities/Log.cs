using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogHandler.DAL.Entities
{
    public class Log
    {
        public Guid Id { get; set; }
        public DateTime DateTime { get; set; }
        public Guid SubsystemId { get; set; }
        public Subsystem Subsystem { get; set; }
        public Guid TypeId { get; set; }
        public Type Type { get; set; }
        public string Text { get; set; }
    }
}
