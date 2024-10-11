using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using InfrastructureLayer.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Concrete
{
    public class OfferCartRepository : BaseRepository<OfferCart>, IOfferCartRepository
    {
        private readonly AppDbContext _context;

        public OfferCartRepository(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Teklif sepet ekle.
        /// </summary>
        /// <param name="offerCart"></param>
        /// <returns></returns>
        public async Task<OfferCart> AddOfferCartAsync(OfferCart offerCart)
        {
            offerCart.IsActive = true;
            _context.OfferCarts.Add(offerCart);
            await _context.SaveChangesAsync();
            return offerCart;
        }

        /// <summary>
        /// Hocanın yaptığı teklif sepete ekle.
        /// </summary>
        /// <param name="cart"></param>
        /// <returns></returns>
        public async Task AddToCartAsync(OfferCart cart)
        {
            var result = _context.OfferCarts.Where(x => x.AppUserId == cart.AppUserId && x.ProductId == cart.ProductId && x.IsActive == true).SingleOrDefault();
            if (result == null)
            {
                _context.OfferCarts.Add(cart);
            }
            else
            {
                ///burada debug ekleyerek kontrolünü sağla!!!!
                result.Amount += cart.Amount;
                _context.OfferCarts.Update(result);
            }
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Teklif onayı ver.(Admin)
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> ApproveOfferByAdminAsync(int offerCartId)
        {
            var offerCart = await _context.OfferCarts.FindAsync(offerCartId);
            if (offerCart != null && !offerCart.IsApproved)
            {
                offerCart.AcceptAdmin = true;
                //offerCart.IsApproved = true;
                _context.OfferCarts.Update(offerCart);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Teklif onayı ver.(Visitor)
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> ApproveOfferByVisitorAsync(int offerCartId)
        {
            var offerCart = await _context.OfferCarts.FindAsync(offerCartId);
            if (offerCart != null && !offerCart.IsApproved && offerCart.AcceptAdmin && offerCart.AcceptCustomerService)
            {
                offerCart.AcceptVisitor = true;
                offerCart.IsApproved = true;
                _context.OfferCarts.Update(offerCart);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Numune Hazırlanması Onayı
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> ApproveSamplePreparationAsync(int offerCartId)
        {
            var offerCart = await _context.OfferCarts.FindAsync(offerCartId);
            if (offerCart != null && offerCart.IsApproved && !offerCart.IsSample)
            {
                offerCart.IsSample = true;
                offerCart.AcceptContentManager = true;
                _context.OfferCarts.Update(offerCart);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Teklif pasif silme isactive=false
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task DeleteOfferCartAsync(int offerCartId)
        {
            var offerCart = await _context.OfferCarts.FindAsync(offerCartId);
            if (offerCart != null)
            {
                offerCart.DeleteDate = DateTime.Now;
                offerCart.IsActive = false;
                _context.OfferCarts.Update(offerCart);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Tüm teklifleri getir.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> GetAllOfferCartsAsync()
        {
            return await _context.OfferCarts
                .Where(oc => oc.IsActive)
                .Include(oc => oc.AppUser)
                .Include(oc => oc.Product)
                .ToListAsync();
        }

        /// <summary>
        /// Tüm teklifleri admin için getir.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> GetAllOfferCartsForAdminAsync()
        {
            return await _context.OfferCarts
                .Where(oc => oc.IsActive && oc.AcceptCustomerService && oc.IsApproved == false && oc.AcceptAdmin == false)
                .Include(oc => oc.AppUser)
                .Include(oc => oc.Product)
                .ToListAsync();
        }

        /// <summary>
        /// Tüm teklifleri customer manager için getir.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> GetAllOfferCartsForCustomerServiceAsync()
        {
            return await _context.OfferCarts
                .Where(oc => oc.IsActive && oc.AcceptCustomerService == false && oc.IsApproved == false && oc.AcceptAdmin == false)
                .Include(oc => oc.AppUser)
                .Include(oc => oc.Product)
                .ToListAsync();
        }

        /// <summary>
        /// Tüm teklifleri visitor için getir.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> GetAllOfferCartsForVisitorAsync()
        {
            return await _context.OfferCarts
                .Where(oc => oc.IsActive && oc.AcceptCustomerService == true && oc.IsApproved == false && oc.AcceptAdmin == true)
                .Include(oc => oc.AppUser)
                .Include(oc => oc.Product)
                .ToListAsync();
        }

        /// <summary>
        /// Tüm üretim başlayanları getir.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> GetAllOfferCartsIsApprovedAsync()
        {
            return await _context.OfferCarts
                .Where(oc => oc.IsActive && oc.AcceptCustomerService == true && oc.IsApproved == true && oc.AcceptAdmin == true && oc.AcceptVisitor == true)
                .Include(oc => oc.AppUser)
                .Include(oc => oc.Product)
                .ToListAsync();
        }

        /// <summary>
        /// Teklif Sepeti getirme.
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<OfferCart> GetOfferCartByIdAsync(int offerCartId)
        {
            return await _context.OfferCarts
                .Include(oc => oc.AppUser)
                .Include(oc => oc.Product)
                .Include(oc => oc.OfferCartMessages)
                .FirstOrDefaultAsync(oc => oc.OfferCartId == offerCartId && oc.IsActive);
        }

        /// <summary>
        /// Tüm sepeti temizleme
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task RemoveAllProductsForUserAsync(int userId)
        {
            var results = _context.OfferCarts.Where(x => x.AppUserId == userId);
            _context.RemoveRange(results);
            return Task.CompletedTask;
        }

        /// <summary>
        /// Ürün üretimi tamamlandı mı durumu
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> SetFinalizationAsync(int offerCartId)
        {
            var offerCart = await _context.OfferCarts.FindAsync(offerCartId);
            if (offerCart != null && offerCart.IsMold && !offerCart.IsFinalization)
            {
                offerCart.IsFinalization = true;
                offerCart.CompletedDate = DateTime.Now;
                _context.OfferCarts.Update(offerCart);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Kalıp üretim durumu
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> SetMoldProductionAsync(int offerCartId)
        {
            var offerCart = await _context.OfferCarts.FindAsync(offerCartId);
            if (offerCart != null && offerCart.IsSample && !offerCart.IsMold)
            {
                offerCart.IsMold = true;
                _context.OfferCarts.Update(offerCart);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Numune hazırlansın mı butonunu göstermek için (Yönetici Onayladıysa)
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> ShowSampleButtonAsync(int offerCartId)
        {
            var offerCart = await _context.OfferCarts.FindAsync(offerCartId);
            if (offerCart != null && offerCart.IsApproved && !offerCart.IsSample)
            {
                offerCart.IsSample = true;
                _context.OfferCarts.Update(offerCart);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }


        /// <summary>
        /// Teklif Sepetini Güncelleme.
        /// </summary>
        /// <param name="offerCart"></param>
        /// <returns></returns>
        public async Task<OfferCart> UpdateOfferCartAsync(OfferCart offerCart)
        {
            offerCart.UpdateDate = DateTime.Now;
            _context.OfferCarts.Update(offerCart);
            await _context.SaveChangesAsync();
            return offerCart;
        }

        /// <summary>
        /// Finalization olan OfferCartları döner AppUserId parametre ver
        /// </summary>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> FinalizationOfferCartsByUserIdAsync(int appUserId)
        {
            return await _context.OfferCarts
               .Where(oc => oc.IsActive == true && oc.IsMold == true && oc.IsFinalization == true && oc.IsSample == true && oc.IsApproved == true && oc.AppUserId == appUserId)
               .Include(oc => oc.AppUser)
               .Include(oc => oc.Product)
               .ToListAsync();
        }

        /// <summary>
        /// Approved olan OfferCartları döner AppUserId parametre ver
        /// </summary>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<OfferCart>> ApprovedOfferCartsByUserIdAsync(int appUserId)
        {
            return await _context.OfferCarts
                .Where(oc => oc.IsActive == true && oc.IsApproved == true && oc.AppUserId == appUserId)
                .Include(oc => oc.AppUser)
                .Include(oc => oc.Product)
                .ToListAsync();
        }

        /// <summary>
        /// Sampled olan OfferCartları döner AppUserId parametre ver
        /// </summary>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> SampleOfferCartsByUserIdAsync(int appUserId)
        {
            return await _context.OfferCarts
                .Where(oc => oc.IsActive == true && oc.IsApproved == true && oc.IsSample == true && oc.AppUserId == appUserId)
                .Include(oc => oc.AppUser)
                .Include(oc => oc.Product)
                .ToListAsync();
        }

        /// <summary>
        /// Mold olan OfferCartları döner AppUserId parametre ver
        /// </summary>
        /// <param name="appUserId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> MoldOfferCartsByUserIdAsync(int appUserId)
        {
            return await _context.OfferCarts
                .Where(oc => oc.IsActive == true && oc.IsApproved == true && oc.IsSample == true && oc.IsMold == true && oc.AppUserId == appUserId)
                .Include(oc => oc.AppUser)
                .Include(oc => oc.Product)
                .ToListAsync();
        }

        /// <summary>
        /// Parametredeki OfferCartId' ye ait OfferCart iadesi başlatır VISITOR
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> OfferCardRefundRequestAsync(int offerCartId)
        {
            OfferCart resultOfferCart = await _context.OfferCarts.FindAsync(offerCartId);
            if (resultOfferCart == null) return false;
            else
            {
                resultOfferCart.IsRefundRequest = true;
                _context.OfferCarts.Update(resultOfferCart);
                return await _context.SaveChangesAsync() > 0;
            }
        }

        /// <summary>
        /// Parametredeki OfferCartId' ye ait OfferCart iadesini onaylar (Admin)
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> OfferCardRefundRequestAcceptAsync(int offerCartId)
        {
            OfferCart resultOfferCart = await _context.OfferCarts.FindAsync(offerCartId);
            if (resultOfferCart == null) return false;
            else
            {
                resultOfferCart.AcceptRefundRequest = true;
                _context.OfferCarts.Update(resultOfferCart);
                return await _context.SaveChangesAsync() > 0;
            }
        }

        /// <summary>
        /// Parametredeki OfferCartId' ye ait OfferCart iadesini iptal eder (Admin)
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> OfferCardRefundRequestDeclineAsync(int offerCartId)
        {
            OfferCart resultOfferCart = await _context.OfferCarts.FindAsync(offerCartId);
            if (resultOfferCart == null) return false;
            else
            {
                resultOfferCart.AcceptRefundRequest = false;
                _context.OfferCarts.Update(resultOfferCart);
                return await _context.SaveChangesAsync() > 0;
            }
        }

        /// <summary>
        /// İade edilmek istenen OfferCartları döner (Admin için CustomerService onayladıklarını dönmeli)
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<OfferCart>> RefundRequestOfferCardsByAdminAsync()
        {
            IEnumerable<OfferCart> result = await _context.OfferCarts.Where(x => x.IsRefundRequest == true && x.RefundCustomerService == true && x.IsActive == true).ToListAsync();
            if (result == null) return null;
            else return result;
        }

        /// <summary>
        /// İade edilmek istenen OfferCartları döner (Customer Service Önüne gelecek liste)
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> RefundRequestOfferCardsByCustomerServiceAsync()
        {
            IEnumerable<OfferCart> result = await _context.OfferCarts.Where(x => x.IsRefundRequest == true && x.RefundCustomerService == false && x.IsActive == true).ToListAsync();
            if (result == null) return null;
            else
            {
                return result;
            }
        }

        /// <summary>
        /// İade işlemini CUSTOMER SERVICE'in onaylama işlemini yapar
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> OfferCardRefundRequestAcceptCSAsync(int offerCartId)
        {
            OfferCart offerCart = await _context.OfferCarts.FindAsync(offerCartId);
            if (offerCart == null) return false;
            else
            {
                offerCart.RefundCustomerService = true;
                _context.OfferCarts.Update(offerCart);
                return await _context.SaveChangesAsync() > 0;
            }
        }

        /// <summary>
        /// İade işlemini Customer Service'in iptal etme işlemini yapar
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> OfferCardRefundRequestDeclineCSAsync(int offerCartId)
        {
            OfferCart offerCart = await _context.OfferCarts.FindAsync(offerCartId);
            if (offerCart == null) return false;
            else
            {
                offerCart.RefundCustomerService = false;
                _context.OfferCarts.Update(offerCart);
                return await _context.SaveChangesAsync() > 0;
            }
        }

        /// <summary>
        /// İade işlemini VISITOR için iptal etme işlemini yapar
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> OfferCardRefundRequestDeclineVSAsync(int offerCartId)
        {
            OfferCart offerCart = await _context.OfferCarts.FindAsync(offerCartId);
            if (offerCart == null) return false;
            else
            {
                offerCart.IsRefundRequest = false;
                _context.OfferCarts.Update(offerCart);
                return await _context.SaveChangesAsync() > 0;
            }
        }

        /// <summary>
        /// İade işlemleri tamamlananların listesini döner
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<OfferCart>> RefundRequestAllAcceptAsync()
        {
            IEnumerable<OfferCart> result = await _context.OfferCarts.Where(x => x.IsRefundRequest == true && x.RefundCustomerService == true && x.AcceptRefundRequest == true && x.IsActive == true).ToListAsync();
            if (result == null) return null;
            else return result;
        }

        /// <summary>
        /// Parametredeki User ID'ye ait olan tüm Onaylanmış RefundRequestleri döndürür
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<OfferCart>> AllCompletedRefundRequestByUserId(int userId)
        {
            IEnumerable<OfferCart> result = await _context.OfferCarts.Where(x => x.IsRefundRequest == true && x.RefundCustomerService == true && x.AcceptRefundRequest == true && x.IsActive == true).ToListAsync();
            if (result == null) return null;
            else return result;
        }

        /// <summary>
        /// Parametredki User ID'ye ait olan tüm Onay bekleyen RefundRequestleri döndürür
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<OfferCart>> AllWaitingRefundRequestByUserId(int userId)
        {
            IEnumerable<OfferCart> result = await _context.OfferCarts.Where(x => x.IsRefundRequest == true && x.RefundCustomerService == false && x.AcceptRefundRequest == false && x.IsActive == true).ToListAsync();
            if (result == null) return null;
            else return result;
        }

        //YENİ EKLENEN
        //YENİ EKLENEN
        //YENİ EKLENEN


        /// <summary>
        /// Customer Service'in onayladığı tüm OfferCartlar Döner
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> CustomerServiceApprovedOfferCartsAsync()
        {
            IEnumerable<OfferCart> result = await _context.OfferCarts.Where(x => x.AcceptCustomerService == true && x.IsActive == true).ToListAsync();
            if (result == null) return null;
            else return result;
        }


        /// <summary>
        /// Customer Service'in onaylamadığı tüm OfferCartları Döner
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> CustomerServiceWaitingOfferCartsAsync()
        {
            IEnumerable<OfferCart> result = await _context.OfferCarts.Where(x => x.AcceptCustomerService == false && x.IsActive == true).ToListAsync();
            if (result == null) return null;
            else return result;
        }


        /// <summary>
        /// Customer Service'in OfferCart onaylaması
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> CustomerServiceAcceptOfferCartAsync(int offerCartId)
        {
            OfferCart result = await _context.OfferCarts.FindAsync(offerCartId);
            if (result == null) return false;
            else
            {
                result.AcceptCustomerService = true;
                result.UpdateDate = DateTime.Now;
                _context.OfferCarts.Update(result);
                return await _context.SaveChangesAsync() > 0;
            }
        }


        /// <summary>
        /// CustomerService için OfferCart red işlemini yapar
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> CustomerServiceDeclineOfferCartAsync(int offerCartId)
        {
            OfferCart result = await _context.OfferCarts.FindAsync(offerCartId);
            if (result == null) return false;
            else
            {
                if (result.AcceptAdmin == true) return false;
                else
                {
                    result.AcceptCustomerService = false;
                    result.UpdateDate = DateTime.Now;
                    _context.OfferCarts.Update(result);
                    return await _context.SaveChangesAsync() > 0;
                }
            }
        }


        /// <summary>
        /// Admin için OfferCart onaylamasını yapar
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> AdminAcceptOfferCartAsync(int offerCartId)
        {
            OfferCart result = await _context.OfferCarts.FindAsync(offerCartId);
            if (result == null) return false;
            else
            {
                result.UpdateDate = DateTime.Now;
                result.AcceptAdmin = true;
                _context.OfferCarts.Update(result);
                return await _context.SaveChangesAsync() > 0;
            }
        }


        /// <summary>
        /// Admin için OfferCart reddini yapar
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<bool> AdminDeclineOfferCartAsync(int offerCartId)
        {
            OfferCart result = await _context.OfferCarts.FindAsync(offerCartId);
            if (result == null) return false;
            else
            {
                result.UpdateDate = DateTime.Now;
                result.AcceptAdmin = false;
                _context.OfferCarts.Update(result);
                return await _context.SaveChangesAsync() > 0;
            }
        }

        /// <summary>
        /// Admin için onay bekleyen Tüm OfferCartları Döndürür
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> AdminApprovedOfferCartsAsync()
        {
            IEnumerable<OfferCart> result = await _context.OfferCarts.Where(x => x.AcceptAdmin == true && x.AcceptCustomerService == true && x.IsActive == true).ToListAsync();
            if (result == null) return null;
            else return result;
        }

        /// <summary>
        /// Admin için Onaylanmış tüm OfferCartları Döndürür
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> AdminWaitingOfferCartsAsync()
        {
            IEnumerable<OfferCart> result = await _context.OfferCarts.Where(x => x.AcceptAdmin == false && x.AcceptCustomerService == true && x.IsActive == true).ToListAsync();
            if (result == null) return null;
            else return result;
        }

        /// <summary>
        /// Fiyatı güncellenmek istenen OfferCart'ı döner
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<OfferCart> GetUpdateOfferCartPriceAsync(int offerCartId)
        {
            OfferCart result = await _context.OfferCarts.FindAsync(offerCartId);
            if (result == null) return null;
            else return result;
        }


        /// <summary>
        /// OfferCart'ın TotalPrice Güncelleme işlemini yapar
        /// </summary>
        /// <param name="offerCart"></param>
        /// <returns></returns>
        public async Task<bool> UpdateOfferCartPriceAsync(OfferCart offerCart)
        {
            _context.OfferCarts.Update(offerCart);
            return await _context.SaveChangesAsync() > 0;
        }

        /// <summary>
        /// Kullanıcı ID'ye ait olan tüm Offer Cartları döndürür
        /// </summary>
        /// <param name="offerCartId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<OfferCart>> GetOfferCartsByUserIdAsync(int appUserId)
        {
            return await _context.OfferCarts
                .Include(oc => oc.AppUser)
                .Include(oc => oc.Product)
                .Include(oc => oc.OfferCartMessages)
                .Where(x => x.IsActive == true && x.AppUserId == appUserId)
                .ToListAsync();
        }

        public async Task<IEnumerable<OfferCart>> GetOfferCartsWaitingSampleAsync()
        {
            IEnumerable<OfferCart> result = await _context.OfferCarts.Where(x => x.AcceptAdmin == true && x.AcceptCustomerService == true && x.IsActive == true && x.AcceptVisitor == true && x.IsSample == false && x.IsApproved == true).ToListAsync();
            if (result == null) return null;
            else return result;
        }
        public async Task<IEnumerable<OfferCart>> GetOfferCartsWaitingMoldAsync()
        {
            IEnumerable<OfferCart> result = await _context.OfferCarts.Where(x => x.AcceptAdmin == true && x.AcceptCustomerService == true && x.IsActive == true && x.AcceptVisitor == true && x.IsSample == true && x.IsApproved == true && x.IsMold == false).ToListAsync();
            if (result == null) return null;
            else return result;

        }
        public async Task<IEnumerable<OfferCart>> GetOfferCartsWaitingFinalizationAsync()
        {
            IEnumerable<OfferCart> result = await _context.OfferCarts.Where(x => x.AcceptAdmin == true && x.AcceptCustomerService == true && x.IsActive == true && x.AcceptVisitor == true && x.IsSample == true && x.IsApproved == true && x.IsMold == true && x.IsFinalization == false).ToListAsync();
            if (result == null) return null;
            else return result;

        }
    }
}
