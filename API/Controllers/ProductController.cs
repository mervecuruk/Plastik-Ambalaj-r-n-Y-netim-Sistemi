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

        // id bilgisini ald. productı aktifleştirelim.
        [HttpGet("{id}")]
        public async Task<IActionResult> MakeProductActive(int id)
        {
            try
            {
                await _productService.GetActiveAsync(id);
                return Ok("Aktifleştirildi");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        //yeni resim ekleme deneme metodu
        [HttpPost]
        public async Task<IActionResult> UpdateProductImage(UploadImageDTO uploadImageDTO)
        {
            await _productService.UploadProductImageAsync(uploadImageDTO);
            return Ok();
        }

        //Admin onayı için false olan ürünleri listeleyen metot
        [HttpGet]
        public async Task<IActionResult> GetAllProductsForAdmin()
        {
            return Ok(await _productService.GetAllProductsForAdminAsync());
        }

        [HttpGet("{ProductId}")]
        public async Task<IActionResult> FindProduct(int ProductId)
        {
            var result = await _productService.FindProduct(ProductId);
            if (!result) return NotFound();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVisitorProducts()
        {
            return Ok(await _productService.GetAllVisitorProductsAsync());
        }


        //beğeni butonu için
        [HttpPut("{productId}")]
        public async Task<IActionResult> IncreaseLike(int productId)
        {
            try
            {
                var newLikeCount = await _productService.IncreaseLikeAsync(productId);
                return Ok(newLikeCount);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut("{productId}")]
        public async Task<IActionResult> DecreaseLike(int productId)
        {
            try
            {
                var newLikeCount = await _productService.DecreaseLikeAsync(productId);
                return Ok(newLikeCount);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut("{productId}")]
        public async Task<IActionResult> IncreaseView(int productId)
        {
            try
            {
                var newViewCount = await _productService.IncreaseViewAsync(productId);
                return Ok(newViewCount);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
