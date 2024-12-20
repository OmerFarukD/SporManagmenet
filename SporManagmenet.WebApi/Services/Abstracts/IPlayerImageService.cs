﻿using SporManagmenet.WebApi.Models.Dtos.PlayerImages;
using SporManagmenet.WebApi.Utils.ReturnModels;

namespace SporManagmenet.WebApi.Services.Abstracts;

public interface IPlayerImageService
{
    ReturnModel<List<PlayerImageResponseDto>> GetAll();
    ReturnModel<PlayerImageResponseDto> GetById(Guid id);
    ReturnModel<NoData> Add(PlayerImageAddRequestDto addRequestDto);

    ReturnModel<List<PlayerImageResponseDto>> GetAllByPlayerId(Guid id);
}

