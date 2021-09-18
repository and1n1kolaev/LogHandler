using LogHandler.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogHandler.DAL.Interfaces
{
    public interface ILogRepository
    {
        Log Update(Log log);
        Log Add(Log log);
        void Remove(Guid id);
        List<Log> GetAll();
        Log Find(Expression<Func<Log, bool>> predicate);
        IEnumerable<Log> FindAll(Expression<Func<Log, bool>> predicate);
    }
}
