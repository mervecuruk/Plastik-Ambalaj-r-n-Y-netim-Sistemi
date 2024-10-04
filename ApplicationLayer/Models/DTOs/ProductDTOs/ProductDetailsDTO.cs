using DomainLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models.DTOs.ProductDTOs
{
    public class ProductDetailsDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        //public string ImageUrl { get; set; }
        public List<string> ImageUrls { get; set; }
        public string Description { get; set; }
        public int MaterialId { get; set; }
        public int CategoryId { get; set; }
        public Material Material { get; set; }
        public string MaterialName { get; set; }
        public string CategoryName { get; set; }
    }
}
