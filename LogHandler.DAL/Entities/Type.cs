using System;
using System.Collections.Generic;

namespace LogHandler.DAL.Entities
{
    public class Type
    {
        public Guid Id { get; set; }
        public char Name { get; set; }
        public List<Log> Logs { get; set; }
    }
}