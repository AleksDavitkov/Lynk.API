namespace Lynk.API.Dtos.BlogImageDtos
{
    public class BlogImageDto
    {
        // exposing all properties for simplicity
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
