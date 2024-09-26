using ApplicationLayer.Models.DTOs.BlogDTOs;
using ApplicationLayer.Models.DTOs.ProductDTOs;
using ApplicationLayer.Services.BlogService;
using ApplicationLayer.Services.ProductService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBlogs()
        {
            return Ok(await _blogService.GetAllBlogsAsync());
        }

        [HttpGet("{blogId}")]
        public async Task<IActionResult> GetBlogById(int blogId)
        {
            return Ok(await _blogService.GetBlogDetailsAsync(blogId));
        }

        [HttpPost]
        public async Task<IActionResult> AddBlog(AddBlogDTO blogDto)
        {
            await _blogService.AddBlogAsync(blogDto);
            return Ok(blogDto);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogDTO blogDTO)
        {
            try
            {
                await _blogService.UpdateBlogAsync(blogDTO);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            try
            {
                await _blogService.DeleteBlogAsync(id);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }

        }

        [HttpGet("{keyword}")]
        public async Task<IActionResult> SearchBlogTitleByKeyword(string keyword)
        {
            try
            {
                return Ok(await _blogService.GetBlogByKeywordAsync(keyword));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }


        // id bilgisini ald. productı aktifleştirelim.
        [HttpGet("{id}")]
        public async Task<IActionResult> MakeBlogActive(int id)
        {
            var blog = await _blogService.GetBlogDetailsAsync(id);
            if (blog is null) return NotFound();
            try
            {
                await _blogService.GetBlogDetailsAsync(id);
                return Ok("Aktifleştirildi");
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
    }
}
