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
        Task<bool> UploadProductImageAsync(int productId, string imagePath);
        Task<bool> FindProduct(int ProductId);
    }
}
