//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Hosting;
//using Lynk.API.DataAccess.Data;
//using Lynk.API.Domain.Entities;
//using Lynk.API.DataAccess.Repositories.Abstractions;

//namespace Lynk.API.DataAccess.Repositories.Implementations
//{
//    public class ImageRepository : IImageRepository
//    {
//        private readonly IWebHostEnvironment _webHostEnvironment;
//        private readonly IHttpContextAccessor _httpContextAccessor;
//        private readonly ApplicationDbContext _dbContext;

//        public ImageRepository(
//            IWebHostEnvironment webHostEnvironment,
//            IHttpContextAccessor httpContextAccessor,
//            ApplicationDbContext dbContext)
//        {
//            _webHostEnvironment = webHostEnvironment;
//            _httpContextAccessor = httpContextAccessor;
//            _dbContext = dbContext;
//        }

//        public async Task<BlogImage> Upload(IFormFile file, BlogImage blogImage)
//        {
//            var imagesPath = Path.Combine(_webHostEnvironment.ContentRootPath, "Images");

//            if (!Directory.Exists(imagesPath))
//            {
//                Directory.CreateDirectory(imagesPath);
//            }

//            var localPath = Path.Combine(imagesPath, $"{blogImage.FileName}{blogImage.FileExtension}");

//            using var stream = new FileStream(localPath, FileMode.Create);
//            await file.CopyToAsync(stream);

//            var httpRequest = _httpContextAccessor.HttpContext.Request;
//            var urlPath = $"{httpRequest.Scheme}://{httpRequest.Host}{httpRequest.PathBase}/Images/{blogImage.FileName}{blogImage.FileExtension}";

//            blogImage.Url = urlPath;

//            await _dbContext.BlogImages.AddAsync(blogImage);
//            await _dbContext.SaveChangesAsync();

//            return blogImage;
//        }
//    }
//}
