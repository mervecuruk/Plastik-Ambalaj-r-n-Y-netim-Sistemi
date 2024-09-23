using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models.DTOs.OfferCartMessageDTOs
{
    public class AddOfferCartMessageDTO
    {
        public string? Message { get; set; }
        public int AppUserId { get; set; }
        public int OfferCartId { get; set; }
    }
}
