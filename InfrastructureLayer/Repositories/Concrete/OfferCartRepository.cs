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

        // Teklif sepet ekle.
        public async Task<OfferCart> AddOfferCartAsync(OfferCart offerCart)
        {
            offerCart.IsActive = true;
            _context.OfferCarts.Add(offerCart);
            await _context.SaveChangesAsync();
            return offerCart;
        }

        // Hocanın yaptığı teklif sepete ekle.
        public async Task AddToCartAsync(OfferCart cart)
        {
            var result = _context.OfferCarts.Where(x => x.AppUserId == cart.AppUserId && x.ProductId == cart.ProductId && x.IsActive == true).SingleOrDefault();
            if (result == null)
            {
                _context.OfferCarts.Add(cart);
            }
            else
            {
                //burada debug ekleyerek kontrolünü sağla!!!!
                result.Amount += cart.Amount;
                _context.OfferCarts.Update(result);
            }
            await _context.SaveChangesAsync();
        }

        // Teklif onayı ver.(Admin)
        public async Task<bool> ApproveOfferByAdminAsync(int offerCartId)
        {
            var offerCart = await _context.OfferCarts.FindAsync(offerCartId);
            if (offerCart != null && !offerCart.IsApproved)
            {
                offerCart.AcceptAdmin = true;
                offerCart.IsApproved = true;
                _context.OfferCarts.Update(offerCart);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        // Numune Hazırlanması Onayı
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

        // Teklif pasif silme isactive=false
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

        // Tüm teklifleri getir.
        public async Task<IEnumerable<OfferCart>> GetAllOfferCartsAsync()
        {
            return await _context.OfferCarts
                .Where(oc => oc.IsActive)
                .Include(oc => oc.AppUser)
                .Include(oc => oc.Product)
                .ToListAsync();
        }

        // Teklif Sepeti getirme.
        public async Task<OfferCart> GetOfferCartByIdAsync(int offerCartId)
        {
            return await _context.OfferCarts
                .Include(oc => oc.AppUser)
                .Include(oc => oc.Product)
                .Include(oc => oc.OfferCartMessages)
                .FirstOrDefaultAsync(oc => oc.OfferCartId == offerCartId && oc.IsActive);
        }

        // Tüm sepeti temizleme
        public Task RemoveAllProductsForUserAsync(int userId)
        {
            var results = _context.OfferCarts.Where(x => x.AppUserId == userId);
            _context.RemoveRange(results);
            return Task.CompletedTask;
        }

        // Ürün üretimi tamamlandı mı durumu
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

        // Kalıp üretim durumu
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

        // Numune hazırlansın mı butonunu göstermek için (Yönetici Onayladıysa)
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


        // Teklif Sepetini Güncelleme.
        public async Task<OfferCart> UpdateOfferCartAsync(OfferCart offerCart)
        {
            offerCart.UpdateDate = DateTime.Now;
            _context.OfferCarts.Update(offerCart);
            await _context.SaveChangesAsync();
            return offerCart;
        }

    }
}
