using Lynk.API.DataAccess.Repositories.Abstractions;
using Lynk.API.Domain.Entities;
using Lynk.API.Dtos.CategoryDtos;
using Lynk.API.Services.Abstractions;
using Lynk.API.Shared.CustomExceptions;

namespace Lynk.API.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<CategoryDto> CreateCategoryAsync(CreateCategoryRequestDto request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
                throw new AppException("Category name is required");

            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };

            await _categoryRepository.CreateAsync(category);

            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle
            };
        }

        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();

            return categories.Select(c => new CategoryDto
            {
                Id = c.Id,
                Name = c.Name,
                UrlHandle = c.UrlHandle
            });
        }
    }
}
