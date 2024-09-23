using DomainLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Repositories.Abstract
{
    public interface IOfferCartRepository:IBaseRepository<OfferCart>
    {
        //Hocanın örneğinden gelen
        Task AddToCartAsync(OfferCart cart);
        Task RemoveAllProductsForUserAsync(int userId);


        //Bizim yaptıklarımız
        Task<OfferCart> AddOfferCartAsync(OfferCart offerCart);
        Task<OfferCart> UpdateOfferCartAsync(OfferCart offerCart);
        Task DeleteOfferCartAsync(int offerCartId);
        Task<OfferCart> GetOfferCartByIdAsync(int offerCartId);
        Task<bool> ApproveOfferByAdminAsync(int offerCartId);
        Task<bool> ShowSampleButtonAsync(int offerCartId);
        Task<bool> ApproveSamplePreparationAsync(int offerCartId);
        Task<bool> SetMoldProductionAsync(int offerCartId);
        Task<bool> SetFinalizationAsync(int offerCartId);
        Task<IEnumerable<OfferCart>> GetAllOfferCartsAsync();
    }
}
