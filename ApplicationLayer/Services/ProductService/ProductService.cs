using ApplicationLayer.Models.DTOs.ProductDTOs;
using AutoMapper;
using DomainLayer.Entities.Concrete;
using DomainLayer.Enums;
using DomainLayer.Repositories.Abstract;
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
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
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
            var product = await _productRepository.GetAllInclude().Include(x => x.Category).Where(x => x.ProductId == productId).SingleOrDefaultAsync();
            ProductDetailsDTO productDetailsDTO = new ProductDetailsDTO();
            _mapper.Map(product, productDetailsDTO);
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

        //Resim yükleme metodu
        public async Task<bool> UploadProductImageAsync(UploadImageDTO uploadImageDTO)
        {
            Product oldProduct = await _productRepository.FindAsync(uploadImageDTO.ProductId);
            oldProduct.ImageUrl = uploadImageDTO.ImageUrl;
            return await _productRepository.UploadProductImageAsync(oldProduct);
        }

        public async Task<bool> FindProduct(int ProductId)
        {
            return await _productRepository.FindProduct(ProductId);
        }
    }
}
