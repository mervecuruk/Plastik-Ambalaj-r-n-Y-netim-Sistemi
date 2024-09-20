using ApplicationLayer.Models.DTOs.ProductDTOs;
using AutoMapper;
using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.ProductService
{
    public class ProductService
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
            await _productRepository.UpdateAsync(oldProduct);
        }

    }
}
