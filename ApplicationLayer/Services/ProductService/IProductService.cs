using ApplicationLayer.Models.DTOs.ProductDTOs;
using DomainLayer.Entities.Concrete;

namespace ApplicationLayer.Services.ProductService
{
    public interface IProductService
    {
        Task AddProductAsync(AddProductDTO product);
        Task DeleteProductAsync(int id);
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
        Task<ProductDetailsDTO> GetProductDetailsAsync(int productId);
        Task UpdateProductAsync(UpdateProductDTO product);
        Task<List<Product>> GetProductByKeyword(string keyword);
    }
}