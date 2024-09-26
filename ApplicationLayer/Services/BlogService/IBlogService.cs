using ApplicationLayer.Models.DTOs.BlogDTOs;
using ApplicationLayer.Models.DTOs.ProductDTOs;
using DomainLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.BlogService
{
    public interface IBlogService
    {
        Task AddBlogAsync(AddBlogDTO blog);
        Task DeleteBlogAsync(int id);
        Task<IEnumerable<BlogDTO>> GetAllBlogsAsync();
        Task<IEnumerable<BlogDTO>> GetAllBlogsForAdminAsync();
        Task<BlogDetailsDTO> GetBlogDetailsAsync(int blogId);
        Task UpdateBlogAsync(UpdateBlogDTO product);
        Task<List<Blog>> GetBlogByKeywordAsync(string keyword);
    }
}
