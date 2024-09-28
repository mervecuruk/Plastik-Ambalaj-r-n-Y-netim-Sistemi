using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.LogService
{
    public class LogService : ILogService
    {
        private readonly ILogRepository _logRepository;

        public LogService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        /// <summary>
        /// Yeni Log Ekleme yapar
        /// </summary>
        /// <param name="level"></param>
        /// <param name="source"></param>
        /// <param name="message"></param>
        /// <param name="exceptionDetails"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<bool> AddLogAsync(string level, string source, string message, string? exceptionDetails, int? userId)
        {
            return await _logRepository.AddLogAsync(level, source, message, exceptionDetails, userId);
        }

        /// <summary>
        /// Parametredeki Id'ye ait Log siler
        /// </summary>
        /// <param name="logId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteLogAsync(long logId)
        {
            return await _logRepository.DeleteLogAsync(logId);
        }

        /// <summary>
        /// Tüm Error logları döndürür
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Log>> GetAllErrorLogsAsync()
        {
            return await _logRepository.GetAllErrorLogsAsync();
        }

        /// <summary>
        /// Parametredeki tarihler arasındaki ve AppUserId'ye ait Error Logları döndürür
        /// </summary>
        /// <param name="firstDate"></param>
        /// <param name="secondDate"></param>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllErrorLogsByDateandUserIdAsync(DateTime firstDate, DateTime secondDate, int appUserId)
        {
            return await _logRepository.GetAllErrorLogsByDateandUserIdAsync(firstDate, secondDate, appUserId);
        }

        /// <summary>
        /// Parametreki tarihler arasındaki Error Logları döndürür
        /// </summary>
        /// <param name="firstDate"></param>
        /// <param name="secondDate"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllErrorLogsByDateAsync(DateTime firstDate, DateTime secondDate)
        {
            return await _logRepository.GetAllErrorLogsByDateAsync(firstDate, secondDate);
        }

        /// <summary>
        /// Parametredeki AppUserId'ye ait Tüm Error Logları döndürür
        /// </summary>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Log>> GetAllErrorLogsByUserIdAsync(int appUserId)
        {
            return await _logRepository.GetAllErrorLogsByUserIdAsync(appUserId);
        }

        /// <summary>
        /// Tüm Information Logları döndürür
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Log>> GetAllInformationLogsAsync()
        {
            return _logRepository.GetAllInformationLogsAsync();
        }

        /// <summary>
        /// Parametredeki tarihler arasındaki ve AppUserId'ye aite tüm Information logları döndürür
        /// </summary>
        /// <param name="firstDate"></param>
        /// <param name="secondDate"></param>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllInformationLogsByDateandUserIdAsync(DateTime firstDate, DateTime secondDate, int appUserId)
        {
            return await _logRepository.GetAllInformationLogsByDateandUserIdAsync(firstDate, secondDate, appUserId);
        }

        /// <summary>
        /// Parametredeki tarihler arasındaki tüm Information logları döndürür
        /// </summary>
        /// <param name="firstDate"></param>
        /// <param name="secondDate"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllInformationLogsByDateAsync(DateTime firstDate, DateTime secondDate)
        {
            return await _logRepository.GetAllInformationLogsByDateAsync(firstDate, secondDate);
        }

        /// <summary>
        /// Parametredeki AppUserId'ye ait tüm Information logları döndürür
        /// </summary>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllInformationLogsByUserIdAsync(int appUserId)
        {
            return await _logRepository.GetAllInformationLogsByUserIdAsync(appUserId);
        }

        /// <summary>
        /// Tüm Logları döndürür
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllLogsAsync()
        {
            return await _logRepository.GetAllLogsAsync();
        }

        /// <summary>
        /// Parametredeki tarihler arasındaki tüm Logları döndürür
        /// </summary>
        /// <param name="firstDate"></param>
        /// <param name="secondDate"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Log>> GetAllLogsByDateAsync(DateTime firstDate, DateTime secondDate)
        {
            return await _logRepository.GetAllLogsByDateAsync(firstDate, secondDate);
        }

        /// <summary>
        /// Parametredeki LogId'ye ait Log döndürür
        /// </summary>
        /// <param name="logId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Log> GetLogByIdAsync(long logId)
        {
            return await _logRepository.GetLogByIdAsync(logId);
        }
    }
}
