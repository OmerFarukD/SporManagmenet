namespace SporManagmenet.WebApi.Models.Dtos.PlayerImages;

public sealed record PlayerImageUpdateRequestDto
{
    public Guid Id { get; set; }

    public Guid PlayerId { get; init; }
    public string Url { get; init; }
}
