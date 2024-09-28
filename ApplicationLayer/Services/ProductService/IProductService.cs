using ApplicationLayer.Models.DTOs.ProductDTOs;
using DomainLayer.Entities.Concrete;
using DomainLayer.Enums;

namespace ApplicationLayer.Services.ProductService
{
    public interface IProductService
    {
        Task AddProductAsync(AddProductDTO product);
        Task DeleteProductAsync(int id);
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
        Task<IEnumerable<ProductDTO>> GetAllProductsForAdminAsync();
        Task<ProductDetailsDTO> GetProductDetailsAsync(int productId);
        Task UpdateProductAsync(UpdateProductDTO product);
        Task<List<Product>> GetProductByKeyword(string keyword);
        List<Material> GetAllMaterials();
        Task<bool> GetActiveAsync(int id);
        //resim yükleme metodu
        Task<bool> UploadProductImageAsync(int productId, string imagePath);

        //
        Task<bool> FindProduct(int ProductId);
    }
}