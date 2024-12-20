namespace SporManagmenet.WebApi.Models.Dtos.Coachs;

public sealed record CoachUpdateRequestDto(Guid Id,string Name, int CountryId, int TeamId);
