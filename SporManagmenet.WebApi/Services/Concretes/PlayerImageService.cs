using AutoMapper;
using Microsoft.AspNetCore.Http;
using SporManagmenet.WebApi.Models.Dtos.PlayerImages;
using SporManagmenet.WebApi.Models.Entities;
using SporManagmenet.WebApi.Repository.Abstracts;
using SporManagmenet.WebApi.Services.Abstracts;
using SporManagmenet.WebApi.Services.Helpers.CloudinaryHelper;
using SporManagmenet.WebApi.Utils.ReturnModels;

namespace SporManagmenet.WebApi.Services.Concretes;

public sealed class PlayerImageService(IPlayerImageRepository _playerImageRepository,
    IMapper _mapper,
    ICloudinaryService _cloudinaryService
    
    ) : IPlayerImageService
{



    public ReturnModel<NoData> Add(PlayerImageAddRequestDto addRequestDto)
    {
        PlayerImage image = addRequestDto;

        var url = _cloudinaryService.UploadImage(addRequestDto.File,"players");

        image.Url = url;

        _playerImageRepository.Add(image);

        return new ReturnModel<NoData> { Message = "Resim yüklendi.", Success = true };

    }

    public ReturnModel<List<PlayerImageResponseDto>> GetAll()
    {
        var images = _playerImageRepository.GetAll();

        var response = _mapper.Map<List<PlayerImageResponseDto>>(images);

        return new ReturnModel<List<PlayerImageResponseDto>> { Data = response, Success = true };
    }

    public ReturnModel<List<PlayerImageResponseDto>> GetAllByPlayerId(Guid id)
    {
        var images = _playerImageRepository.GetAll(x=>x.PlayerId==id);

        var response = _mapper.Map<List<PlayerImageResponseDto>>(images);

        return new ReturnModel<List<PlayerImageResponseDto>> { Data = response, Success = true };
    }

    public ReturnModel<PlayerImageResponseDto> GetById(Guid id)
    {
        var image = _playerImageRepository.Get(x=>x.Id==id);
        
        var response = _mapper.Map<PlayerImageResponseDto>(image);

        return new ReturnModel<PlayerImageResponseDto> { Data = response, Success = true };
    }
}
