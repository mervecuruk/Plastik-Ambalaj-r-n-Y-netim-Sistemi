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

        public async Task<bool> UploadProductImageAsync(Product product)
        {
            var productOld = await _context.Products.FindAsync(product.ProductId);
            if (product == null) return false;

            // Mevcut resim URL'lerini güncelle
            foreach (var imageUrl in product.ImageUrls)
            {
                if (!product.ImageUrls.Contains(imageUrl)) // Duplicates'i önlemek için kontrol
                {
                    product.ImageUrls.Add(imageUrl); // Yeni resmi ekle
                }
            }
            productOld.UpdateDate = DateTime.Now;
            _context.Products.Update(productOld);
            await _context.SaveChangesAsync();
            return true;
        }

        //public async Task<bool> UploadProductImageAsync(Product product)
        //{
        //    var productOld = await _context.Products.FindAsync(product.ProductId);
        //    if (product == null) return false;

        //    productOld.ImageUrl = product.ImageUrl;
        //    productOld.UpdateDate = DateTime.Now;
        //    _context.Products.Update(productOld);
        //    await _context.SaveChangesAsync();
        //    return true;
        //}


        //sadece ürünü bulma
        public async Task<bool> FindProduct(int ProductId)
        {
            var product = await _context.Products.FindAsync(ProductId);
            if (product == null) return false;
            return true;
        }
    }
}
