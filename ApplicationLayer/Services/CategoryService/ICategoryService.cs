using ApplicationLayer.Models.DTOs.CategoryDTOs;
using DomainLayer;
using DomainLayer.Entities.Concrete;

namespace ApplicationLayer.Services.CategoryService
{
    public interface ICategoryService
    {
        Task AddCategoryAsync(AddCategoryDTO category);
        Task DeleteCategoryAsync(int id);
        Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync();
        Task<GetAllProductsOfCategoryDTO> GetAllProductsOfCategoryAsync(int categoryId);
        Task UpdateCategoryAsync(UpdateCategoryDTO category);
        Task<List<Category>> GetCategoryByKeywordAsync(string keyword);
    }
}