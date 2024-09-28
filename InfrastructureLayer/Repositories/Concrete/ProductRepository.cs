using DomainLayer.Entities.Concrete;
using DomainLayer.Enums;
using DomainLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Concrete
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public List<Material> GetAllMaterials()
        {
            return Enum.GetValues(typeof(Material))
        .Cast<Material>()
        .ToList();
        }

        //Product için resim yükleme metodu
        public async Task<bool> UploadProductImageAsync(int productId, string imagePath)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) return false;

            product.ImageUrl = imagePath;
            product.UpdateDate = DateTime.Now;
            await _context.SaveChangesAsync();
            return true;
        }


        //sadece ürünü bulma
        public async Task<bool> FindProduct(int ProductId)
        {
            var product = await _context.Products.FindAsync(ProductId);
            if (product == null) return false;
            return true;
        }
    }
}
