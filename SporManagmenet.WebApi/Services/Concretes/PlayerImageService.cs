using AutoMapper;
using SporManagmenet.WebApi.Models.Dtos.PlayerImages;
using SporManagmenet.WebApi.Repository.Abstracts;
using SporManagmenet.WebApi.Services.Abstracts;
using SporManagmenet.WebApi.Utils.ReturnModels;

namespace SporManagmenet.WebApi.Services.Concretes;

public sealed class PlayerImageService(IPlayerImageRepository _playerImageRepository, IMapper _mapper) : IPlayerImageService
{
    public ReturnModel<NoData> Add(PlayerImageAddRequestDto addRequestDto)
    {
        throw new NotImplementedException();
    }

    public ReturnModel<List<PlayerImageResponseDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public ReturnModel<List<PlayerImageResponseDto>> GetAllByPlayerId(Guid id)
    {
        throw new NotImplementedException();
    }

    public ReturnModel<PlayerImageResponseDto> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}
