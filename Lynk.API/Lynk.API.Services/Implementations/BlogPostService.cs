using Lynk.API.DataAccess.Repositories.Abstractions;
using Lynk.API.Domain.Entities;
using Lynk.API.Dtos.BlogPostsDtos;
using Lynk.API.Services.Abstractions;
using Lynk.API.Shared.CustomExceptions;

namespace Lynk.API.Services.Implementations
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IBlogPostRepository _blogPostRepository;

        public BlogPostService(IBlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }

        public async Task<BlogPostDto> CreateBlogPostAsync(CreateBlogPostRequestDto request)
        {
            if (string.IsNullOrWhiteSpace(request.Title))
            {
                throw new AppException("Blog post title is required");
            }

            var blogPost = new BlogPost
            {
                Title = request.Title,
                ShortDescription = request.ShortDescription,
                Content = request.Content,
                FeaturedImageUrl = request.FeaturedImageUrl,
                UrlHandle = request.UrlHandle,
                PublishedDate = request.PublishedDate,
                Author = request.Author,
                IsVisible = request.IsVisible
            };

            await _blogPostRepository.CreateAsync(blogPost);

            return new BlogPostDto
            {
                Id = blogPost.Id,
                Title = blogPost.Title,
                ShortDescription = blogPost.ShortDescription,
                Content = blogPost.Content,
                FeaturedImageUrl = blogPost.FeaturedImageUrl,
                UrlHandle = blogPost.UrlHandle,
                PublishedDate = blogPost.PublishedDate,
                Author = blogPost.Author,
                IsVisible = blogPost.IsVisible
            };
        }
    }
}
