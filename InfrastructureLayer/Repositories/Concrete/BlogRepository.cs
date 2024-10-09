using DomainLayer.Entities.Concrete;
using DomainLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Concrete
{
    public class BlogRepository : BaseRepository<Blog>, IBlogRepository
    {
        public async Task<bool> UploadProductImageAsync(Blog blog)
        {
            var blogOld = await _context.Blogs.FindAsync(blog.BlogId);
            if (blog == null) return false;
            
            blogOld.ImageUrl = blog.ImageUrl == null ? blogOld.ImageUrl : blog.ImageUrl;
            blogOld.UpdateDate = DateTime.Now;
            _context.Blogs.Update(blogOld);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
