namespace Lynk.API.Dtos.CategoryDtos
{
    public class DeleteCategoryRequestDto
    {
        public string Message { get; set; }
        public CategoryDto? DeletedCategory { get; set; }
    }
}
