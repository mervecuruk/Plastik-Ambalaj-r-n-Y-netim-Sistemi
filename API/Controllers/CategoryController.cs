using ApplicationLayer.Models.DTOs.CategoryDTOs;
using ApplicationLayer.Models.DTOs.ProductDTOs;
using ApplicationLayer.Services.CategoryService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok(await _categoryService.GetAllCategoriesAsync());
        }

        [HttpGet("{categoryId}")]
        public async Task<IActionResult> GetCategoryById(int categoryId)
        {
            return Ok(await _categoryService.GetAllProductsOfCategoryAsync(categoryId));
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(AddCategoryDTO categoryDto)
        {
            await _categoryService.AddCategoryAsync(categoryDto);
            return Ok(categoryDto);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDTO categoryDto)
        {
            try
            {
                await _categoryService.UpdateCategoryAsync(categoryDto);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                await _categoryService.DeleteCategoryAsync(id);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }

        }

        [HttpGet("{keyword}")]
        public async Task<IActionResult> SearchCategoryByKeyword(string keyword)
        {
            try
            {
                return Ok(await _categoryService.GetCategoryByKeywordAsync(keyword));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

    }
}
