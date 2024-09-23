using ApplicationLayer.Models.DTOs.OfferCartDTOs;
using DomainLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.OfferCartService
{
    public interface IOfferCartService
    {
        //Hocanın örneğinden gelen
        Task AddToCartAsync(AddOfferCartDTO cart);
        Task<bool> RemoveAllProductsForUserAsync(int userId);


        //Bizim yaptıklarımız
        Task<OfferCart> AddOfferCartAsync(AddOfferCartDTO offerCart);
        Task<OfferCart> UpdateOfferCartAsync(UpdateOfferCartDTO offerCart);
        Task<bool> DeleteOfferCartAsync(int offerCartId);
        Task<OfferCart> GetOfferCartByIdAsync(int offerCartId);
        Task<bool> ApproveOfferByAdminAsync(int offerCartId);
        Task<bool> ShowSampleButtonAsync(int offerCartId);
        Task<bool> ApproveSamplePreparationAsync(int offerCartId);
        Task<bool> SetMoldProductionAsync(int offerCartId);
        Task<bool> SetFinalizationAsync(int offerCartId);
        Task<IEnumerable<OfferCart>> GetAllOfferCartsAsync();
        Task<IEnumerable<OfferCart>> GetAllByUserIdAsync(int appuserId);
        Task<List<OfferCart>> GetOfferCartByKeywordAndUserId(string keyword, int appuserId);

    }
}
