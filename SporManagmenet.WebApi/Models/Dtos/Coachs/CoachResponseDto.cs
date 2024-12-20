namespace SporManagmenet.WebApi.Models.Dtos.Coachs;

public sealed record CoachResponseDto
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string CountryName { get; init; }
}
