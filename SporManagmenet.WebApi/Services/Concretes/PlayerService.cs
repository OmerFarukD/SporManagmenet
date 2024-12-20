using AutoMapper;
using SporManagmenet.WebApi.Models.Dtos.Players;
using SporManagmenet.WebApi.Repository.Abstracts;
using SporManagmenet.WebApi.Services.Abstracts;
using SporManagmenet.WebApi.Utils.ReturnModels;

namespace SporManagmenet.WebApi.Services.Concretes;

public sealed class PlayerService(IPlayerRepository _playerRepository, IMapper _mapper) : IPlayerService
{
    public ReturnModel<NoData> Add(PlayerAddRequestDto addRequestDto)
    {
        throw new NotImplementedException();
    }

    public ReturnModel<NoData> Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public ReturnModel<List<PlayerResponseDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public ReturnModel<PlayerResponseDto> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public ReturnModel<NoData> Update(PlayerUpdateRequestDto updateRequestDto)
    {
        throw new NotImplementedException();
    }
}