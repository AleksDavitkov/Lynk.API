using Lynk.API.DataAccess.Data;
using Lynk.API.DataAccess.Repositories.Abstractions;
using Lynk.API.Domain.Entities;

namespace Lynk.API.DataAccess.Repositories.Implementations
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly ApplicationDbContext dbContext;

        public BlogPostRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<BlogPost> CreateAsync(BlogPost blogPost)
        {
            await dbContext.BlogPosts.AddAsync(blogPost);
            await dbContext.SaveChangesAsync();
            return blogPost;
        }
    }
}
