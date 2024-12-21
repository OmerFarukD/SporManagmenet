namespace SporManagmenet.WebApi.Services.Helpers.CloudinaryHelper;

public interface ICloudinaryService
{
    string UploadImage(IFormFile formFile, string directoryName);
}
