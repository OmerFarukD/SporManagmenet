using SporManagmenet.WebApi.Models.Dtos.Country;
using SporManagmenet.WebApi.Utils.ReturnModels;

namespace SporManagmenet.WebApi.Services.Abstracts;

public interface ICountryService
{
    ReturnModel<List<CountryResponseDto>> GetAll();
    ReturnModel<CountryResponseDto> GetById(int id);
    ReturnModel<NoData> Add(CountryAddRequestDto addRequestDto);
    ReturnModel<NoData> Update(CountryUpdateRequestDto updateRequestDto);

    ReturnModel<NoData> Delete(int id);
}
