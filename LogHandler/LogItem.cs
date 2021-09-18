using LogHandler.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogHandler
{
    public class LogItem : Parser<LogItem>
    {
        public DateTime DateTime { get; set; }
        public char Type { get; set; }
        public string Subsystem { get; set; }
        public string Text { get; set; }
        public LogItem() 
        {
            Reg = new Regex(@"(^[0-9]{2}\.[0-9]{2}\.[0-9]{4} [0-9]{2}[:]{1}[0-9]{2}[:]{1}[0-9]{2}) ([I|D|W|E]) (\w+) ");
        }

        public override LogItem Parse(string line)
        {
            try
            {
                var groups = Reg.Match(line).Groups;
                DateTime = DateTime.Parse(groups[1].Value);
                Type = char.Parse(groups[2].Value);
                Subsystem = groups[3].Value;
                Text = line.Substring(groups[0].Length, line.Length - groups[0].Length).Trim();

                return this;
            }
            catch (Exception)
            {
               throw new Exception($"Невозможно преобразовать строку в {this}");
            }
            
           
        }

    
    }
}
