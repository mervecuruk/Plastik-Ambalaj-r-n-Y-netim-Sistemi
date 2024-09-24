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
                // Numune butonu gösterilsin
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

    }
}
