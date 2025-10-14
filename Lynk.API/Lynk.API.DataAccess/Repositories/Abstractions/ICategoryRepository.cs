using Lynk.API.Domain.Entities;

namespace Lynk.API.DataAccess.Repositories.Abstractions
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync (Category category);
        Task<IEnumerable<Category>> GetAllAsync();
    }
}
