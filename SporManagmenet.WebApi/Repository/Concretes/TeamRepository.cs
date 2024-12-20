using SporManagmenet.WebApi.Models.Entities;
using SporManagmenet.WebApi.Repository.Abstracts;
using SporManagmenet.WebApi.Repository.Abstracts.EfBases;
using SporManagmenet.WebApi.Repository.Contexts;

namespace SporManagmenet.WebApi.Repository.Concretes;

public sealed class TeamRepository : EfRepositoryBase<Team, int, BaseDbContext>, ITeamRepository
{
    public TeamRepository(BaseDbContext context) : base(context)
    {
    }
}
