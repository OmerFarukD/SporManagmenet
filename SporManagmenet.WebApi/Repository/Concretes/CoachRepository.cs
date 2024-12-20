using SporManagmenet.WebApi.Models.Entities;
using SporManagmenet.WebApi.Repository.Abstracts;
using SporManagmenet.WebApi.Repository.Abstracts.EfBases;
using SporManagmenet.WebApi.Repository.Contexts;
namespace SporManagmenet.WebApi.Repository.Concretes;

public sealed class CoachRepository : EfRepositoryBase<Coach, Guid, BaseDbContext>, ICoachRepository
{
    public CoachRepository(BaseDbContext context) : base(context)
    {
    }
}
