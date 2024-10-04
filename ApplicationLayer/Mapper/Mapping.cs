using ApplicationLayer.Models.DTOs.BlogDTOs;
using ApplicationLayer.Models.DTOs.CategoryDTOs;
using ApplicationLayer.Models.DTOs.OfferCartDTOs;
using ApplicationLayer.Models.DTOs.OfferCartMessageDTOs;
using ApplicationLayer.Models.DTOs.ProductDTOs;
using ApplicationLayer.Models.DTOs.SssDTOs;
using AutoMapper;
using DomainLayer;
using DomainLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Product, AddProductDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Product, UpdateProductDTO>().ReverseMap();
            CreateMap<Product, ProductDetailsDTO>().ReverseMap();

            CreateMap<Category, AddCategoryDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Category, UpdateCategoryDTO>().ReverseMap();
            CreateMap<Category, GetAllProductsOfCategoryDTO>().ReverseMap();

            CreateMap<OfferCart, AddOfferCartDTO>().ReverseMap();
            CreateMap<OfferCart, UpdateOfferCartDTO>().ReverseMap();

            CreateMap<OfferCartMessage, AddOfferCartMessageDTO>().ReverseMap();

            CreateMap<Blog, AddBlogDTO>().ReverseMap();
            CreateMap<Blog, BlogDTO>().ReverseMap();
            CreateMap<Blog, BlogDetailsDTO>().ReverseMap();
            CreateMap<Blog, UpdateBlogDTO>().ReverseMap();

            CreateMap<Sss, SssUpdatedDTO>().ReverseMap();
        }
    }
}
