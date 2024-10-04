using DomainLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Repositories.Abstract
{
    public interface IOfferCartRepository : IBaseRepository<OfferCart>
    {
        //Hocanın örneğinden baktıklarımız
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
        Task<bool> ApproveOfferByVisitorAsync(int offerCartId);
        Task<IEnumerable<OfferCart>> GetAllOfferCartsForAdminAsync();
        Task<IEnumerable<OfferCart>> GetAllOfferCartsForCustomerServiceAsync();
        Task<IEnumerable<OfferCart>> GetAllOfferCartsForVisitorAsync();
        Task<IEnumerable<OfferCart>> GetAllOfferCartsIsApprovedAsync();

        // DURUMLARINA GÖRE OFFERCART LİSTESİ DÖNERLER
        Task<IEnumerable<OfferCart>> FinalizationOfferCartsByUserIdAsync(int appUserId);
        Task<IEnumerable<OfferCart>> ApprovedOfferCartsByUserIdAsync(int appUserId);
        Task<IEnumerable<OfferCart>> SampleOfferCartsByUserIdAsync(int appUserId);
        Task<IEnumerable<OfferCart>> MoldOfferCartsByUserIdAsync(int appUserId);

        // İADE İŞLEMLERİ
        Task<bool> OfferCardRefundRequestAsync(int offerCartId);
        Task<bool> OfferCardRefundRequestDeclineVSAsync(int offerCartId);
        Task<bool> OfferCardRefundRequestAcceptAsync(int offerCartId);
        Task<bool> OfferCardRefundRequestAcceptCSAsync(int offerCartId);
        Task<bool> OfferCardRefundRequestDeclineCSAsync(int offerCartId);
        Task<bool> OfferCardRefundRequestDeclineAsync(int offerCartId);
        Task<IEnumerable<OfferCart>> RefundRequestOfferCardsByAdminAsync();
        Task<IEnumerable<OfferCart>> RefundRequestOfferCardsByCustomerServiceAsync();
        Task<IEnumerable<OfferCart>> RefundRequestAllAcceptAsync();
        Task<IEnumerable<OfferCart>> AllWaitingRefundRequestByUserId(int userId);
        Task<IEnumerable<OfferCart>> AllCompletedRefundRequestByUserId(int userId);

    }
}
