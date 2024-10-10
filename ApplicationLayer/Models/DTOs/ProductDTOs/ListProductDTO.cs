using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models.DTOs.ProductDTOs
{
    public class ListProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Material { get; set; }
        public string MaterialName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<string>? ImageUrls { get; set; }
        public int? Likes { get; set; }
        public int? Views { get; set; }
    }
}
