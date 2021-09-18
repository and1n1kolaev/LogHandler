using System.Threading.Tasks;

namespace LogHandler.Services
{
    public interface IImportManager
    {
        bool ImportAsync<T>(T logItem) where T : LogItem;
    }



}