using ApplicationLayer.Models.DTOs.OfferCartDTOs;
using ApplicationLayer.Services.OfferCartService;
using DomainLayer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OfferCartController : ControllerBase
    {
        private readonly IOfferCartService _offerCartService;
        private readonly ILogger _logger;

        public OfferCartController(IOfferCartService offerCartService, ILogger logger)
        {
            _offerCartService = offerCartService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> AddOfferCart(AddOfferCartDTO offerCart)
        {
            try
            {
                OfferCart offer = await _offerCartService.AddOfferCartAsync(offerCart);
                _logger.LogInformation($"Offer cart is being added => {offerCart}");
                return Ok(offer);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while adding offer cart => {offerCart}");
                return BadRequest("Add OfferCart Error");
            }
        }



        [HttpGet("{offerCartId}")]
        public async Task<IActionResult> ApproveByAdmin(int offerCartId)
        {
            try
            {
                bool result = await _offerCartService.ApproveOfferByAdminAsync(offerCartId);
                _logger.LogInformation($"Approved By Admin Success => {offerCartId}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,$"Admin Approved Error => {offerCartId}");
                return BadRequest("Error");
            }
        }


        [HttpGet("{offerCartId}")]
        public async Task<IActionResult> ApproveSamplePreparation(int offerCartId)
        {
            try
            {
                bool result = await _offerCartService.ApproveSamplePreparationAsync(offerCartId);
                _logger.LogInformation($"Approved Sample Preparation Success => {offerCartId}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"SamplePreparation Approved Error => {offerCartId}");
                return BadRequest("Error");
            }
        }

        [HttpDelete("{offerCartId}")]
        public async Task<IActionResult> DeleteOfferCart(int offerCartId)
        {
            try
            {
                bool deleteResult = await _offerCartService.DeleteOfferCartAsync(offerCartId);
                _logger.LogInformation($"OfferCart Delete Successfuly => {offerCartId}");
                return Ok(deleteResult);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"OfferCart Delete Error => {offerCartId}");
                return BadRequest("Error");
            }
        }

        [HttpGet("{appUserId}")]
        public async Task<IActionResult> GetAllByUserId(int appUserId)
        {
            try
            {
               IEnumerable<OfferCart> result = await _offerCartService.GetAllByUserIdAsync(appUserId);
                _logger.LogInformation($"GetAllByUserId Result Success IEnumerable<OfferCart> => UserId: {appUserId}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetAllByUserId Result Error => ID : {appUserId}");
                return BadRequest("Error");
            }
        }


        [HttpGet("{searchKeyword}/{appUserId}")]
        public async Task<IActionResult> GetOfferCartByKeywordAndUserId(string searchKeyword, int appUserId)
        {
            try
            {
                List<OfferCart> result = await _offerCartService.GetOfferCartByKeywordAndUserId(searchKeyword, appUserId);
                _logger.LogInformation($"GetOfferCartByKeywordAndUserId Success => Keyword: {searchKeyword} / UserId: {appUserId}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetOfferCartByKeywordAndUserId Error => Keyword: {searchKeyword} / UserId: {appUserId}");
                return BadRequest("Error");
            }
        }


        [HttpDelete("{appUserId}")]
        public async Task<IActionResult> RemoveAllProductsForUserId(int appUserId)
        {
            try
            {
                bool result = await _offerCartService.RemoveAllProductsForUserAsync(appUserId);
                _logger.LogInformation($"RemoveAllProductsForUser Success => UserId: {appUserId} ");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"RemoveAllProductsForUser Error => UserId: {appUserId}");
                return BadRequest("Error");
            }
        }

        [HttpGet("{offerCartId}")]
        public async Task<IActionResult> SetFinalization(int offerCartId)
        {
            try
            {
                bool result = await _offerCartService.SetFinalizationAsync(offerCartId);
                _logger.LogInformation($"SetFinalization Success => {offerCartId}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"SetFinalization Error => {offerCartId}");
                return BadRequest("Error");
            }
        }

        [HttpGet("{offerCartId}")]
        public async Task<IActionResult> SetMoldProduction(int offerCartId)
        {
            try
            {
                bool result = await _offerCartService.SetMoldProductionAsync(offerCartId);
                _logger.LogInformation($"SetMoldProduction Success => {offerCartId}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"SetMoldProduction Error => {offerCartId}");
                return BadRequest("Error");
            }
        }

        [HttpGet("{offerCartId}")]
        public async Task<IActionResult> ShowSampleButton(int offerCartId)
        {
            try
            {
                bool result = await _offerCartService.ShowSampleButtonAsync(offerCartId);
                _logger.LogInformation($"ShowSampleButton Success => {offerCartId}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"ShowSampleButton Error => {offerCartId}");
                return BadRequest("Error");
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOfferCart(UpdateOfferCartDTO offerCartDto)
        {
            try
            {
                OfferCart result = await _offerCartService.UpdateOfferCartAsync(offerCartDto);
                _logger.LogInformation($"UpdateOfferCart Success => OfferCartId: {offerCartDto.OfferCartId}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"UpdateOfferCart Error => OfferCartId: {offerCartDto.OfferCartId}");
                return BadRequest("Error");
            }
        }


    }
}