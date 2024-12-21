
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Options;

namespace SporManagmenet.WebApi.Services.Helpers.CloudinaryHelper;

public class CloudinaryService : ICloudinaryService
{
    private readonly Cloudinary _cloudinary;
    private readonly Account _account;
    private readonly CloudinarySettings _cloudinarySettings;

    public CloudinaryService(IOptions<CloudinarySettings> cloudinarySettings)
    {
        _cloudinarySettings = cloudinarySettings.Value;
        _account = new Account(_cloudinarySettings.CloudName,_cloudinarySettings.ApiKey,_cloudinarySettings.ApiSecret);
        _cloudinary = new Cloudinary(_account);
    }

    public string UploadImage(IFormFile formFile, string directoryName)
    {
        var imageUploadResult = new ImageUploadResult();

        if (formFile.Length > 0)
        {
            using var stream = formFile.OpenReadStream();
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(formFile.Name, stream),
                Folder = directoryName
            };

            imageUploadResult = _cloudinary.Upload(uploadParams);
            string url = _cloudinary.Api.UrlImgUp.BuildUrl(imageUploadResult.PublicId);

            return url;
        }

        return string.Empty;
    }
}
