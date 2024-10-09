using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models.DTOs.OfferCartDTOs
{
    public class OfferCartPriceDTO
    {
        public int OfferCartId { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
