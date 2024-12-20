using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SporManagmenet.WebApi.Models.Entities;

namespace SporManagmenet.WebApi.Repository.Configurations
{
    public class CoachConfiguration : IEntityTypeConfiguration<Coach>
    {
        public void Configure(EntityTypeBuilder<Coach> builder)
        {
            builder.Navigation(x => x.Country).AutoInclude();
            builder.Navigation(x => x.Team).AutoInclude();
        }
    }
}
