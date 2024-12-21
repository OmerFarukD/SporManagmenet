using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SporManagmenet.WebApi.Models.Dtos.Coachs;
using SporManagmenet.WebApi.Models.Dtos.Country;
using SporManagmenet.WebApi.Services.Abstracts;
using SporManagmenet.WebApi.Services.Concretes;

namespace SporManagmenet.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController(ICountryService countryService) : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult Add([FromBody] CountryAddRequestDto dto) => Ok(countryService.Add(dto));

        [HttpPut("update")]
        public IActionResult Update([FromBody] CountryUpdateRequestDto dto) => Ok(countryService.Update(dto));

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] int id) => Ok(countryService.Delete(id));

        [HttpGet("getbyid")]
        public IActionResult GetById([FromQuery] int id) => Ok(countryService.GetById(id));

        [HttpGet("getall")]
        public IActionResult GetAll() => Ok(countryService.GetAll());
    }
}
