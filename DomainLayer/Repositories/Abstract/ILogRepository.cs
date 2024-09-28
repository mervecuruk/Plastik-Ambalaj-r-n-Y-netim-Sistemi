using DomainLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Repositories.Abstract
{
    public interface ILogRepository
    {
        Task<bool> AddLogAsync(string level, string source, string message, string? exceptionDetails, int? userId);
        Task<bool> DeleteLogAsync(long logId);
        Task<IEnumerable<Log>> GetAllLogsAsync();
        Task<Log> GetLogByIdAsync(long logId);
        Task<IEnumerable<Log>> GetAllErrorLogsAsync();
        Task<IEnumerable<Log>> GetAllInformationLogsAsync();
        Task<IEnumerable<Log>> GetAllErrorLogsByUserIdAsync(int appUserId);
        Task<IEnumerable<Log>> GetAllInformationLogsByUserIdAsync(int appUserId);
        Task<IEnumerable<Log>> GetAllLogsByDateAsync(DateTime firstDate, DateTime secondDate);
        Task<IEnumerable<Log>> GetAllErrorLogsByDateAsync(DateTime firstDate, DateTime secondDate);
        Task<IEnumerable<Log>> GetAllInformationLogsByDateAsync(DateTime firstDate, DateTime secondDate);
        Task<IEnumerable<Log>> GetAllInformationLogsByDateandUserIdAsync(DateTime firstDate, DateTime secondDate, int appUserId);
        Task<IEnumerable<Log>> GetAllErrorLogsByDateandUserIdAsync(DateTime firstDate, DateTime secondDate, int appUserId);
    }
}
