using ApplicationLayer.Models.DTOs.ProductDTOs;
using ApplicationLayer.Services.ProductService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(await _productService.GetAllProductsAsync());
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductById(int productId)
        {
            return Ok(await _productService.GetProductDetailsAsync(productId));
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductDTO productDto)
        {
            await _productService.AddProductAsync(productDto);
            return Ok(productDto);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDTO productDTO)
        {
            try
            {
                await _productService.UpdateProductAsync(productDTO);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                await _productService.DeleteProductAsync(id);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }

        }

        [HttpGet("{keyword}")]
        public async Task<IActionResult> SearchProductByKeyword(string keyword)
        {
            try
            {
                return Ok(await _productService.GetProductByKeyword(keyword));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult GetAllMaterials()
        {
            var materials = _productService.GetAllMaterials()
                                          .Select(x => new { Id = (int)x, Name = x.ToString() })
                                          .ToList();
            return Ok(materials);
        }
    }
}
