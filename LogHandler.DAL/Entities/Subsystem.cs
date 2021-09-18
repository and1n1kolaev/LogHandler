using System;
using System.Collections.Generic;

namespace LogHandler.DAL.Entities
{
    public class Subsystem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Log> Logs { get; set; }
    }
}