﻿using SporManagmenet.WebApi.Models.Entities;
using SporManagmenet.WebApi.Repository.Abstracts.EfBases;

namespace SporManagmenet.WebApi.Repository.Abstracts;

public interface ITeamRepository : IRepository<Team,int>
{

}