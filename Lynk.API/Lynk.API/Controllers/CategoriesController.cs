using Lynk.API.DataAccess.Data;
using Lynk.API.DataAccess.Repositories.Abstractions;
using Lynk.API.Domain.Entities;
using Lynk.API.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lynk.API.Controllers
{
    // https://localhost:port/api/categories
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        // TBD; missing service layer instead of handling it directly in the controller.
        // proper try/catch with custom exceptions and a global exception handling middleware.
        // still deciding how much to expand the application’s architecture and layering at this stage.
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };

            await categoryRepository.CreateAsync(category);

            var response = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle
            };

            return Ok(response);
        }
    }
}
