using ApplicationLayer.Models.DTOs.OfferCartDTOs;
using AutoMapper;
using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.OfferCartService
{
    public class OfferCartService : IOfferCartService
    {
        private readonly IOfferCartRepository _offerCartRepository;
        private readonly IMapper _mapper;

        public OfferCartService(IOfferCartRepository offerCartRepository, IMapper mapper)
        {
            _offerCartRepository = offerCartRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// OfferCart ekleme işlemi yapar
        /// </summary>
        /// <param name="offerCart"></param>
        /// <returns></returns>
        public async Task<OfferCart> AddOfferCartAsync(AddOfferCartDTO offerCart)
        {
            OfferCart newOfferCart = new OfferCart();
            newOfferCart.IsActive = true;
            _mapper.Map(offerCart, newOfferCart);
            return await _offerCartRepository.AddOfferCartAsync(newOfferCart);
        }

        /// <summary>
        /// OfferCart ekleme işlemi yapar
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        public async Task AddToCartAsync(AddOfferCartDTO cart)
        {
            OfferCart newOfferCart = new OfferCart();
            _mapper.Map(cart, newOfferCart);
            await _offerCartRepository.AddOfferCartAsync(newOfferCart);
        }

        /// <summary>
        /// Approved olan OfferCartları döner AppUserId parametre ver
        /// </summary>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> ApprovedOfferCartsByUserIdAsync(int appUserId)
        {
            return await _offerCartRepository.ApprovedOfferCartsByUserIdAsync(appUserId);
        }

        /// <summary>
        /// Admin tarafından onay verme işlemi yapar
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> ApproveOfferByAdminAsync(int offerCartId)
        {
            return await _offerCartRepository.ApproveOfferByAdminAsync(offerCartId);
        }

        /// <summary>
        /// Visitor tarafından onay verme işlemi yapar
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> ApproveOfferByVisitorAsync(int offerCartId)
        {
            return await _offerCartRepository.ApproveOfferByVisitorAsync(offerCartId);
        }

        /// <summary>
        /// Sample Preparation tarafından onay verme işlemi yapar
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> ApproveSamplePreparationAsync(int offerCartId)
        {
            return await _offerCartRepository.ApproveSamplePreparationAsync(offerCartId);
        }

        /// <summary>
        /// OfferCartId parametresine göre ilgili OfferCart'ı siler
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteOfferCartAsync(int offerCartId)
        {
            OfferCart offerCart = await _offerCartRepository.FindAsync(offerCartId);
            if (offerCart != null)
            {
                await _offerCartRepository.DeleteOfferCartAsync(offerCart.OfferCartId);
                return true;
            }
            return false;
        }


        /// <summary>
        /// Finalization olan OfferCartları döndürür AppUserId parametresi ver
        /// </summary>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> FinalizationOfferCartsByUserIdAsync(int appUserId)
        {
            return await _offerCartRepository.FinalizationOfferCartsByUserIdAsync(appUserId);
        }

        /// <summary>
        /// AppUserId' ye ait tüm OfferCartları döndürür
        /// </summary>
        /// <param name="appuserId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> GetAllByUserIdAsync(int appuserId)
        {
            return await _offerCartRepository.GetAllInclude().Where(x => x.AppUserId == appuserId).ToListAsync();
        }


        /// <summary>
        /// Tüm OfferCartları döndürür
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> GetAllOfferCartsAsync()
        {
            return await _offerCartRepository.GetAllOfferCartsAsync();
        }


        /// <summary>
        /// Admin tarafından onay bekleyen OfferCartları döndürür
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> GetAllOfferCartsForAdminAsync()
        {
            return await _offerCartRepository.GetAllOfferCartsForAdminAsync();
        }

        /// <summary>
        /// CustomerService tarafından onay bekleyen OfferCartları döndürür
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> GetAllOfferCartsForCustomerServiceAsync()
        {
            return await _offerCartRepository.GetAllOfferCartsForCustomerServiceAsync();
        }

        /// <summary>
        /// Visitor tarafından onay bekleyen OfferCartları döndürür
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> GetAllOfferCartsForVisitorAsync()
        {
            return await _offerCartRepository.GetAllOfferCartsForVisitorAsync();
        }
        /// <summary>
        /// Approved olan tüm OfferCartları döndür
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> GetAllOfferCartsIsApprovedAsync()
        {
            return await _offerCartRepository.GetAllOfferCartsIsApprovedAsync();
        }

        /// <summary>
        /// Aldığı ID parametresine göre OfferCart döndürür
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<OfferCart> GetOfferCartByIdAsync(int offerCartId)
        {
            OfferCart offerCart = await _offerCartRepository.GetOfferCartByIdAsync(offerCartId);
            if (offerCart != null)
            {
                return offerCart;
            }
            else
            {
                throw new Exception("OfferCart Not Found");
            }
        }

        /// <summary>
        /// Search işlemi için kullan
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="appuserId"></param>
        /// <returns></returns>
        public async Task<List<OfferCart>> GetOfferCartByKeywordAndUserIdAsync(string keyword, int appuserId)
        {
            return await _offerCartRepository.GetAllInclude().Where(x => x.AppUserId == appuserId && x.Product.ProductName.ToLower().Contains(keyword.ToLower())).ToListAsync();
        }

        /// <summary>
        /// Mold olan OfferCartları döner AppUserId parametre ver
        /// </summary>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<OfferCart>> MoldOfferCartsByUserIdAsync(int appUserId)
        {
            return await _offerCartRepository.MoldOfferCartsByUserIdAsync(appUserId);
        }

        /// <summary>
        /// Parametredeki OfferCartId' ye ait OfferCart iadesini onaylar (Admin)
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> OfferCardRefundRequestAcceptAsync(int offerCartId)
        {
            return await _offerCartRepository.OfferCardRefundRequestAcceptAsync(offerCartId);
        }

        /// <summary>
        /// Parametredeki OfferCartId' ye ait OfferCart iadesi başlatır
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> OfferCardRefundRequestAsync(int offerCartId)
        {
            return await _offerCartRepository.OfferCardRefundRequestAsync(offerCartId);
        }


        /// <summary>
        /// İade edilmek istenen OfferCartları döner (Admin onaylaması için / Admin kullansın)
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<OfferCart>> RefundRequestOfferCardsAsync()
        {
            return await _offerCartRepository.RefundRequestOfferCardsAsync();
        }


        /// <summary>
        /// UserId ye OfferCart içerisindeki tüm Productları sil 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<bool> RemoveAllProductsForUserAsync(int userId)
        {
            var user = await _offerCartRepository.FindAsync(userId);
            if (user != null)
            {
                await _offerCartRepository.RemoveAllProductsForUserAsync(userId);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sampled olan OfferCartları döner AppUserId parametre ver
        /// </summary>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<OfferCart>> SampleOfferCartsByUserIdAsync(int appUserId)
        {
            return await _offerCartRepository.SampleOfferCartsByUserIdAsync(appUserId);
        }

        /// <summary>
        /// Finalization işlemi TRUE
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> SetFinalizationAsync(int offerCartId)
        {
            return await _offerCartRepository.SetFinalizationAsync(offerCartId);
        }


        /// <summary>
        /// Mold işlemi TRUE
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> SetMoldProductionAsync(int offerCartId)
        {
            return await _offerCartRepository.SetMoldProductionAsync(offerCartId);
        }

        /// <summary>
        /// Numune butonu gösterilsin
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> ShowSampleButtonAsync(int offerCartId)
        {
            return await _offerCartRepository.ShowSampleButtonAsync(offerCartId);
        }


        /// <summary>
        /// Update İşlemi Yapar
        /// </summary>
        /// <param name="offerCart"></param>
        /// <returns></returns>
        public async Task<OfferCart> UpdateOfferCartAsync(UpdateOfferCartDTO offerCart)
        {
            OfferCart oldOfferCart = await _offerCartRepository.FindAsync(offerCart.OfferCartId);
            _mapper.Map(offerCart, oldOfferCart);
            return await _offerCartRepository.UpdateOfferCartAsync(oldOfferCart);
        }
    }
}
