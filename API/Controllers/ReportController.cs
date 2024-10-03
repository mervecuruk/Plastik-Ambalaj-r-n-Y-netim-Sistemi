using ApplicationLayer.Services.OfferCartService;
using ApplicationLayer.Services.ProductService;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IOfferCartService _offerCartService;
        private readonly IMapper _mapper;

        public ReportController(IOfferCartService offerCartService, IMapper mapper)
        {
            _offerCartService = offerCartService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetOfferCartSummaryReport(DateTime startDate, DateTime endDate)
        {
            var result = await _offerCartService.GetAllOfferCartsAsync();
            var filteredResult = result.Where(x => x.AddedDate >= startDate && x.AddedDate <= endDate);
            return Ok(filteredResult);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserActivityReport(int userId)
        {
            var result = await _offerCartService.GetAllByUserIdAsync(userId);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductOfferStatusReport()
        {
            var result = await _offerCartService.GetAllOfferCartsAsync();
            var offerStatus = result.Select(x => new
            {
                x.AppUser.FirstName,
                x.AppUser.LastName,
                x.Product.ProductId,
                x.Product.Price,
                x.Product.ProductName,
                OfferStatus = x.IsApproved ? "Approved" : "Pending",
            });
            return Ok(offerStatus);
        }

        [HttpGet]
        public async Task<IActionResult> GetApprovedOfferCartReport(DateTime startDate, DateTime endDate)
        {
            var result = await _offerCartService.GetAllOfferCartsIsApprovedAsync();
            var filteredResult = result.Where(x => x.AddedDate >= startDate && x.AddedDate <= endDate);
            return Ok(filteredResult);
        }

        [HttpGet]
        public async Task<IActionResult> GetPaymentReport()
        {
            var result = await _offerCartService.GetAllOfferCartsAsync();
            var paymentReport = result.Select(x => new
            {
                x.OfferCartId,
                x.TotalPrice,
                PaymentStatus = x.IsSample ? "Paid" : "Pending",
                x.CompletedDate
            });
            return Ok(paymentReport);
        }

        [HttpGet]
        public async Task<IActionResult> GetRejectedOffersReport()
        {
            var result = await _offerCartService.GetAllOfferCartsAsync();
            var rejectedOffers = result.Where(x => !x.IsApproved && !x.AcceptAdmin && !x.AcceptVisitor)
                                       .Select(x => new
                                       {
                                           x.OfferCartId,
                                           ProductName = x.Product != null ? x.Product.ProductName : "Product not available",
                                           x.AddedDate,
                                           RejectionReason = x.OfferCartMessages != null && x.OfferCartMessages.Any()
                                       ? string.Join(", ", x.OfferCartMessages.Select(m => m.Message))
                                       : "No reason provided"
                                       });
            return Ok(rejectedOffers);
        }


        [HttpGet]
        public async Task<IActionResult> GetMoldProductionReport()
        {
            var result = await _offerCartService.GetAllOfferCartsAsync();
            var moldProductionReport = result.Where(x => x.IsApproved).Select(x => new
            {
                x.OfferCartId,
                x.Product.ProductName,
                MoldProductionStatus = x.IsMold == true ? "Completed" : "In Progress"
            });
            return Ok(moldProductionReport);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductAccordingToLike()
        {
            var result = await _offerCartService.GetAllOfferCartsAsync();
            var filteredResult = result.Where(x => x.Product.Likes != null).OrderByDescending(x => x.Product.Likes).Select(x => new
            {
                x.Product.ProductName,
                x.Product.Likes,
            });
            return Ok(filteredResult);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductAccordingToViews()
        {
            var result = await _offerCartService.GetAllOfferCartsAsync();
            var filteredResult = result.Where(x => x.Product.Views != null).OrderByDescending(x => x.Product.Views).Select(x => new
            {
                x.Product.ProductName,
                x.Product.Views,
            });
            return Ok(filteredResult);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductTopSelling()
        {
            var result = await _offerCartService.GetAllOfferCartsAsync();
            var filteredResult = result.OrderByDescending(x => x.Amount).Select(x => new
            {
                x.Product.Views,
                x.Product.ProductName,
                x.Product.Price,
                x.Amount,
                x.TotalPrice
            });
            return Ok(filteredResult);
        }
    }
}
