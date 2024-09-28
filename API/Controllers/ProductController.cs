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
            var product = await _productService.GetProductDetailsAsync(id);
            if (product is null) return NotFound();
            try
            {
                await _productService.GetProductDetailsAsync(id);
                return Ok("Aktifleştirildi");
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }


        //resim yükleme metodu
        [HttpPost("{productId}")]
        public async Task<IActionResult> UploadProductImage(int productId, IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Resim yüklenemedi");

            try
            {
                // Dosya yolunu oluşturma
                var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath); // Klasör yoksa oluştur
                }

                // Dosya adını benzersiz hale getirmek için
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(folderPath, fileName);

                // Dosyayı belirtilen klasöre kaydetme
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                // Ürün resmi yükleme: Veritabanına kaydedilecek yolun güncellenmesi
                var relativePath = $"{fileName}"; // Web'e uygun yol
                var result = await _productService.UploadProductImageAsync(productId, relativePath); // Veritabanına relative yolu kaydedin
                if (!result) return NotFound("Ürün bulunamadı");

                return Ok(new { imageUrl = relativePath }); // Yüklenen resmin URL'sini döndür
            }
            catch (Exception ex)
            {
                // Hata durumunda geri dönüş
                return StatusCode(500, new { message = $"Bir hata oluştu: {ex.Message}" });
            }
        }






        [HttpGet("{ProductId}")]
        public async Task<IActionResult> FindProduct(int ProductId)
        {
            var result = await _productService.FindProduct(ProductId);
            if (!result) return NotFound();
            return Ok(result);
        }
    }
}
