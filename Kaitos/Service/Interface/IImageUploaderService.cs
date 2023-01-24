namespace Kaitos.Service.Interface
{
    public interface IImageUploaderService
    {
        Task ResizeImage(string filePath, string uploadedFolder, string fileName);
        Task<string> UploadImageAsync(IFormFile file);
    }
}
