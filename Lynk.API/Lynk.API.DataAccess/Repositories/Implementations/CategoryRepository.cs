using Lynk.API.DataAccess.Data;
using Lynk.API.DataAccess.Repositories.Abstractions;
using Lynk.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lynk.API.DataAccess.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return category;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await dbContext.Categories.ToListAsync();
        }
    }
}
