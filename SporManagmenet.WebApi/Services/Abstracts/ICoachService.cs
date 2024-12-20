
using SporManagmenet.WebApi.Models.Dtos.Coachs;
using SporManagmenet.WebApi.Utils.ReturnModels;

namespace SporManagmenet.WebApi.Services.Abstracts;

public interface ICoachService
{
    ReturnModel<List<CoachResponseDto>> GetAll();
    ReturnModel<CoachResponseDto> GetById(Guid id);
    ReturnModel<NoData> Add(CoachAddRequestDto addRequestDto);
    ReturnModel<NoData> Update(CoachUpdateRequestDto updateRequestDto);

    ReturnModel<NoData> Delete(Guid id);
}