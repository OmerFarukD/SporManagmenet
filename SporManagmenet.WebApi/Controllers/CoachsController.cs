using Microsoft.AspNetCore.Mvc;
using SporManagmenet.WebApi.Models.Dtos.Coachs;
using SporManagmenet.WebApi.Services.Abstracts;
using SporManagmenet.WebApi.Services.Helpers.CloudinaryHelper;

namespace SporManagmenet.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoachsController(ICoachService coachService) : ControllerBase
{
    [HttpPost("add")]
    public IActionResult Add([FromBody] CoachAddRequestDto dto) => Ok(coachService.Add(dto));

    [HttpPut("update")]
    public IActionResult Update([FromBody] CoachUpdateRequestDto dto) => Ok(coachService.Update(dto));

    [HttpDelete("delete")]
    public IActionResult Delete([FromQuery] Guid id) => Ok(coachService.Delete(id));

    [HttpGet("getbyid")]
    public IActionResult GetById([FromQuery] Guid id) => Ok(coachService.GetById(id));

    [HttpGet("getall")]
    public IActionResult GetAll() => Ok(coachService.GetAll());



}
