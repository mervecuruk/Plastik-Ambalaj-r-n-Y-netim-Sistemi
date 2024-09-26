using ApplicationLayer.Models.DTOs.BlogDTOs;
using ApplicationLayer.Models.DTOs.ProductDTOs;
using AutoMapper;
using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using InfrastructureLayer.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services.BlogService
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public BlogService(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task AddBlogAsync(AddBlogDTO blog)
        {
            Blog newBlog = new Blog();
            _mapper.Map(blog, newBlog);
            await _blogRepository.AddAsync(newBlog);
        }

        public async Task DeleteBlogAsync(int id)
        {
            var blog = await _blogRepository.FindAsync(id);
            if (blog != null)
            {
                await _blogRepository.DeleteAsync(blog.BlogId);
            }
        }

        public async Task<IEnumerable<BlogDTO>> GetAllBlogsAsync()
        {
            var result = await _blogRepository.GetAllAsync();
            List<BlogDTO> blogs = new List<BlogDTO>();
            _mapper.Map(result, blogs);
            return blogs;
        }

        public async Task<IEnumerable<BlogDTO>> GetAllBlogsForAdminAsync()
        {
            var result = await _blogRepository.GetAllAsync();
            List<BlogDTO> blogs = new List<BlogDTO>();
            _mapper.Map(result, blogs);
            return blogs;
        }

        public async Task<List<Blog>> GetBlogByKeywordAsync(string keyword)
        {
            var blogs = await _blogRepository.GetAllInclude().Where(x => x.Title.Contains(keyword)).ToListAsync();
            return blogs;
        }

        public async Task<BlogDetailsDTO> GetBlogDetailsAsync(int blogId)
        {
            var blog = await _blogRepository.GetAllInclude().Include(x => x.AppUser).Where(x => x.BlogId == blogId).SingleOrDefaultAsync();
            BlogDetailsDTO blogDetailsDTO = new BlogDetailsDTO();
            _mapper.Map(blog, blogDetailsDTO);
            return blogDetailsDTO;
        }

        public async Task UpdateBlogAsync(UpdateBlogDTO blog)
        {
            var oldBlog = await _blogRepository.FindAsync(blog.BlogId);
            _mapper.Map(blog, oldBlog);
            await _blogRepository.UpdateAsync(oldBlog);
        }
    }
}
