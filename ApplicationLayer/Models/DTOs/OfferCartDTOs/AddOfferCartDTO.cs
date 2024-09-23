using DomainLayer.Entities.Concrete;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models.DTOs.OfferCartDTOs
{
    public class AddOfferCartDTO
    {
        public int AppUserId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public decimal? TotalPrice { get; set; }
        public bool IsRefundRequest { get; set; } // iade talebi
        
    }
}
