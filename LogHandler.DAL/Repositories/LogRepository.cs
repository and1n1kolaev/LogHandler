using LogHandler.DAL.Entities;
using LogHandler.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogHandler.DAL.Repositories
{
    public class LogRepository : ILogRepository
    {
        private ApplicationDbContext _context;
        public LogRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Log Add(Log value)
        {

            _context.Add(value);
            _context.SaveChanges();

            return value;
        }

        public void Remove(Guid id)
        {
            var value = _context.Logs.Find(id);
            if (value is not null)
            {
                _context.Logs.Remove(value);
                _context.SaveChanges();
            }
        }

        public Log Update(Log value)
        {
            var local = _context.Logs.Local.FirstOrDefault(entity => entity.Id == value.Id);
            if (local is not null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }

            _context.Entry(value).State = EntityState.Modified;
            _context.SaveChanges();
            return value;
        }

        public List<Log> GetAll()
        {
            return _context.Logs.ToList();
        }

        public Log Find(Expression<Func<Log, bool>> predicate)
        {
            return _context.Logs.FirstOrDefault(predicate);
        }

        public IEnumerable<Log> FindAll(Expression<Func<Log, bool>> predicate)
        {
            return _context.Logs
                .Include(p => p.Subsystem)
                .Include(p => p.Type)
                .Where(predicate).AsEnumerable();
        }

     
    }
}
