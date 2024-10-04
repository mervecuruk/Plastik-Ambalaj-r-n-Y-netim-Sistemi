using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models.DTOs.ProductDTOs
{
    public class UploadImageDTO
    {
        public int ProductId { get; set; }
        public List<string> ImageUrls { get; set; }
    }
}
