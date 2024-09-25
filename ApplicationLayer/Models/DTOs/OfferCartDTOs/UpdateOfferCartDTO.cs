using DomainLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models.DTOs.OfferCartDTOs
{
    public class UpdateOfferCartDTO
    {
        public int OfferCartId { get; set; }
        public int Amount { get; set; }
        public string Address { get; set; }
        public decimal? TotalPrice { get; set; }

        public AppUser? AppUser { get; set; }
        public Product? Product { get; set; }
    }
}
