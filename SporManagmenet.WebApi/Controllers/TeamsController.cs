using Microsoft.AspNetCore.Mvc;
using SporManagmenet.WebApi.Models.Dtos.Teams;
using SporManagmenet.WebApi.Services.Abstracts;

namespace SporManagmenet.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TeamsController(ITeamService _teamService) : ControllerBase
{

    [HttpPost("add")]
    public IActionResult Add([FromBody] TeamAddRequestDto teamAddRequestDto)
    {

        var response = _teamService.Add(teamAddRequestDto);

        return Ok(response);
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        return Ok(_teamService.GetAllTeams());
    }

    [HttpGet("getbyid")]
    public IActionResult GetById([FromQuery] int id)
    {
        return Ok(_teamService.GetById(id));
    }

    [HttpPut("update")]
    public IActionResult Update([FromBody] TeamUpdateRequestDto dto) => Ok(_teamService.Update(dto));

    [HttpDelete("delete")]
    public IActionResult Delete([FromQuery] int id) => Ok(_teamService.Delete(id));

}
