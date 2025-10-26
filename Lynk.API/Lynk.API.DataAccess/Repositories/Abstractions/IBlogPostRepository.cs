using Lynk.API.Domain.Entities;

namespace Lynk.API.DataAccess.Repositories.Abstractions
{
    public interface IBlogPostRepository
    {
        Task<BlogPost> CreateAsync(BlogPost blogPost);
    }
}
