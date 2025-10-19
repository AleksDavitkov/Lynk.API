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
            {
                throw new AppException("Category name is required");
            }

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

            return categories.Select(category => new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle
            });
        }

        public async Task<CategoryDto?> GetByIdAsync(Guid id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);

            if (category == null)
                return null;

            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle
            };
        }

        public async Task<CategoryDto?> UpdateAsync(Guid id, UpdateCategoryRequestDto request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
            {
                throw new AppException("Category name is required.");
            }

            var existingCategory = await _categoryRepository.GetByIdAsync(id);

            if (existingCategory == null)
            {
                return null;
            }

            existingCategory.Name = request.Name;
            existingCategory.UrlHandle = request.UrlHandle;

            var updatedCategory = await _categoryRepository.UpdateAsync(existingCategory);

            return new CategoryDto
            {
                Id = updatedCategory.Id,
                Name = updatedCategory.Name,
                UrlHandle = updatedCategory.UrlHandle
            };
        }

        public async Task<DeleteCategoryRequestDto?> DeleteAsync(Guid id)
        {
            var existingCategory = await _categoryRepository.GetByIdAsync(id);

            if (existingCategory == null)
            {
                return null;
            }

            var deletedCategory = await _categoryRepository.DeleteAsync(id);

            return new DeleteCategoryRequestDto
            {
                Message = "Category deleted successfully.",
                DeletedCategory = new CategoryDto
                {
                    Id = deletedCategory.Id,
                    Name = deletedCategory.Name,
                    UrlHandle = deletedCategory.UrlHandle
                }
            };
        }
    }
}
