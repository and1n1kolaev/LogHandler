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
    public class SubsystemRepository : ISubsystemRepository
    {
        private ApplicationDbContext _context;
        public SubsystemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Subsystem Add(Subsystem value)
        {

            _context.Add(value);
            _context.SaveChanges();

            return value;
        }

        public void Remove(Guid id)
        {
            var value = _context.Subsystems.Find(id);
            if (value is not null)
            {
                _context.Subsystems.Remove(value);
                _context.SaveChanges();
            }
        }

        public Subsystem Update(Subsystem value)
        {
            var local = _context.Subsystems.Local.FirstOrDefault(entity => entity.Id == value.Id);
            if (local is not null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }

            _context.Entry(value).State = EntityState.Modified;
            _context.SaveChanges();
            return value;
        }

        public List<Subsystem> GetAll()
        {
            return _context.Subsystems.ToList();
        }

        public Subsystem Find(Expression<Func<Subsystem, bool>> predicate)
        {
            return _context.Subsystems.FirstOrDefault(predicate);
        }

        public IEnumerable<Subsystem> FindAll(Expression<Func<Subsystem, bool>> predicate)
        {
            return _context.Subsystems.Where(predicate).AsEnumerable();
        }

       
    }
}
