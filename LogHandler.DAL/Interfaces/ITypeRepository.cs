using LogHandler.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LogHandler.DAL.Interfaces
{
    public interface ITypeRepository
    {
        Entities.Type Add(Entities.Type value);
        List<Entities.Type> GetAll();
        void Remove(Guid id);
        Entities.Type Update(Entities.Type value);
        Entities.Type Find(Expression<Func<Entities.Type, bool>> predicate);
        IEnumerable<Entities.Type> FindAll(Expression<Func<Entities.Type, bool>> predicate);
    }
}