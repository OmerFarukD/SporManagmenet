using SporManagmenet.WebApi.Models.Dtos.Teams;
using SporManagmenet.WebApi.Models.Entities;
using SporManagmenet.WebApi.Repository.Abstracts;
using SporManagmenet.WebApi.Services.Abstracts;
using SporManagmenet.WebApi.Utils.ReturnModels;

namespace SporManagmenet.WebApi.Services.Concretes;

public class TeamService(ITeamRepository _teamRepository) : ITeamService
{


    public ReturnModel<NoData> Add(TeamAddRequestDto addRequestDto)
    {
        Team team = addRequestDto;
        _teamRepository.Add(team);

        return new ReturnModel<NoData> { Message = "Takım Eklendi", Success = true };
    }

    public ReturnModel<NoData> Delete(int id)
    {
        if (!TeamIsPresent(id))
        {
            return new ReturnModel<NoData> { Message = $"Takım bulunamadı Id:{id}", Success = false };
        }


        var team = _teamRepository.Get(x=>x.Id==id);

        _teamRepository.Remove(team);

        return new ReturnModel<NoData> { Message = "Takım Silindi.", Success = true };

    }

    public ReturnModel<List<TeamResponseDto>> GetAllTeams()
    {
        List<Team> teams = _teamRepository.GetAll(enableTracking:false,include:false);
        List<TeamResponseDto> responses = teams.Select(x=>(TeamResponseDto)x).ToList();
        return new ReturnModel<List<TeamResponseDto>> { Data = responses, Success = true };
    }

    public ReturnModel<TeamResponseDto> GetById(int id)
    {
        if (!TeamIsPresent(id))
        {
            return new ReturnModel<TeamResponseDto> { Message = $"Takım bulunamadı Id:{id}", Success = false };
        }

        var team = _teamRepository.Get(x => x.Id == id,enableTracking:false,include:false);

        TeamResponseDto responseDto = team!;


        return new ReturnModel<TeamResponseDto> { Data = responseDto, Success = true };

    }

    public ReturnModel<NoData> Update(TeamUpdateRequestDto updateRequestDto)
    {
        if (!TeamIsPresent(updateRequestDto.Id))
        {
            return new ReturnModel<NoData> { Message = $"Takım bulunamadı Id:{updateRequestDto.Id}", Success = false };
        }

        Team team = updateRequestDto;

        _teamRepository.Update(team);

        return new ReturnModel<NoData> { Message = "Takım Güncellendi.", Success = true };
    }


    // private metods ,

    private bool TeamIsPresent(int id)
    {
        return _teamRepository.Any(predicate: x=>x.Id==id);
    }


}
