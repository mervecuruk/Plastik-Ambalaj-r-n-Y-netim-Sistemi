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
        private readonly ILogger<OfferCart> _logger;

        public OfferCartController(IOfferCartService offerCartService, ILogger<OfferCart> logger)
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
                _logger.LogError(ex, $"Admin Approved Error => {offerCartId}");
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
                List<OfferCart> result = await _offerCartService.GetOfferCartByKeywordAndUserIdAsync(searchKeyword, appUserId);
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

        [HttpGet]
        public async Task<IActionResult> GetAllOfferCarts()
        {
            try
            {
                IEnumerable<OfferCart> result = await _offerCartService.GetAllOfferCartsAsync();
                _logger.LogInformation($"GetAllOfferCarts Result Success IEnumerable<OfferCart>");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetAllOfferCarts Result Error");
                return BadRequest("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOfferCartsForAdmin()
        {
            try
            {
                IEnumerable<OfferCart> result = await _offerCartService.GetAllOfferCartsForAdminAsync();
                _logger.LogInformation($"GetAllOfferCartsForAdmin Result Success IEnumerable<OfferCart>");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetAllOfferCartsForAdmin Result Error");
                return BadRequest("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOfferCartsForCustomerService()
        {
            try
            {
                IEnumerable<OfferCart> result = await _offerCartService.GetAllOfferCartsForCustomerServiceAsync();
                _logger.LogInformation($"GetAllOfferCartsForCustomerService Result Success IEnumerable<OfferCart>");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetAllOfferCartsForCustomerService Result Error");
                return BadRequest("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOfferCartsForVisitor()
        {
            try
            {
                IEnumerable<OfferCart> result = await _offerCartService.GetAllOfferCartsForVisitorAsync();
                _logger.LogInformation($"GetAllOfferCartsForVisitor Result Success IEnumerable<OfferCart>");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetAllOfferCartsForVisitor Result Error");
                return BadRequest("Error");
            }
        }




        [HttpGet]
        public async Task<IActionResult> GetAllOfferCartsIsApproved()
        {
            try
            {
                IEnumerable<OfferCart> result = await _offerCartService.GetAllOfferCartsIsApprovedAsync();
                _logger.LogInformation($"GetAllOfferCartsIsApproved Result Success IEnumerable<OfferCart>");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetAllOfferCartsIsApproved Result Error");
                return BadRequest("Error");
            }
        }


        [HttpPut("{offerCartId}")]
        public async Task<IActionResult> OfferCartRefundRequest(int offerCartId)
        {
            try
            {
                bool result = await _offerCartService.OfferCardRefundRequestAsync(offerCartId);
                _logger.LogInformation($"OfferCardRefundRequest Success => OfferCartId {offerCartId}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"OfferCartRefundRequest Error => OfferCartId {offerCartId}");
                return BadRequest("Error");
            }
        }

        [HttpPut("{offerCartId}")]
        public async Task<IActionResult> OfferCartRefundRequestAccept(int offerCartId)
        {
            try
            {
                bool result = await _offerCartService.OfferCardRefundRequestAcceptAsync(offerCartId);
                _logger.LogInformation($"OfferCardRefundRequestAccept Success => OfferCartId {offerCartId}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"OfferCartRefundRequestAccept Error => OfferCartId {offerCartId}");
                return BadRequest("Error");
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetRefundRequestOfferCards()
        {
            try
            {
                IEnumerable<OfferCart> result = await _offerCartService.RefundRequestOfferCardsAsync();
                _logger.LogInformation($"GetRefundRequestOfferCards Success");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetRefundRequestOfferCards Error");
                return BadRequest("Error");
            }
        }

        [HttpGet("{offerCartId}")]
        public async Task<IActionResult> GetOfferCartById(int offerCartId)
        {
            try
            {
                OfferCart result = await _offerCartService.GetOfferCartByIdAsync(offerCartId);
                _logger.LogInformation($"GetOfferCartById Success => OfferCartId: {offerCartId}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetOfferCartById Error => OfferCartId: {offerCartId}");
                return BadRequest("Error");
            }
        }

        [HttpPost("{offerCartId}")]
        public async Task<IActionResult> ApproveOfferByVisitor(int offerCartId)
        {
            try
            {
                bool result = await _offerCartService.ApproveOfferByVisitorAsync(offerCartId);
                _logger.LogInformation($"ApproveOfferByVisitor Success => OfferCartId: {offerCartId}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"ApproveOfferByVisitor Error => OfferCartId: {offerCartId}");
                return BadRequest("Error");
            }
        }

        [HttpGet("{appUserId}")]
        public async Task<IActionResult> FinalizationOfferCartsByUserId(int appUserId)
        {
            try
            {
                IEnumerable<OfferCart> result = await _offerCartService.FinalizationOfferCartsByUserIdAsync(appUserId);
                _logger.LogInformation($"FinalizationOfferCartsByUserId Success => AppUserId: {appUserId}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"FinalizationOfferCartsByUserId Error => AppUserId: {appUserId}");
                return BadRequest("Error");
            }
        }


        [HttpGet("{appUserId}")]
        public async Task<IActionResult> ApprovedOfferCartsByUserId(int appUserId)
        {
            try
            {
                IEnumerable<OfferCart> result = await _offerCartService.ApprovedOfferCartsByUserIdAsync(appUserId);
                _logger.LogInformation($"ApprovedOfferCartsByUserId Success => AppUserId: {appUserId}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"ApprovedOfferCartsByUserId Error => AppUserId: {appUserId}");
                return BadRequest("Error");
            }
        }


        [HttpGet("{appUserId}")]
        public async Task<IActionResult> SampleOfferCartsByUserId(int appUserId)
        {
            try
            {
                IEnumerable<OfferCart> result = await _offerCartService.SampleOfferCartsByUserIdAsync(appUserId);
                _logger.LogInformation($"SampleOfferCartsByUserId Success => AppUserId: {appUserId}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"SampleOfferCartsByUserId Error => AppUserId: {appUserId}");
                return BadRequest("Error");
            }
        }

        [HttpGet("{appUserId}")]
        public async Task<IActionResult> MoldOfferCartsByUserId(int appUserId)
        {
            try
            {
                IEnumerable<OfferCart> result = await _offerCartService.MoldOfferCartsByUserIdAsync(appUserId);
                _logger.LogInformation($"MoldOfferCartsByUserId Success => AppUserId: {appUserId}");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"MoldOfferCartsByUserId Error => AppUserId: {appUserId}");
                return BadRequest("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddToOfferCart(AddOfferCartDTO cart)
        {
            try
            {
                await _offerCartService.AddToCartAsync(cart);
                _logger.LogInformation($"AddToOfferCart Success");
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"AddToOfferCart Error");
                return BadRequest("Error");
            }
        }


    }
}