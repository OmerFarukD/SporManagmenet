namespace SporManagmenet.WebApi.Models.Dtos.PlayerImages;

public sealed record PlayerImageResponseDto
{
    public Guid Id { get; init; }

    public Guid PlayerId { get; init; }

    public string PlayerName { get; init; }
    public string Url { get; init; }
}