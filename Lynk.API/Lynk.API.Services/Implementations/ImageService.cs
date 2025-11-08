//using Lynk.API.DataAccess.Repositories.Abstractions;
//using Lynk.API.Domain.Entities;
//using Lynk.API.Dtos.BlogImageDtos;
//using Lynk.API.Services.Abstractions;

//namespace Lynk.API.Services.Implementations
//{
//    public class ImageService : IImageService
//    {
//        private readonly IImageRepository _imageRepository;

//        public ImageService(IImageRepository imageRepository)
//        {
//            _imageRepository = imageRepository;
//        }

//        public async Task<BlogImageDto> UploadImageAsync(IFormFile file, string fileName, string title)
//        {
//            var blogImage = new BlogImage
//            {
//                FileExtension = Path.GetExtension(file.FileName).ToLower(),
//                FileName = fileName,
//                Title = title,
//                DateCreated = DateTime.Now
//            };

//            blogImage = await _imageRepository.Upload(file, blogImage);

//            return new BlogImageDto
//            {
//                Id = blogImage.Id,
//                Title = blogImage.Title,
//                DateCreated = blogImage.DateCreated,
//                FileName = blogImage.FileName,
//                FileExtension = blogImage.FileExtension,
//                Url = blogImage.Url
//            };
//        }
//    }
//}
