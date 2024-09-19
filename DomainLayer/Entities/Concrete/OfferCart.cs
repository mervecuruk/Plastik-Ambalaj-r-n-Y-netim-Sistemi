using DomainLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities.Concrete
{
    public class OfferCart : IEntity
    {
        public int OfferCartId { get; set; }
        public int AppUserId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public DateTime? CompletedDate { get; set; }

        //onaylanma durumları
        public bool AcceptAdmin { get; set; } = false;
        public bool AcceptContentManager { get; set; } = false;
        public bool AcceptCustomerService { get; set; } = false;
        public bool AcceptVisitor { get; set; } = false;

        //üretim aşamaları 
        public bool IsApproved { get; set; } = false;
        public bool IsSample { get; set; } = false;
        public bool IsMold { get; set; } = false;
        public bool IsFinalization { get; set; } = false;

        public DateTime AddedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }

        //navigation property
        public AppUser? AppUser { get; set; }
        public Product? Product { get; set; }
        public ICollection<OfferCartMessage> OfferCartMessages { get; set; }
    }
}
