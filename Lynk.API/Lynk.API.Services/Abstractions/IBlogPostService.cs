using Lynk.API.Dtos.BlogPostsDtos;

namespace Lynk.API.Services.Abstractions
{
    public interface IBlogPostService
    {
        Task<BlogPostDto> CreateBlogPostAsync(CreateBlogPostRequestDto request);
        Task<IEnumerable<BlogPostDto>> GetAllAsync();
        Task<BlogPostDto?> GetByIdAsync(Guid id);
        Task<BlogPostDto?> GetByUrlHandleAsync(string urlHandle);
        Task<BlogPostDto?> UpdateAsync(Guid id, UpdateBlogPostRequestDto request);
        Task<BlogPostDto?> DeleteAsync(Guid id);
    }
}
