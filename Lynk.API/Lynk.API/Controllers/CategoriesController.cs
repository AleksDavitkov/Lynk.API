using Lynk.API.Domain.Entities;
using Lynk.API.Dtos.CategoryDtos;
using Lynk.API.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lynk.API.Controllers
{
    // http://localhost:port/api/categories
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryRequestDto request)
        {
            var response = await _categoryService.CreateCategoryAsync(request);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var response = await _categoryService.GetAllAsync();
            return Ok(response);
        }

        // GET: http://localhost:port/api/categories/{id}
        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetCategoryById([FromRoute] Guid id)
        {
            var response = await _categoryService.GetByIdAsync(id);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        // PUT: http://localhost:port/api/categories/{id}
        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> EditCategory([FromRoute] Guid id, [FromBody] UpdateCategoryRequestDto request)
        {
            var updatedCategory = await _categoryService.UpdateAsync(id, request);

            if (updatedCategory == null)
            {
                return NotFound();
            }

            return Ok(updatedCategory);
        }

        // DELETE: http://localhost:port/api/categories/{id}
        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] Guid id)
        {
            var response = await _categoryService.DeleteAsync(id);

            if (response == null)
            {
                return NotFound(new { Message = "Category not found." }); // will update rest of CRU ops with customs later
            }

            return Ok(response);
        }
    }
}
