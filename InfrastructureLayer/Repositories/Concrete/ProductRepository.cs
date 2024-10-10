using DomainLayer.Entities.Concrete;
using DomainLayer.Enums;
using DomainLayer.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
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

        public async Task<int> IncreaseLikeAsync(int productId)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == productId);
            if (product != null)
            {
                product.Likes = (product.Likes ?? 0) + 1; // Null kontrolü
                _context.Products.Update(product);
                await _context.SaveChangesAsync(); // Asenkron olarak kaydet
                return product.Likes.Value; // Güncel beğeni sayısını döndür
            }
            throw new Exception("Product not found");
        }

        public async Task<int> DecreaseLikeAsync(int productId)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == productId);
            if (product != null)
            {
                // Likes sayısını 1 azalt, ancak 0'ın altına düşmemesi için kontrol et
                product.Likes = (product.Likes ?? 0) > 0 ? (product.Likes.Value - 1) : 0; // Null kontrolü ve 0'dan az olmaması
                _context.Products.Update(product);
                await _context.SaveChangesAsync(); // Asenkron olarak kaydet
                return product.Likes.Value; // Güncel beğeni sayısını döndür
            }
            throw new Exception("Product not found");
        }

        public async Task<int> IncreaseViewAsync(int productId)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == productId);
            if (product != null)
            {
                // Likes sayısını 1 azalt, ancak 0'ın altına düşmemesi için kontrol et
                product.Views = (product.Views ?? 0) + 1; // Null kontrolü ile 1 artır
                _context.Products.Update(product);
                await _context.SaveChangesAsync(); // Asenkron olarak kaydet
                return product.Views.Value; // Güncel görüntülenme sayısını döndür

            }
            throw new Exception("Product not found");
        }
    }
}
