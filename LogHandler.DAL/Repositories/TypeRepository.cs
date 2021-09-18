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
    public class TypeRepository : ITypeRepository
    {
        private ApplicationDbContext _context;
        public TypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Entities.Type Add(Entities.Type value)
        {

            _context.Add(value);
            _context.SaveChanges();

            return value;
        }

        public void Remove(Guid id)
        {
            var value = _context.Types.Find(id);
            if (value is not null)
            {
                _context.Types.Remove(value);
                _context.SaveChanges();
            }
        }

        public Entities.Type Update(Entities.Type value)
        {
            var local = _context.Types.Local.FirstOrDefault(entity => entity.Id == value.Id);
            if (local is not null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }

            _context.Entry(value).State = EntityState.Modified;
            _context.SaveChanges();
            return value;
        }

        public List<Entities.Type> GetAll()
        {
            return _context.Types.ToList();
        }

        public Entities.Type Find(Expression<Func<Entities.Type, bool>> predicate)
        {
            return _context.Types.FirstOrDefault(predicate);
        }

        public IEnumerable<Entities.Type> FindAll(Expression<Func<Entities.Type, bool>> predicate)
        {
            return _context.Types.Where(predicate).ToList();
        }
    }
}
