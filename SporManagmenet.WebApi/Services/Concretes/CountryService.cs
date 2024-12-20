using AutoMapper;
using SporManagmenet.WebApi.Models.Dtos.Country;
using SporManagmenet.WebApi.Repository.Abstracts;
using SporManagmenet.WebApi.Services.Abstracts;
using SporManagmenet.WebApi.Utils.ReturnModels;

namespace SporManagmenet.WebApi.Services.Concretes;

public sealed class CountryService(ICountryRepository _countryRepository,IMapper _mapper) : ICountryService
{
    public ReturnModel<NoData> Add(CountryAddRequestDto addRequestDto)
    {
        throw new NotImplementedException();
    }

    public ReturnModel<NoData> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public ReturnModel<List<CountryResponseDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public ReturnModel<CountryResponseDto> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public ReturnModel<NoData> Update(CountryUpdateRequestDto updateRequestDto)
    {
        throw new NotImplementedException();
    }
}
