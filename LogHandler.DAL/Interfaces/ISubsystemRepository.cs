using LogHandler.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LogHandler.DAL.Interfaces
{
    public interface ISubsystemRepository
    {
        Subsystem Add(Subsystem value);
        List<Subsystem> GetAll();
        void Remove(Guid id);
        Subsystem Update(Subsystem value);
        Subsystem Find(Expression<Func<Subsystem, bool>> predicate);
        IEnumerable<Subsystem> FindAll(Expression<Func<Subsystem, bool>> predicate);
    }
}