using DomainLayer.Entities.Abstract;

namespace DomainLayer
{
    public class OfferCartMessage : IEntity
    {
        public int OfferCartMessageId { get; set; }
        public int AppUserId { get; set; }
        public int OfferCartId { get; set; }
        public DateTime SendDate { get; set; }
        public string Message { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }
    }
}