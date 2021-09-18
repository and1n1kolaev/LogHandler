using LogHandler.DAL.Interfaces;
using LogHandler.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogHandler.DAL
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public EFUnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        private ILogRepository _logRepository;
        private ITypeRepository _typeRepository;
        private ISubsystemRepository _subsystemRepository;

        public ILogRepository LogRepository
        {
            get
            {
                if (_logRepository == null)
                    _logRepository = new LogRepository(_context);
                return _logRepository;
            }
        }

        public ITypeRepository TypeRepository
        {
            get
            {
                if (_typeRepository == null)
                    _typeRepository = new TypeRepository(_context);
                return _typeRepository;
            }
        }

        public ISubsystemRepository SubsystemRepository
        {
            get
            {
                if (_subsystemRepository == null)
                    _subsystemRepository = new SubsystemRepository(_context);
                return _subsystemRepository;
            }
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
