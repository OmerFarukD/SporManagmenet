using AutoMapper;
using SporManagmenet.WebApi.Models.Dtos.Players;
using SporManagmenet.WebApi.Models.Entities;
using SporManagmenet.WebApi.Repository.Abstracts;
using SporManagmenet.WebApi.Repository.Concretes;
using SporManagmenet.WebApi.Services.Abstracts;
using SporManagmenet.WebApi.Utils.ReturnModels;

namespace SporManagmenet.WebApi.Services.Concretes;

public sealed class PlayerService(IPlayerRepository _playerRepository, IMapper _mapper) : IPlayerService
{
    public ReturnModel<NoData> Add(PlayerAddRequestDto addRequestDto)
    {
        Player player = _mapper.Map<Player>(addRequestDto);
        _playerRepository.Add(player);

        return new ReturnModel<NoData> { Message = "Oyuncu eklendi.", Success = true };

    }

    public ReturnModel<NoData> Delete(Guid id)
    {
        if (!PlayerIsPresent(id))
        {
            return new ReturnModel<NoData> { Success = false, Message = "Oyuncu bulunamadı." };
        }

        Player? player = _playerRepository.Get(x=>x.Id==id);

        _playerRepository.Remove(player!);

        return new ReturnModel<NoData> { Message = "Oyuncu Silindi.",Success=true};
    }

    public ReturnModel<List<PlayerResponseDto>> GetAll()
    {
        var players = _playerRepository.GetAll(enableTracking:false);
        var response = _mapper.Map<List<PlayerResponseDto>>(players);

        return new ReturnModel<List<PlayerResponseDto>> { Data = response, Success = true };
    }

    public ReturnModel<PlayerResponseDto> GetById(Guid id)
    {
        if (!PlayerIsPresent(id))
        {
            return new ReturnModel<PlayerResponseDto> { Success = false, Message = "Oyuncu bulunamadı." };
        }

        Player? player = _playerRepository.Get(x => x.Id == id);

        var response = _mapper.Map<PlayerResponseDto>(player);

        return new ReturnModel<PlayerResponseDto> { Data = response, Success = true };

    }

    public ReturnModel<NoData> Update(PlayerUpdateRequestDto updateRequestDto)
    {
        if (!PlayerIsPresent(updateRequestDto.Id))
        {
            return new ReturnModel<NoData> { Success = false, Message = "Oyuncu bulunamadı." };
        }

        Player player = _mapper.Map<Player>(updateRequestDto);

        _playerRepository.Update(player);

        return new ReturnModel<NoData> { Message = "Oyuncu Güncellendi.", Success = false };


    }

    private bool PlayerIsPresent(Guid id)
    {
        return _playerRepository.Any(x => x.Id == id);
    }
}