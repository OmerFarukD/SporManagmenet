using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SporManagmenet.WebApi.Models.Entities;

namespace SporManagmenet.WebApi.Repository.Configurations;

public class PlayerConfiguration : IEntityTypeConfiguration<Player>
{
    public void Configure(EntityTypeBuilder<Player> builder)
    {
        builder.Navigation(x => x.Country).AutoInclude();
        builder.Navigation(x => x.Team).AutoInclude();
    }
}
