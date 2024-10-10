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
        /// Parametredeki User ID'ye ait olan tüm Onaylanmış RefundRequestleri döndürür
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<OfferCart>> AllCompletedRefundRequestByUserId(int userId)
        {
            return await _offerCartRepository.AllCompletedRefundRequestByUserId(userId);
        }

        /// <summary>
        /// Parametredki User ID'ye ait olan tüm Onay bekleyen RefundRequestleri döndürür
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<OfferCart>> AllWaitingRefundRequestByUserId(int userId)
        {
            return await _offerCartRepository.AllWaitingRefundRequestByUserId(userId);
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
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> OfferCardRefundRequestAcceptAsync(int offerCartId)
        {
            return await _offerCartRepository.OfferCardRefundRequestAcceptAsync(offerCartId);
        }

        /// <summary>
        /// İade işlemini CUSTOMER SERVICE'in onaylama işlemini yapar
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> OfferCardRefundRequestAcceptCSAsync(int offerCartId)
        {
            return await _offerCartRepository.OfferCardRefundRequestAcceptCSAsync(offerCartId);
        }

        /// <summary>
        /// Parametredeki OfferCartId' ye ait OfferCart iadesi başlatır VISITOR
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> OfferCardRefundRequestAsync(int offerCartId)
        {
            return await _offerCartRepository.OfferCardRefundRequestAsync(offerCartId);
        }

        /// <summary>
        /// Parametredeki OfferCartId' ye ait OfferCart iadesini iptal eder (Admin)
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> OfferCardRefundRequestDeclineAsync(int offerCartId)
        {
            return await _offerCartRepository.OfferCardRefundRequestDeclineAsync(offerCartId);
        }

        /// <summary>
        /// İade işlemini Customer Service'in iptal etme işlemini yapar
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> OfferCardRefundRequestDeclineCSAsync(int offerCartId)
        {
            return await _offerCartRepository.OfferCardRefundRequestDeclineCSAsync(offerCartId);
        }

        /// <summary>
        /// İade işlemini VISITOR için iptal etme işlemini yapar
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> OfferCardRefundRequestDeclineVSAsync(int offerCartId)
        {
            return await _offerCartRepository.OfferCardRefundRequestDeclineVSAsync(offerCartId);
        }

        /// <summary>
        /// İade işlemleri tamamlananların listesini döner
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<OfferCart>> RefundRequestAllAcceptAsync()
        {
            return await _offerCartRepository.RefundRequestAllAcceptAsync();
        }

        /// <summary>
        /// İade edilmek istenen OfferCartları döner (Admin için CustomerService onayladıklarını dönmeli)
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<OfferCart>> RefundRequestOfferCardsByAdminAsync()
        {
            return await _offerCartRepository.RefundRequestOfferCardsByAdminAsync();
        }

        /// <summary>
        /// İade edilmek istenen OfferCartları döner (Customer Service Önüne gelecek liste)
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<OfferCart>> RefundRequestOfferCardsByCustomerServiceAsync()
        {
            return await _offerCartRepository.RefundRequestOfferCardsByCustomerServiceAsync();
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


        // YENİ EKLENENLER
        // YENİ EKLENENLER
        // YENİ EKLENENLER


        /// <summary>
        /// Customer Service'in onayladığı tüm OfferCartları Döner
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> CustomerServiceApprovedOfferCartsAsync()
        {
            IEnumerable<OfferCart> result = await _offerCartRepository.CustomerServiceApprovedOfferCartsAsync();
            return result;
        }

        /// <summary>
        /// Customer Service'in onayladığı tüm OfferCartları Döner
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> CustomerServiceWaitingOfferCartsAsync()
        {
            IEnumerable<OfferCart> result = await _offerCartRepository.CustomerServiceWaitingOfferCartsAsync();
            return result;
        }


        /// <summary>
        /// CustomerService Onaylama işlemi yapar
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> CustomerServiceAcceptOfferCartAsync(int offerCartId)
        {
            return await _offerCartRepository.CustomerServiceAcceptOfferCartAsync(offerCartId);
        }

        /// <summary>
        /// CustomerService reddetme işlemi yapar
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> CustomerServiceDeclineOfferCartAsync(int offerCartId)
        {
            return await _offerCartRepository.CustomerServiceDeclineOfferCartAsync(offerCartId);
        }

        /// <summary>
        /// Admin için onaylama işlemi yapar
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> AdminAcceptOfferCartAsync(int offerCartId)
        {
            return await _offerCartRepository.AdminAcceptOfferCartAsync(offerCartId);
        }

        /// <summary>
        /// Admin için reddetme işlemi yapar
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> AdminDeclineOfferCartAsync(int offerCartId)
        {
            return await _offerCartRepository.AdminDeclineOfferCartAsync(offerCartId);
        }

        /// <summary>
        /// Admin için Onaylanmış tüm OfferCartları döndürür
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> AdminApprovedOfferCartsAsync()
        {
            return await _offerCartRepository.AdminApprovedOfferCartsAsync();
        }

        /// <summary>
        /// Admin için onay bekleyen tüm OfferCartları Döndürür
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> AdminWaitingOfferCartsAsync()
        {
            return await _offerCartRepository.AdminWaitingOfferCartsAsync();
        }

        /// <summary>
        /// Fiyatı güncellenmek istenen OfferCart'ı döner
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<OfferCartPriceDTO> GetUpdateOfferCartPriceAsync(int offerCartId)
        {
            OfferCart result = await _offerCartRepository.GetUpdateOfferCartPriceAsync(offerCartId);
            if (result == null) return null;
            else
            {
                OfferCartPriceDTO offerCartPriceDTO = new OfferCartPriceDTO()
                {
                    OfferCartId = result.OfferCartId,
                    TotalPrice = result.TotalPrice
                };
                return offerCartPriceDTO;
            }
        }


        /// <summary>
        /// OfferCart'ın TotalPrice Güncelleme işlemini yapar
        /// </summary>
        /// <param name="offerCartPriceDTO"></param>
        /// <returns></returns>
        public async Task<bool> UpdateOfferCartPriceAsync(OfferCartPriceDTO offerCartPriceDTO)
        {
            OfferCart result = await _offerCartRepository.GetUpdateOfferCartPriceAsync(offerCartPriceDTO.OfferCartId);
            if (result == null) return false;
            else
            {
                result.TotalPrice = offerCartPriceDTO.TotalPrice;
                return await _offerCartRepository.UpdateOfferCartPriceAsync(result);
            }
        }

        /// <summary>
        /// Kullanıcı ID'ye ait olan tüm Offer Cartları döndürür
        /// </summary>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> GetOfferCartsByUserIdAsync(int appUserId)
        {
            IEnumerable<OfferCart> result = await _offerCartRepository.GetOfferCartsByUserIdAsync(appUserId);
            if (result == null) return null;
            else return result;
        }
    }
}
