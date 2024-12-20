using SporManagmenet.WebApi.Models.Dtos.Teams;
using SporManagmenet.WebApi.Utils.ReturnModels;

namespace SporManagmenet.WebApi.Services.Abstracts;

public interface ITeamService 
{
    ReturnModel<List<TeamResponseDto>> GetAllTeams();
    ReturnModel<TeamResponseDto> GetById(int id);
    ReturnModel<NoData> Add(TeamAddRequestDto addRequestDto);
    ReturnModel<NoData> Update(TeamUpdateRequestDto updateRequestDto);

    ReturnModel<NoData> Delete(int id);
}
