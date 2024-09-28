using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using InfrastructureLayer.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Concrete
{
    public class LogRepository : ILogRepository
    {
        private readonly LogDbContext _logDbContext;

        public LogRepository(LogDbContext logDbContext)
        {
            _logDbContext = logDbContext;
        }


        /// <summary>
        /// Log Ekleme İşlemi yapar
        /// </summary>
        /// <param name="level"></param>
        /// <param name="source"></param>
        /// <param name="message"></param>
        /// <param name="exceptionDetails"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<bool> AddLogAsync(string level, string source, string message, string? exceptionDetails, int? userId)
        {
            Log newLog = new Log()
            {
                Level = level,
                Source = source,
                Message = message,
                ExceptionDetails = exceptionDetails == null ? null : exceptionDetails,
                UserId = userId == null ? null : userId
            };
            _logDbContext.logs.Add(newLog);
            return await _logDbContext.SaveChangesAsync() > 0;
        }

        /// <summary>
        /// Log silme işlemi yapar LogId parametreli
        /// </summary>
        /// <param name="logId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteLogAsync(long logId)
        {
            Log log = await _logDbContext.logs.FindAsync(logId);
            if (log == null) return false;
            else
            {
                _logDbContext.logs.Remove(log);
                return await _logDbContext.SaveChangesAsync() > 0;
            }
        }

        /// <summary>
        /// Tüm Error Logları döndürür IEnumerable
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllErrorLogsAsync()
        {
            IEnumerable<Log> errorLogs = await _logDbContext.logs.Where(x => x.Level == "Error").ToListAsync();
            return errorLogs;
        }

        /// <summary>
        /// Parametredeki tarihler ve AppUserId'ye ait Tüm Error Logları döndürür
        /// </summary>
        /// <param name="firstDate"></param>
        /// <param name="secondDate"></param>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllErrorLogsByDateandUserIdAsync(DateTime firstDate, DateTime secondDate, int appUserId)
        {
            IEnumerable<Log> userErrorLogs = await _logDbContext.logs.Where(x => x.Time > firstDate && x.Time < secondDate && x.UserId == appUserId && x.Level == "Error").ToListAsync();
            return userErrorLogs;
        }

        /// <summary>
        /// Parametredeki 2 tarih arasındaki Tüm Error Logları döndürür
        /// </summary>
        /// <param name="firstDate"></param>
        /// <param name="secondDate"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllErrorLogsByDateAsync(DateTime firstDate, DateTime secondDate)
        {
            IEnumerable<Log> errorLogs = await _logDbContext.logs.Where(x => x.Time > firstDate && x.Time < secondDate && x.Level == "Error").ToListAsync();
            return errorLogs;
        }

        /// <summary>
        /// Parametredeki AppUserId'ye ait ilgili Error Logları döndürür IEnumerable
        /// </summary>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllErrorLogsByUserIdAsync(int appUserId)
        {
            IEnumerable<Log> userErrorLogs = await _logDbContext.logs.Where(x => x.UserId == appUserId && x.Level == "Error").ToListAsync();
            return userErrorLogs;
        }

        /// <summary>
        /// Tüm Information Logları döndürür IEnumerable
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllInformationLogsAsync()
        {
            IEnumerable<Log> informationLogs = await _logDbContext.logs.Where(x => x.Level == "Information").ToListAsync();
            return informationLogs;
        }


        /// <summary>
        /// Parametredeki tarihler ve AppUserId'ye ait Tüm Information Logları döndürür
        /// </summary>
        /// <param name="firstDate"></param>
        /// <param name="secondDate"></param>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllInformationLogsByDateandUserIdAsync(DateTime firstDate, DateTime secondDate, int appUserId)
        {
            IEnumerable<Log> userInformationLogs = await _logDbContext.logs.Where(x => x.Time > firstDate && x.Time < secondDate && x.UserId == appUserId && x.Level == "Information").ToListAsync();
            return userInformationLogs;
        }

        /// <summary>
        /// Parametredeki 2 tarih arasındaki Tüm Information Logları döndürür
        /// </summary>
        /// <param name="firstDate"></param>
        /// <param name="secondDate"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllInformationLogsByDateAsync(DateTime firstDate, DateTime secondDate)
        {
            IEnumerable<Log> informationLogs = await _logDbContext.logs.Where(x => x.Time > firstDate && x.Time < secondDate && x.Level == "Information").ToListAsync();
            return informationLogs;
        }


        /// <summary>
        /// Parametredeki AppUserId'ye ait ilgili Information Logları döndürür IEnumerable
        /// </summary>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllInformationLogsByUserIdAsync(int appUserId)
        {
            IEnumerable<Log> userInformationLogs = await _logDbContext.logs.Where(x => x.UserId == appUserId && x.Level == "Information").ToListAsync();
            return userInformationLogs;
        }

        /// <summary>
        /// Tüm Logları döndürür
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllLogsAsync()
        {
            IEnumerable<Log> allLogs = await _logDbContext.logs.ToListAsync();
            return allLogs;
        }

        /// <summary>
        /// Parametredeki 2 tarih arasındaki Tüm Logları döndürür
        /// </summary>
        /// <param name="firstDate"></param>
        /// <param name="secondDate"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllLogsByDateAsync(DateTime firstDate, DateTime secondDate)
        {
            IEnumerable<Log> allLogs = await _logDbContext.logs.Where(x => x.Time > firstDate && x.Time < secondDate).ToListAsync();
            return allLogs;
        }

        /// <summary>
        /// Parametredeki Id'ye ait ilgili Log döndürür
        /// </summary>
        /// <param name="logId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Log> GetLogByIdAsync(long logId)
        {
            Log log = await _logDbContext.logs.FindAsync(logId);
            if (log == null) return null;
            else return log;
        }
    }
}
