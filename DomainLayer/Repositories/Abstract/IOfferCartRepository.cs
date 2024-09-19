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
        Task AddToCartAsync(OfferCart cart);
        Task RemoveAllProductsForUserAsync(int userId);
    }
}
