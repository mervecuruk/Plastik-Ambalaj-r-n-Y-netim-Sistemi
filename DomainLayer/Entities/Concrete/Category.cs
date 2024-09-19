using DomainLayer.Entities.Abstract;
using DomainLayer.Entities.Concrete;

namespace DomainLayer
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public DateTime AddedDate { get; set; }= DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }


        //navigation property
        public ICollection<Product>? Products { get; set; }
    }
}