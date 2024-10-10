using ApplicationLayer.Models.DTOs.ProductDTOs;
using AutoMapper;
using DomainLayer.Entities.Concrete;
using DomainLayer.Enums;
using DomainLayer.Repositories.Abstract;
using InfrastructureLayer.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task AddProductAsync(AddProductDTO product)
        {
            Product newProduct = new Product();
            _mapper.Map(product, newProduct);
            newProduct.Material = (Material)product.MaterialId;
            await _productRepository.AddAsync(newProduct);
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProductsAsync()
        {
            var result = await _productRepository.GetAllAsync();
            List<ProductDTO> products = new List<ProductDTO>();
            _mapper.Map(result, products);
            return products;
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _productRepository.FindAsync(id);
            if (product != null)
            {
                await _productRepository.DeleteAsync(product.ProductId);
            }
        }

        public async Task UpdateProductAsync(UpdateProductDTO product)
        {
            var oldProduct = await _productRepository.FindAsync(product.ProductId);
            _mapper.Map(product, oldProduct);
            oldProduct.Material = (Material)product.MaterialId;
            await _productRepository.UpdateAsync(oldProduct);
        }

        public async Task<ProductDetailsDTO> GetProductDetailsAsync(int productId)
        {
            var product = await _productRepository.GetAllInclude().Include(x => x.Category).Where(x => x.ProductId == productId).FirstOrDefaultAsync();
            ProductDetailsDTO productDetailsDTO = new ProductDetailsDTO();
            _mapper.Map(product, productDetailsDTO);
            productDetailsDTO.MaterialId = (int)product.Material;
            productDetailsDTO.CategoryId = product.CategoryId;
            productDetailsDTO.CategoryName = product.Category.CategoryName;
            productDetailsDTO.MaterialName = product.Material.ToString();
            productDetailsDTO.Likes = product.Likes;
            productDetailsDTO.Views = product.Views;
            return productDetailsDTO;
        }

        public async Task<List<Product>> GetProductByKeyword(string keyword)
        {
            var products = await _productRepository.GetAllInclude().Where(x => x.ProductName.Contains(keyword)).ToListAsync();
            return products;
        }

        public List<Material> GetAllMaterials()
        {
            return _productRepository.GetAllMaterials();
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProductsForAdminAsync()
        {
            var result = await _productRepository.GetAllForAdminAsync();
            List<ProductDTO> products = new List<ProductDTO>();
            _mapper.Map(result, products);
            return products;
        }

        public async Task<bool> GetActiveAsync(int id)
        {
            if (id == 0)
            {
                return false;
            }
            else
            {
                return await _productRepository.GetActiveAsync(id);
            }
        }

        public async Task<bool> UploadProductImageAsync(UploadImageDTO uploadImageDTO)
        {
            Product oldProduct = await _productRepository.FindAsync(uploadImageDTO.ProductId);
            // Mevcut resim URL'lerini güncelle
            foreach (var imageUrl in uploadImageDTO.ImageUrls)
            {
                if (!oldProduct.ImageUrls.Contains(imageUrl)) // Duplicates'i önlemek için kontrol
                {
                    oldProduct.ImageUrls.Add(imageUrl); // Yeni resmi ekle
                }
            }
            return await _productRepository.UploadProductImageAsync(oldProduct);
        }

        public async Task<bool> FindProduct(int ProductId)
        {
            return await _productRepository.FindProduct(ProductId);
        }

        //visitor için tüm ürünleri listeleme deneme metodu
        public async Task<IEnumerable<ListProductDTO>> GetAllVisitorProductsAsync()
        {
            // Repository'den tüm ürünleri çekiyoruz.
            var result = await _productRepository.GetAllAsync();

            // Boş bir VisitorProductDTO listesi oluşturuyoruz.
            List<ListProductDTO> visitorProducts = new List<ListProductDTO>();

            foreach (var product in result)
            {
                // Material enum'ını string'e dönüştürüyoruz.
                string materialName = Enum.GetName(typeof(Material), product.Material);

                // Category adını ilgili category servisi veya repository'den alıyoruz.
                var category = await _categoryRepository.FindAsync(product.CategoryId);

                // VisitorProductDTO nesnesini dolduruyoruz.
                ListProductDTO visitorProduct = new ListProductDTO
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Description = product.Description, // Eğer mevcutsa
                    Price = product.Price,
                    Material = (int)product.Material,  // Enum ID'si
                    MaterialName = materialName,  // Enum adı
                    CategoryId = product.CategoryId,
                    CategoryName = category.CategoryName,  // Veritabanından alınan kategori adı
                    ImageUrls = product.ImageUrls, // Mevcut image URL'leri
                    Likes = product.Likes,
                    Views = product.Views // Eğer mevcutsa
                };

                visitorProducts.Add(visitorProduct);
            }

            return visitorProducts;
        }

        public async Task<int> IncreaseLikeAsync(int productId)
        {
            return await _productRepository.IncreaseLikeAsync(productId);
        }

        public async Task<int> DecreaseLikeAsync(int productId)
        {
            return await _productRepository.DecreaseLikeAsync(productId);
        }

        public async Task<int> IncreaseViewAsync(int productId)
        {
            return await _productRepository.IncreaseViewAsync(productId);
        }
    }
}
