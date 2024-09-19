namespace DomainLayer
{
    public class OfferCartMessage
    {
        public int OfferCartMessageId { get; set; }
        public int AppUserId { get; set; }
        public int OfferCartId { get; set; }
        public DateTime SendDate { get; set; }
        public string Message { get; set; }

    }
}