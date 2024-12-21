using SporManagmenet.WebApi.Models.Enums;

namespace SporManagmenet.WebApi.Models.Dtos.PlayerImages;

public sealed record PlayerImageAddRequestDto
{
    public Guid PlayerId { get; init; }

    public IFormFile File { get; set; }
}
