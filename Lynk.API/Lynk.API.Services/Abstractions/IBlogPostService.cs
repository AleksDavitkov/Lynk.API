using Lynk.API.Dtos.BlogPostsDtos;

namespace Lynk.API.Services.Abstractions
{
    public interface IBlogPostService
    {
        Task<BlogPostDto> CreateBlogPostAsync(CreateBlogPostRequestDto request);
    }
}
