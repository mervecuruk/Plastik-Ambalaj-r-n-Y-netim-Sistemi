using DomainLayer.Entities.Concrete;
using DomainLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Repositories.Abstract
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        List<Material> GetAllMaterials();

        //resim yükleme metodu
        Task<bool> UploadProductImageAsync(Product product);
        Task<bool> FindProduct(int ProductId);

        Task<int> IncreaseLikeAsync(int productId);
        Task<int> DecreaseLikeAsync(int productId);
        Task<int> IncreaseViewAsync(int productId);
    }
}
