using Lynk.API.Dtos.BlogPostsDtos;
using Lynk.API.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lynk.API.Controllers
{
    // http://localhost:port/api/blogposts
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostsController : ControllerBase
    {
        private readonly IBlogPostService _blogPostService;

        public BlogPostsController(IBlogPostService blogPostService)
        {
            _blogPostService = blogPostService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlogPost([FromBody] CreateBlogPostRequestDto request)
        {
            var blogPost = await _blogPostService.CreateBlogPostAsync(request);
            return Ok(blogPost);
        }
    }
}
