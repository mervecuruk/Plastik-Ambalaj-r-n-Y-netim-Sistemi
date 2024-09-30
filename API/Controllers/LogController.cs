using ApplicationLayer.Services.LogService;
using DomainLayer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ILogService _logService;

        public LogController(ILogService logService)

        {

            _logService = logService;

        }

        [HttpPost]

        public async Task<IActionResult> AddLog(string level, string source, string message, string? exceptionDetails, int? userId)

        {

            try

            {

                bool result = await _logService.AddLogAsync(level, source, message, exceptionDetails, userId);

                return Ok(result);

            }

            catch (Exception)

            {

                bool fal = false;

                return BadRequest(fal);

            }

        }


        [HttpDelete("{logId}")]

        public async Task<IActionResult> DeleteLog(int logId)

        {

            try

            {

                bool result = await _logService.DeleteLogAsync(logId);

                return Ok(result);

            }

            catch (Exception)

            {

                bool fal = false;

                return BadRequest(fal);

            }

        }

        [HttpGet]

        public async Task<IActionResult> GetAllLogs()

        {

            try

            {

                IEnumerable<Log> logs = await _logService.GetAllLogsAsync();

                return Ok(logs);

            }

            catch (Exception)

            {

                return NotFound("Log kaydı bulunamadı..");

            }

        }


        [HttpGet("{logId}")]

        public async Task<IActionResult> GetLogById(int logId)

        {

            try

            {

                Log log = await _logService.GetLogByIdAsync(logId);

                return Ok(log);

            }

            catch (Exception)

            {

                return NotFound("Id'ye ait Log bulunamadı");

            }

        }

        [HttpGet]

        public async Task<IActionResult> GetAllErrorLogs()

        {

            try

            {

                IEnumerable<Log> errorLogs = await _logService.GetAllErrorLogsAsync();

                return Ok(errorLogs);

            }

            catch (Exception)

            {

                return NotFound("Error Logları bulunamadı");

            }

        }

        [HttpGet]

        public async Task<IActionResult> GetAllInformationLogs()

        {

            try

            {

                IEnumerable<Log> informationLogs = await _logService.GetAllInformationLogsAsync();

                return Ok(informationLogs);

            }

            catch (Exception)

            {

                return NotFound("Information Logları bulunamadı");

            }

        }

        [HttpGet("{appUserId}")]

        public async Task<IActionResult> GetAllErrorLogsByUserId(int appUserId)

        {

            try

            {

                IEnumerable<Log> errorLogsByUser = await _logService.GetAllErrorLogsByUserIdAsync(appUserId);

                return Ok(errorLogsByUser);

            }

            catch (Exception)

            {

                return NotFound("Kullanıcı ID'ye ait Error Loglar bulunamadı");

            }

        }

        [HttpGet("{appUserId}")]

        public async Task<IActionResult> GetAllInformationLogsByUserId(int appUserId)

        {

            try

            {

                IEnumerable<Log> informationLogsByUser = await _logService.GetAllInformationLogsByUserIdAsync(appUserId);

                return Ok(informationLogsByUser);

            }

            catch (Exception)

            {

                return NotFound("Kullanıcı ID'ye ait Error Loglar bulunamadı");

            }

        }

        [HttpGet]

        public async Task<IActionResult> GetAllLogsByDate(DateTime firstDate, DateTime secondDate)

        {

            try

            {

                IEnumerable<Log> logsByDate = await _logService.GetAllLogsByDateAsync(firstDate, secondDate);

                return Ok(logsByDate);

            }

            catch (Exception)

            {

                return NotFound("Belirtilen tarihler arasındaki log kayıtları bulunamadı");

            }

        }

        [HttpGet]

        public async Task<IActionResult> GetAllErrorLogsByDate(DateTime firstDate, DateTime secondDate)

        {

            try

            {

                IEnumerable<Log> logsErrorByDate = await _logService.GetAllErrorLogsByDateAsync(firstDate, secondDate);

                return Ok(logsErrorByDate);

            }

            catch (Exception)

            {

                return NotFound("Belirtilen tarihler arasındaki Error Log kayıtları bulunamadı");

            }

        }

        [HttpGet]

        public async Task<IActionResult> GetAllInformationLogsByDate(DateTime firstDate, DateTime secondDate)

        {

            try

            {

                IEnumerable<Log> logsInformationByDate = await _logService.GetAllInformationLogsByDateAsync(firstDate, secondDate);

                return Ok(logsInformationByDate);

            }

            catch (Exception)

            {

                return NotFound("Belirtilen tarihler arasındaki Information Log kayıtları bulunamadı");

            }

        }

        [HttpGet]

        public async Task<IActionResult> GetAllInformationLogsByDateandUserId(DateTime firstDate, DateTime secondDate, int appUserId)

        {

            try

            {

                IEnumerable<Log> logsInformationByDateandUser = await _logService.GetAllInformationLogsByDateandUserIdAsync(firstDate, secondDate, appUserId);

                return Ok(logsInformationByDateandUser);

            }

            catch (Exception)

            {

                return NotFound("Belirtilen tarihler ve UserId'ye ait Information Log kayıtları bulunamadı");

            }

        }

        [HttpGet]

        public async Task<IActionResult> GetAllErrorLogsByDateandUserIdAsync(DateTime firstDate, DateTime secondDate, int appUserId)

        {

            try

            {

                IEnumerable<Log> logsErrorByDateandUser = await _logService.GetAllErrorLogsByDateandUserIdAsync(firstDate, secondDate, appUserId);

                return Ok(logsErrorByDateandUser);

            }

            catch (Exception)

            {

                return NotFound("Belirtilen tarihler ve UserId'ye ait Error Log kayıtları bulunamadı");

            }

        }

    }
}
