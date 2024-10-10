using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models.DTOs.ProductDTOs
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Likes { get; set; }
        public List<string> ImageUrls { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
