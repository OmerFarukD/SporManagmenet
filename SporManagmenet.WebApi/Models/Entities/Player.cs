using SporManagmenet.WebApi.Models.Enums;

namespace SporManagmenet.WebApi.Models.Entities;

public class Player : Entity<Guid>
{
    public string Name { get; set; }

    public string Surname { get; set; }

    public int Age { get; set; }

    public int JerseyNumber { get; set; }
    public Branch Branch { get; set; }

    public Gender Gender { get; set; }

    public decimal Salary { get; set; }


    public int TeamId { get; set; }
    public Team Team { get; set; }


    public int CountryId { get; set; }
    public Country Country { get; set; }

    public List<PlayerImage> PlayerImages { get; set; }

}
