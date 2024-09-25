using ApplicationLayer.Models.DTOs.OfferCartMessageDTOs;
using ApplicationLayer.Services.OfferCartMessageService;
using AutoMapper;
using DomainLayer;
using DomainLayer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OfferCartMessageController : ControllerBase
    {
        private readonly IOfferCartMessageService _offerCartMessageService;
        private readonly IMapper _mapper;

        public OfferCartMessageController(IOfferCartMessageService offerCartMessageService, IMapper mapper)
        {
            _offerCartMessageService = offerCartMessageService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> AddOfferCartMessage(AddOfferCartMessageDTO offerCartMessage)
        {
            await _offerCartMessageService.AddMessageAsync(offerCartMessage);
            return Ok(offerCartMessage);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOfferCartMessage(int id)
        {
            try
            {
                await _offerCartMessageService.DeleteMessageAsync(id);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }

        }

        [HttpGet("{offerCartId}")]
        public async Task<IActionResult> GetMessagesByOfferCartId(int offerCartId)
        {
            return Ok(await _offerCartMessageService.GetMessagesByOfferCartIdAsync(offerCartId));
        }

        [HttpGet("{appUserId}")]
        public async Task<IActionResult> GetMessagesByUserId(int appUserId)
        {
            return Ok(await _offerCartMessageService.GetMessagesByUserIdAsync(appUserId));
        }
    }
}
