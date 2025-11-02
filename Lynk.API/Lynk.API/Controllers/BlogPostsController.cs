using Lynk.API.DataAccess.Repositories.Implementations;
using Lynk.API.Domain.Entities;
using Lynk.API.Dtos.BlogPostsDtos;
using Lynk.API.Dtos.CategoryDtos;
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

        [HttpGet]
        public async Task<IActionResult> GetAllBlogPosts()
        {
            var blogPosts = await _blogPostService.GetAllAsync();
            return Ok(blogPosts);
        }

        // GET: http://localhost:port/api/blogposts/{id}
        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetBlogPostById([FromRoute] Guid id)
        {
            var blogPost = await _blogPostService.GetByIdAsync(id);
            return Ok(blogPost);
        }

        // PUT: http://localhost:port/api/blogposts/{id}
        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateBlogPostById([FromRoute] Guid id, [FromBody] UpdateBlogPostRequestDto request)
        {
            var updatedBlogPost = await _blogPostService.UpdateAsync(id, request);
            return Ok(updatedBlogPost);
        }
    }
}
