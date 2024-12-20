using SporManagmenet.WebApi.Models.Dtos.Players;
using SporManagmenet.WebApi.Utils.ReturnModels;

namespace SporManagmenet.WebApi.Services.Abstracts;

public interface IPlayerService
{
    ReturnModel<List<PlayerResponseDto>> GetAll();
    ReturnModel<PlayerResponseDto> GetById(Guid id);
    ReturnModel<NoData> Add(PlayerAddRequestDto addRequestDto);
    ReturnModel<NoData> Update(PlayerUpdateRequestDto updateRequestDto);

    ReturnModel<NoData> Delete(Guid id);
}

