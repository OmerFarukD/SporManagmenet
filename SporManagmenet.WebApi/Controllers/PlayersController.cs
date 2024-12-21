using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SporManagmenet.WebApi.Models.Dtos.Coachs;
using SporManagmenet.WebApi.Models.Dtos.Players;
using SporManagmenet.WebApi.Services.Abstracts;
using SporManagmenet.WebApi.Services.Concretes;

namespace SporManagmenet.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController(IPlayerService playerService) : ControllerBase
    {

        [HttpPost("add")]
        public IActionResult Add([FromBody] PlayerAddRequestDto dto) => Ok(playerService.Add(dto));

        [HttpPut("update")]
        public IActionResult Update([FromBody] PlayerUpdateRequestDto dto) => Ok(playerService.Update(dto));

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] Guid id) => Ok(playerService.Delete(id));

        [HttpGet("getbyid")]
        public IActionResult GetById([FromQuery] Guid id) => Ok(playerService.GetById(id));

        [HttpGet("getall")]
        public IActionResult GetAll() => Ok(playerService.GetAll());
    }
}
