using Lynk.API.DataAccess.Repositories.Abstractions;
using Lynk.API.Domain.Entities;
using Lynk.API.Dtos.BlogPostsDtos;
using Lynk.API.Dtos.CategoryDtos;
using Lynk.API.Services.Abstractions;
using Lynk.API.Shared.CustomExceptions;

namespace Lynk.API.Services.Implementations
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IBlogPostRepository _blogPostRepository;
        private readonly ICategoryRepository categoryRepository;

        public BlogPostService(IBlogPostRepository blogPostRepository, ICategoryRepository categoryRepository)
        {
            _blogPostRepository = blogPostRepository;
            this.categoryRepository = categoryRepository;
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
                IsVisible = request.IsVisible,
                Categories = new List<Category>()
            };

            if (request.Categories is not null && request.Categories.Any())
            {
                foreach (var categoryId in request.Categories)
                {
                    var category = await categoryRepository.GetByIdAsync(categoryId);

                    if (category == null)
                    {
                        throw new KeyNotFoundException($"Category with ID '{categoryId}' not found.");
                    }

                    blogPost.Categories.Add(category);
                }
            }

            var createdBlogPost = await _blogPostRepository.CreateAsync(blogPost);

            return new BlogPostDto
            {
                Id = createdBlogPost.Id,
                Author = createdBlogPost.Author,
                Content = createdBlogPost.Content,
                FeaturedImageUrl = createdBlogPost.FeaturedImageUrl,
                IsVisible = createdBlogPost.IsVisible,
                PublishedDate = createdBlogPost.PublishedDate,
                ShortDescription = createdBlogPost.ShortDescription,
                Title = createdBlogPost.Title,
                UrlHandle = createdBlogPost.UrlHandle,
                Categories = createdBlogPost.Categories.Select(category => new CategoryDto
                {
                    Id = category.Id,
                    Name = category.Name,
                    UrlHandle = category.UrlHandle
                }).ToList()
            };
        }

        public async Task<IEnumerable<BlogPostDto>> GetAllAsync()
        {
            var blogPosts = await _blogPostRepository.GetAllAsync();

            if (!blogPosts.Any())
            {
                throw new AppException("No blog posts found");
            }

            return blogPosts.Select(bp => new BlogPostDto
            {
                Id = bp.Id,
                Author = bp.Author,
                Content = bp.Content,
                FeaturedImageUrl = bp.FeaturedImageUrl,
                IsVisible = bp.IsVisible,
                PublishedDate = bp.PublishedDate,
                ShortDescription = bp.ShortDescription,
                Title = bp.Title,
                UrlHandle = bp.UrlHandle,
                Categories = bp.Categories.Select(category => new CategoryDto
                {
                    Id = category.Id,
                    Name = category.Name,
                    UrlHandle = category.UrlHandle
                }).ToList()
            });
        }

        public async Task<BlogPostDto> GetByIdAsync(Guid id)
        {
            var blogPost = await _blogPostRepository.GetByIdAsync(id);

            if (blogPost == null)
            {
                throw new KeyNotFoundException($"Blog post with ID '{id}' not found");
            }

            return new BlogPostDto
            {
                Id = blogPost.Id,
                Author = blogPost.Author,
                Content = blogPost.Content,
                FeaturedImageUrl = blogPost.FeaturedImageUrl,
                IsVisible = blogPost.IsVisible,
                PublishedDate = blogPost.PublishedDate,
                ShortDescription = blogPost.ShortDescription,
                Title = blogPost.Title,
                UrlHandle = blogPost.UrlHandle,
                Categories = blogPost.Categories.Select(category => new CategoryDto
                {
                    Id = category.Id,
                    Name = category.Name,
                    UrlHandle = category.UrlHandle
                }).ToList()
            };
        }

        public async Task<BlogPostDto> UpdateAsync(Guid id, UpdateBlogPostRequestDto request)
        {
            var existingBlogPost = await _blogPostRepository.GetByIdAsync(id);

            if (existingBlogPost == null)
            {
                throw new KeyNotFoundException($"Blog post with ID '{id}' not found");
            }

            if (string.IsNullOrWhiteSpace(request.Title))
            {
                throw new AppException("Blog post title is required");
            }

            existingBlogPost.Title = request.Title;
            existingBlogPost.ShortDescription = request.ShortDescription;
            existingBlogPost.Content = request.Content;
            existingBlogPost.FeaturedImageUrl = request.FeaturedImageUrl;
            existingBlogPost.UrlHandle = request.UrlHandle;
            existingBlogPost.PublishedDate = request.PublishedDate;
            existingBlogPost.Author = request.Author;
            existingBlogPost.IsVisible = request.IsVisible;

            if (request.Categories is not null && request.Categories.Any())
            {
                existingBlogPost.Categories.Clear();

                foreach (var categoryId in request.Categories)
                {
                    var category = await categoryRepository.GetByIdAsync(categoryId);
                    if (category == null)
                    {
                        throw new KeyNotFoundException($"Category with ID '{categoryId}' not found");
                    } 

                    existingBlogPost.Categories.Add(category);
                }
            }

            await _blogPostRepository.UpdateAsync(existingBlogPost);

            return new BlogPostDto
            {
                Id = existingBlogPost.Id,
                Title = existingBlogPost.Title,
                ShortDescription = existingBlogPost.ShortDescription,
                Content = existingBlogPost.Content,
                FeaturedImageUrl = existingBlogPost.FeaturedImageUrl,
                UrlHandle = existingBlogPost.UrlHandle,
                PublishedDate = existingBlogPost.PublishedDate,
                Author = existingBlogPost.Author,
                IsVisible = existingBlogPost.IsVisible,
                Categories = existingBlogPost.Categories.Select(x => new CategoryDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    UrlHandle = x.UrlHandle
                }).ToList()
            };
        }
    }
}
