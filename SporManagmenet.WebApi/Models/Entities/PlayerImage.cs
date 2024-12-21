using SporManagmenet.WebApi.Models.Dtos.PlayerImages;

namespace SporManagmenet.WebApi.Models.Entities;

public class PlayerImage : Entity<Guid>
{
    public Guid PlayerId { get; set; }

    public Player Player { get; set; }

    public string Url { get; set; }



    public static implicit operator PlayerImage(PlayerImageAddRequestDto dto)
    {
        return new PlayerImage { PlayerId = dto.PlayerId };
    }
}
