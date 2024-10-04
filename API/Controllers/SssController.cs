using ApplicationLayer.Models.DTOs.SssDTOs;
using ApplicationLayer.Services.LogService;
using ApplicationLayer.Services.SssService;
using DomainLayer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SssController : ControllerBase
    {
        private readonly ISssService _sssService;
        private readonly ILogService _logService;

        public SssController(ISssService sssService, ILogService logService)
        {
            _sssService = sssService;
            _logService = logService;
        }

        [HttpPost]
        public async Task<IActionResult> AddSss(SssCreatedDTO sssCreatedDTO)
        {
            try
            {
                await _sssService.AddSssAsync(sssCreatedDTO);
                await _logService.AddLogAsync("Information", "SssController", $"AddSss Success => Sss Title: {sssCreatedDTO.AskTitle}", "-", null);
                return Ok();
            }
            catch (Exception ex)
            {

                await _logService.AddLogAsync("Error", "SssController", $"AddSss Error => Sss Title: {sssCreatedDTO.AskTitle}", ex.ToString(), null);
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSss(int id)
        {
            try
            {
                await _sssService.DeleteSssAsync(id);
                await _logService.AddLogAsync("Information", "SssController", $"DeleteSss Success => Sss ID: {id}", "-", null);
                return Ok();
            }
            catch (Exception ex)
            {


                await _logService.AddLogAsync("Error", "SssController", $"DeleteSss Error => Sss ID: {id}", ex.ToString(), null);
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdatedSss(SssUpdatedDTO sssUpdatedDTO)
        {
            try
            {
                await _sssService.UpdatedSssAsync(sssUpdatedDTO);
                await _logService.AddLogAsync("Information", "SssController", $"UpdatedSss Success => Sss ID: {sssUpdatedDTO.Id}", "-", null);
                return Ok();
            }
            catch (Exception ex)
            {

                await _logService.AddLogAsync("Error", "SssController", $"UpdatedSss Error => Sss ID: {sssUpdatedDTO.Id}", ex.ToString(), null);
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSss()
        {
            try
            {
                IEnumerable<Sss> result = await _sssService.GetAllSssAsync();
                await _logService.AddLogAsync("Information", "SssController", $"GetAllSss Success", "-", null);
                return Ok(result);

            }
            catch (Exception ex)
            {
                await _logService.AddLogAsync("Error", "SssController", $"GetAllSss Error", ex.ToString(), null);
                return NotFound();

            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSssById(int id)
        {
            try
            {
                Sss result = await _sssService.GetSssByIdAsync(id);
                await _logService.AddLogAsync("Information", "SssController", $"GetSssById Success => Sss ID: {id}", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {

                await _logService.AddLogAsync("Error", "SssController", $"GetSssById Error => Sss ID: {id}", ex.ToString(), null);
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAcceptRequestAdmin()
        {
            try
            {
                IEnumerable<Sss> result = await _sssService.GetAcceptRequestAdminAsync();
                await _logService.AddLogAsync("Information", "SssController", $"GetAcceptRequestAdmin Success", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                await _logService.AddLogAsync("Error", "SssController", $"GetAcceptRequestAdmin Error", ex.ToString(), null);
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAcceptRequestAdminAccepted()
        {
            try
            {
                IEnumerable<Sss> result = await _sssService.GetAcceptRequestAdminAcceptedAsync();
                await _logService.AddLogAsync("Information", "SssController", $"GetAcceptRequestAdminAccepted Success", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                await _logService.AddLogAsync("Error", "SssController", $"GetAcceptRequestAdminAccepted Error", ex.ToString(), null);
                return NotFound();
            }
        }


    }
}
