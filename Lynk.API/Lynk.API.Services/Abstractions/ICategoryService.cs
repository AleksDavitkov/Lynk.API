using Lynk.API.Dtos.CategoryDtos;

namespace Lynk.API.Services.Abstractions
{
    public interface ICategoryService
    {
        Task<CategoryDto> CreateCategoryAsync(CreateCategoryRequestDto request);
        Task<IEnumerable<CategoryDto>> GetAllAsync();
    }
}
