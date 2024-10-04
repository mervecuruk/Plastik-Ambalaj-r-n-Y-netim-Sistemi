using ApplicationLayer.Models.DTOs.OfferCartDTOs;
using ApplicationLayer.Services.LogService;
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
        private readonly ILogService _logService;

        public OfferCartController(IOfferCartService offerCartService, ILogger<OfferCart> logger, ILogService logService)
        {
            _offerCartService = offerCartService;
            _logger = logger;
            _logService = logService;
        }

        [HttpPost]
        public async Task<IActionResult> AddOfferCart(AddOfferCartDTO offerCart)
        {
            try
            {
                OfferCart offer = await _offerCartService.AddOfferCartAsync(offerCart);
                _logger.LogInformation($"Offer cart is being added => {offerCart}");
                await _logService.AddLogAsync("Information", "OfferCartController", $"Offer cart is being added => {offerCart}", "-", offerCart.AppUserId);
                return Ok(offer);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while adding offer cart => {offerCart}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"An error occurred while adding offer cart => {offerCart}", ex.ToString(), offerCart.AppUserId);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"Approved By Admin Success => {offerCartId}", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Admin Approved Error => {offerCartId}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"Admin Approved Error => {offerCartId}", ex.ToString(), null);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"Approved Sample Preparation Success => {offerCartId}", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"SamplePreparation Approved Error => {offerCartId}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"SamplePreparation Approved Error => {offerCartId}", ex.ToString(), null);
                return BadRequest("Error");
            }
        }

        [HttpDelete("{offerCartId}")]
        public async Task<IActionResult> DeleteOfferCart(int offerCartId)
        {
            try
            {
                bool deleteResult = await _offerCartService.DeleteOfferCartAsync(offerCartId);
                _logger.LogInformation($"OfferCart Delete Success => {offerCartId}");
                await _logService.AddLogAsync("Information", "OfferCartController", $"OfferCart Delete Success => {offerCartId}", "-", null);
                return Ok(deleteResult);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"OfferCart Delete Error => {offerCartId}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"OfferCart Delete Error => {offerCartId}", ex.ToString(), null);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"GetAllByUserId Result Success IEnumerable<OfferCart> => UserId: {appUserId}", "-", appUserId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetAllByUserId Result Error => ID : {appUserId}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"GetAllByUserId Result Error => ID : {appUserId}", ex.ToString(), appUserId);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"GetOfferCartByKeywordAndUserId Success => Keyword: {searchKeyword} / UserId: {appUserId}", "-", appUserId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetOfferCartByKeywordAndUserId Error => Keyword: {searchKeyword} / UserId: {appUserId}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"GetOfferCartByKeywordAndUserId Error => Keyword: {searchKeyword} / UserId: {appUserId}", ex.ToString(), appUserId);
                return BadRequest("Error");
            }
        }

        [HttpDelete("{appUserId}")]
        public async Task<IActionResult> RemoveAllProductsForUserId(int appUserId)
        {
            try
            {
                bool result = await _offerCartService.RemoveAllProductsForUserAsync(appUserId);
                _logger.LogInformation($"RemoveAllProductsForUser Success => UserId: {appUserId}");
                await _logService.AddLogAsync("Information", "OfferCartController", $"RemoveAllProductsForUser Success => UserId: {appUserId}", "-", appUserId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"RemoveAllProductsForUser Error => UserId: {appUserId}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"RemoveAllProductsForUser Error => UserId: {appUserId}", ex.ToString(), appUserId);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"SetFinalization Success => {offerCartId}", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"SetFinalization Error => {offerCartId}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"SetFinalization Error => {offerCartId}", ex.ToString(), null);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"SetMoldProduction Success => {offerCartId}", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"SetMoldProduction Error => {offerCartId}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"SetMoldProduction Error => {offerCartId}", ex.ToString(), null);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"ShowSampleButton Success => {offerCartId}", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"ShowSampleButton Error => {offerCartId}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"ShowSampleButton Error => {offerCartId}", ex.ToString(), null);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"UpdateOfferCart Success => OfferCartId: {offerCartDto.OfferCartId}", "-", offerCartDto.AppUser.Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"UpdateOfferCart Error => OfferCartId: {offerCartDto.OfferCartId}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"UpdateOfferCart Error => OfferCartId: {offerCartDto.OfferCartId}", ex.ToString(), offerCartDto.AppUser.Id);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"GetAllOfferCarts Result Success IEnumerable<OfferCart>", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetAllOfferCarts Result Error");
                await _logService.AddLogAsync("Error", "OfferCartController", $"GetAllOfferCarts Result Error", ex.ToString(), null);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"GetAllOfferCartsForAdmin Result Success IEnumerable<OfferCart>", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetAllOfferCartsForAdmin Result Error");
                await _logService.AddLogAsync("Error", "OfferCartController", $"GetAllOfferCartsForAdmin Result Error", ex.ToString(), null);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"GetAllOfferCartsForCustomerService Result Success IEnumerable<OfferCart>", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetAllOfferCartsForCustomerService Result Error");
                await _logService.AddLogAsync("Error", "OfferCartController", $"GetAllOfferCartsForCustomerService Result Error", ex.ToString(), null);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"GetAllOfferCartsForVisitor Result Success IEnumerable<OfferCart>", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetAllOfferCartsForVisitor Result Error");
                await _logService.AddLogAsync("Error", "OfferCartController", $"GetAllOfferCartsForVisitor Result Error", ex.ToString(), null);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"GetAllOfferCartsIsApproved Result Success IEnumerable<OfferCart>", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetAllOfferCartsIsApproved Result Error");
                await _logService.AddLogAsync("Error", "OfferCartController", $"GetAllOfferCartsIsApproved Result Error", ex.ToString(), null);
                return BadRequest("Error");
            }
        }

        [HttpPut("{offerCartId}")]
        public async Task<IActionResult> OfferCartRefundRequestVisitor(int offerCartId)
        {
            try
            {
                bool result = await _offerCartService.OfferCardRefundRequestAsync(offerCartId);
                await _logService.AddLogAsync("Information", "OfferCartController", $"OfferCartRefundRequestVisitor Result Success => OfferCart ID: {offerCartId}", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                await _logService.AddLogAsync("Error", "OfferCartController", $"OfferCardRefundRequestVisitor Result Error => OfferCart ID: {offerCartId}", ex.ToString(), null);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{offerCartId}")]
        public async Task<IActionResult> OfferCartRefundRequestDeclineVisitor(int offerCartId)
        {
            try
            {
                bool result = await _offerCartService.OfferCardRefundRequestDeclineVSAsync(offerCartId);
                await _logService.AddLogAsync("Information", "OfferCartController", $"OfferCartRefundRequestDeclineVisitor Result Success => OfferCart ID: {offerCartId}", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                await _logService.AddLogAsync("Error", "OfferCartController", $"OfferCartRefundRequestDeclineVisitor Result Error => OfferCart ID: {offerCartId}", ex.ToString(), null);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{offerCartId}")]
        public async Task<IActionResult> OfferCartRefundRequestAcceptAdmin(int offerCartId)
        {
            try
            {
                bool result = await _offerCartService.OfferCardRefundRequestAcceptAsync(offerCartId);
                await _logService.AddLogAsync("Information", "OfferCartController", $"OfferCartRefundRequestAcceptAdmin Result Success => OfferCart ID: {offerCartId}", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                await _logService.AddLogAsync("Error", "OfferCartController", $"OfferCartRefundRequestAcceptAdmin Result Error => OfferCart ID: {offerCartId}", ex.ToString(), null);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{offerCartId}")]
        public async Task<IActionResult> OfferCartRefundRequestDeclineAdmin(int offerCartId)
        {
            try
            {
                bool result = await _offerCartService.OfferCardRefundRequestDeclineAsync(offerCartId);
                await _logService.AddLogAsync("Information", "OfferCartController", $"OfferCartRefundRequestDeclineAdmin Result Success => OfferCart ID: {offerCartId}", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                await _logService.AddLogAsync("Error", "OfferCartController", $"OfferCartRefundRequestDeclineAdmin Result Error => OfferCart ID: {offerCartId}", ex.ToString(), null);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{offerCartId}")]
        public async Task<IActionResult> OfferCartRefundRequestAcceptCustomerService(int offerCartId)
        {
            try
            {
                bool result = await _offerCartService.OfferCardRefundRequestAcceptCSAsync(offerCartId);
                await _logService.AddLogAsync("Information", "OfferCartController", $"OfferCartRefundRequestAcceptCustomerService Result Success => OfferCart ID: {offerCartId}", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                await _logService.AddLogAsync("Error", "OfferCartController", $"OfferCartRefundRequestAcceptCustomerService Result Error => OfferCart ID: {offerCartId}", ex.ToString(), null);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{offerCartId}")]
        public async Task<IActionResult> OfferCartRefundRequestDeclineCustomerService(int offerCartId)
        {
            try
            {
                bool result = await _offerCartService.OfferCardRefundRequestAcceptCSAsync(offerCartId);
                await _logService.AddLogAsync("Information", "OfferCartController", $"OfferCartRefundRequestDeclineCustomerService Result Success => OfferCart ID: {offerCartId}", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                await _logService.AddLogAsync("Error", "OfferCartController", $"OfferCartRefundRequestDeclineCustomerService Result Error => OfferCart ID: {offerCartId}", ex.ToString(), null);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> AllRefundRequestOfferCardsByAdmin()
        {
            try
            {
                IEnumerable<OfferCart> result = await _offerCartService.RefundRequestOfferCardsByAdminAsync();
                await _logService.AddLogAsync("Information", "OfferCartController", $"AllRefundRequestOfferCardsByAdmin Result Success", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                await _logService.AddLogAsync("Error", "OfferCartController", $"AllRefundRequestOfferCardsByAdmin Result Error", ex.ToString(), null);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> AllRefundRequestOfferCardsByCustomerService()
        {
            try
            {
                IEnumerable<OfferCart> result = await _offerCartService.RefundRequestOfferCardsByCustomerServiceAsync();
                await _logService.AddLogAsync("Information", "OfferCartController", $"AllRefundRequestOfferCardsByCustomerService Result Success", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                await _logService.AddLogAsync("Error", "OfferCartController", $"AllRefundRequestOfferCardsByCustomerService Result Error", ex.ToString(), null);
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> AllCompletedRefundRequest()
        {
            try
            {
                IEnumerable<OfferCart> result = await _offerCartService.RefundRequestAllAcceptAsync();
                await _logService.AddLogAsync("Information", "OfferCartController", $"AllCompletedRefundRequest Result Success", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                await _logService.AddLogAsync("Error", "OfferCartController", $"AllCompletedRefundRequest Result Error", ex.ToString(), null);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> AllCompletedRefundRequestByUserID(int userId)
        {
            try
            {
                IEnumerable<OfferCart> result = await _offerCartService.AllCompletedRefundRequestByUserId(userId);
                await _logService.AddLogAsync("Information", "OfferCartController", $"AllCompletedRefundRequestByUserID Result Success => User ID: {userId}", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                await _logService.AddLogAsync("Error", "OfferCartController", $"AllCompletedRefundRequestByUserID Result Error => User ID: {userId}", ex.ToString(), null);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> AllWaitingRefundRequestByUserID(int userId)
        {
            try
            {
                IEnumerable<OfferCart> result = await _offerCartService.AllWaitingRefundRequestByUserId(userId);
                await _logService.AddLogAsync("Information", "OfferCartController", $"AllWaitingRefundRequestByUserID Result Success => User ID: {userId}", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                await _logService.AddLogAsync("Error", "OfferCartController", $"AllWaitingRefundRequestByUserID Result Error => User ID: {userId}", ex.ToString(), null);
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("{offerCartId}")]
        public async Task<IActionResult> GetOfferCartById(int offerCartId)
        {
            try
            {
                OfferCart result = await _offerCartService.GetOfferCartByIdAsync(offerCartId);
                _logger.LogInformation($"GetOfferCartById Success => OfferCartId: {offerCartId}");
                await _logService.AddLogAsync("Information", "OfferCartController", $"GetOfferCartById Success => OfferCartId: {offerCartId}", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetOfferCartById Error => OfferCartId: {offerCartId}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"GetOfferCartById Error => OfferCartId: {offerCartId}", ex.ToString(), null);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"ApproveOfferByVisitor Success => OfferCartId: {offerCartId}", "-", null);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"ApproveOfferByVisitor Error => OfferCartId: {offerCartId}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"ApproveOfferByVisitor Error => OfferCartId: {offerCartId}", ex.ToString(), null);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"FinalizationOfferCartsByUserId Success => AppUserId: {appUserId}", "-", appUserId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"FinalizationOfferCartsByUserId Error => AppUserId: {appUserId}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"FinalizationOfferCartsByUserId Error => AppUserId: {appUserId}", ex.ToString(), appUserId);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"ApprovedOfferCartsByUserId Success => AppUserId: {appUserId}", "-", appUserId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"ApprovedOfferCartsByUserId Error => AppUserId: {appUserId}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"ApprovedOfferCartsByUserId Error => AppUserId: {appUserId}", ex.ToString(), appUserId);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"SampleOfferCartsByUserId Success => AppUserId: {appUserId}", "-", appUserId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"SampleOfferCartsByUserId Error => AppUserId: {appUserId}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"SampleOfferCartsByUserId Error => AppUserId: {appUserId}", ex.ToString(), appUserId);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"MoldOfferCartsByUserId Success => AppUserId: {appUserId}", "-", appUserId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"MoldOfferCartsByUserId Error => AppUserId: {appUserId}");
                await _logService.AddLogAsync("Error", "OfferCartController", $"MoldOfferCartsByUserId Error => AppUserId: {appUserId}", ex.ToString(), appUserId);
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
                await _logService.AddLogAsync("Information", "OfferCartController", $"AddToOfferCart Success", "-", cart.AppUserId);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"AddToOfferCart Error");
                await _logService.AddLogAsync("Error", "OfferCartController", $"AddToOfferCart Error", ex.ToString(), cart.AppUserId);
                return BadRequest("Error");
            }
        }
    }
}