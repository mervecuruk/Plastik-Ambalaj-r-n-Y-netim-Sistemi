using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Concrete
{
    public class OfferCartRepository : BaseRepository<OfferCart>, IOfferCartRepository
    {
        public async Task AddToCartAsync(OfferCart cart)
        {
            var result=_context.OfferCarts.Where(x=>x.AppUserId == cart.AppUserId && x.ProductId==cart.ProductId).SingleOrDefault();
            if(result == null)
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

        public Task RemoveAllProductsForUserAsync(int userId)
        {
            var results = _context.OfferCarts.Where(x => x.AppUserId == userId);
            _context.RemoveRange(results);
            return Task.CompletedTask;
        }
    }
}
