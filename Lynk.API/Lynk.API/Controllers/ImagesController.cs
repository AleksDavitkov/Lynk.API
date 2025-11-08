//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Http;
//using Lynk.API.Services.Abstractions;

//namespace Lynk.API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ImagesController : ControllerBase
//    {
//        private readonly IImageService _imageService;

//        public ImagesController(IImageService imageService)
//        {
//            _imageService = imageService;
//        }

//        // POST: http://localhost:port/api/images
//        [HttpPost]
//        public async Task<IActionResult> UploadImage(
//            [FromForm] IFormFile file,
//            [FromForm] string fileName,
//            [FromForm] string title)
//        {
//            ValidateFileUpload(file);

//            if (!ModelState.IsValid)
//                return BadRequest(ModelState);

//            var result = await _imageService.UploadImageAsync(file, fileName, title);

//            return Ok(result);
//        }

//        private void ValidateFileUpload(IFormFile file)
//        {
//            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };

//            if (!allowedExtensions.Contains(Path.GetExtension(file.FileName).ToLower()))
//                ModelState.AddModelError("file", "Unsupported file format.");

//            if (file.Length > 10485760) // 10 MB
//                ModelState.AddModelError("file", "File size exceeds the 10 MB limit.");
//        }
//    }
//}
