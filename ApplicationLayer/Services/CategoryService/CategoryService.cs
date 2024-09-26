using ApplicationLayer.Models.DTOs.CategoryDTOs;
using ApplicationLayer.Models.DTOs.ProductDTOs;
using AutoMapper;
using DomainLayer;
using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using InfrastructureLayer.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task AddCategoryAsync(AddCategoryDTO category)
        {
            Category newCategory = new Category();
            newCategory.IsActive= true;
            _mapper.Map(category, newCategory);
            await _categoryRepository.AddAsync(newCategory);
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync()
        {
            var result = await _categoryRepository.GetAllAsync();
            List<CategoryDTO> categories = new List<CategoryDTO>();
            _mapper.Map(result, categories);
            return categories;
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await _categoryRepository.FindAsync(id);
            if (category != null)
            {
                await _categoryRepository.DeleteAsync(category.CategoryId);
            }
        }

        public async Task UpdateCategoryAsync(UpdateCategoryDTO category)
        {
            var oldCategory = await _categoryRepository.FindAsync(category.CategoryId);
            _mapper.Map(category, oldCategory);
            await _categoryRepository.UpdateAsync(oldCategory);
        }

        public async Task<GetAllProductsOfCategoryDTO> GetAllProductsOfCategoryAsync(int categoryId)
        {
            var categoriesWithProducts = await _categoryRepository.GetAllInclude().Include(x => x.Products).Where(x => x.CategoryId == categoryId).SingleOrDefaultAsync();
            GetAllProductsOfCategoryDTO getAllProductsOfCategoryDTO = new GetAllProductsOfCategoryDTO();
            _mapper.Map(categoriesWithProducts, getAllProductsOfCategoryDTO);
            return getAllProductsOfCategoryDTO;

        }

        public async Task<List<Category>> GetCategoryByKeywordAsync(string keyword)
        {
            var categories = await _categoryRepository.GetAllInclude().Where(x => x.CategoryName.Contains(keyword)).ToListAsync();
            return categories;
        }
    }
}
