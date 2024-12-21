using AutoMapper;
using SporManagmenet.WebApi.Models.Dtos.Country;
using SporManagmenet.WebApi.Models.Entities;
using SporManagmenet.WebApi.Repository.Abstracts;
using SporManagmenet.WebApi.Repository.Concretes;
using SporManagmenet.WebApi.Services.Abstracts;
using SporManagmenet.WebApi.Utils.ReturnModels;

namespace SporManagmenet.WebApi.Services.Concretes;

public sealed class CountryService(ICountryRepository _countryRepository,IMapper _mapper) : ICountryService
{
    public ReturnModel<NoData> Add(CountryAddRequestDto addRequestDto)
    {
        Country country = _mapper.Map<Country>(addRequestDto);

        _countryRepository.Add(country);

        return new ReturnModel<NoData> { Message = "Ülke eklendi.", Success = true };
    }

    public ReturnModel<NoData> Delete(int id)
    {
        if (!CountryIsPresent(id))
        {
            return new ReturnModel<NoData> { Message = "İlgili Ülke bulunamadı.",Success=false};
        }

        Country? country = _countryRepository.Get(x=>x.Id==id);

        _countryRepository.Remove(country!);

        return new ReturnModel<NoData> { Message = "Ülke Silindi.", Success = true };

    }

    public ReturnModel<List<CountryResponseDto>> GetAll()
    {
        var countries = _countryRepository.GetAll(enableTracking:false);

        var response = _mapper.Map<List<CountryResponseDto>>(countries);

        return new ReturnModel<List<CountryResponseDto>> { Data = response, Success = true };
    }

    public ReturnModel<CountryResponseDto> GetById(int id)
    {
        if (!CountryIsPresent(id))
        {
            return new ReturnModel<CountryResponseDto> { Message = "İlgili Ülke bulunamadı.", Success = false };
        }

        Country? country = _countryRepository.Get(x => x.Id == id);

        var response = _mapper.Map<CountryResponseDto>(country);

        return new ReturnModel<CountryResponseDto> { Success = true, Data = response };
    }

    public ReturnModel<NoData> Update(CountryUpdateRequestDto updateRequestDto)
    {
        if (!CountryIsPresent(updateRequestDto.Id))
        {
            return new ReturnModel<NoData> { Message = "İlgili Ülke bulunamadı.", Success = false };
        }

        var country = _mapper.Map<Country>(updateRequestDto);

        _countryRepository.Update(country);

        return new ReturnModel<NoData> { Message = "Ülke Güncellendi.", Success = true };


    }

    private bool CountryIsPresent(int id)
    {
        return _countryRepository.Any(predicate: x => x.Id == id);
    }
}
