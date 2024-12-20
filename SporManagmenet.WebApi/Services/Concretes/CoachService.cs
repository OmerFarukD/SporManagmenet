using AutoMapper;
using SporManagmenet.WebApi.Models.Dtos.Coachs;
using SporManagmenet.WebApi.Models.Entities;
using SporManagmenet.WebApi.Repository.Abstracts;
using SporManagmenet.WebApi.Services.Abstracts;
using SporManagmenet.WebApi.Utils.ReturnModels;

namespace SporManagmenet.WebApi.Services.Concretes;

public sealed class CoachService(ICoachRepository _coachRepository,IMapper _mapper) : ICoachService
{
    public ReturnModel<NoData> Add(CoachAddRequestDto addRequestDto)
    {
        Coach coach = _mapper.Map<Coach>(addRequestDto);
        _coachRepository.Add(coach);

        return new ReturnModel<NoData> { Message = "Teknik Direktör eklendi.", Success = true };
    }

    public ReturnModel<NoData> Delete(Guid id)
    {
        if (!CoachIsPresent(id))
        {
            return new ReturnModel<NoData> { Message = "Teknik direktör bulunamadı" };
        }

        Coach? coach = _coachRepository.Get(predicate: x => x.Id == id, enableTracking: true);
        _coachRepository.Remove(coach!);

        return new ReturnModel<NoData> { Message = "Teknik dirrektör Silindi.", Success = true };

    }

    public ReturnModel<List<CoachResponseDto>> GetAll()
    {
        var coaches = _coachRepository.GetAll(enableTracking:false);
        var response = _mapper.Map<List<CoachResponseDto>>(coaches);

        return new ReturnModel<List<CoachResponseDto>> { Success = true, Data = response };
    }

    public ReturnModel<CoachResponseDto> GetById(Guid id)
    {
        if (!CoachIsPresent(id))
        {
            return new ReturnModel<CoachResponseDto> { Message = "Teknik direktör bulunamadı" };
        }

        Coach? coach = _coachRepository.Get(predicate: x=>x.Id==id,enableTracking:false);

        var response = _mapper.Map<CoachResponseDto>(coach!);

        return new ReturnModel<CoachResponseDto> { Data = response, Success = true };
    }

    public ReturnModel<NoData> Update(CoachUpdateRequestDto updateRequestDto)
    {
        if (!CoachIsPresent(updateRequestDto.Id))
        {
            return new ReturnModel<NoData> { Message = "Teknik direktör bulunamadı" };
        }

        var coach = _mapper.Map<Coach>(updateRequestDto);

        _coachRepository.Update(coach);

        return new ReturnModel<NoData> { Message = "Teknik direktör güncellendi.", Success = true };
    }


    private bool CoachIsPresent(Guid id)
    {
        return _coachRepository.Any(x=>x.Id==id);
    }
}
