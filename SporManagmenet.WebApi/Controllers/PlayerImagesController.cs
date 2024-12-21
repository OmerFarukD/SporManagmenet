using Microsoft.AspNetCore.Mvc;
using SporManagmenet.WebApi.Models.Dtos.PlayerImages;
using SporManagmenet.WebApi.Services.Abstracts;

namespace SporManagmenet.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlayerImagesController(IPlayerImageService _playerImageService) : ControllerBase
{

    [HttpPost("add")]
    public IActionResult Add(PlayerImageAddRequestDto dto) => Ok(_playerImageService.Add(dto));


    [HttpGet("getallplayerid")]
    public IActionResult GetAllByPlayerId([FromQuery] Guid id) => Ok(_playerImageService.GetAllByPlayerId(id));
}
