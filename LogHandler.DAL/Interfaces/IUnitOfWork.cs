using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogHandler.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ILogRepository LogRepository { get; }
        ITypeRepository TypeRepository { get; }
        ISubsystemRepository SubsystemRepository { get; }
    }
}
