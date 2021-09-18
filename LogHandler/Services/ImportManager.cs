using LogHandler.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogHandler.Services
{
    public class LogImportManager : IImportManager
    {
        private IUnitOfWork _unitOfWork;
        public LogImportManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool ImportAsync<T>(T logItem) where T: LogItem
        {
            try
            {
                if (logItem == null)
                    throw new ArgumentNullException(nameof(logItem));

                var subsystem = _unitOfWork.SubsystemRepository.Find(p => p.Name == logItem.Subsystem);
                if (subsystem == null)
                {
                    subsystem = new DAL.Entities.Subsystem()
                    {
                        Name = logItem.Subsystem
                    };
                }

                var type = _unitOfWork.TypeRepository.Find(p => p.Name == logItem.Type);
                if (type == null)
                {
                    type = new DAL.Entities.Type()
                    {
                        Name = logItem.Type
                    };
                }

                var log = _unitOfWork.LogRepository
                    .Find(p => p.DateTime == logItem.DateTime);

                if (log == null)
                {
                    log = new DAL.Entities.Log()
                    {
                        DateTime = logItem.DateTime,
                        Subsystem = subsystem,
                        Type = type,
                        Text = logItem.Text
                    };

                    _unitOfWork.LogRepository.Add(log);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка импорта лога: {ex.Message}");
            }
        }

    }
}
