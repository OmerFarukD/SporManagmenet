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
}
