using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SurveyPlatform.Application.Contracts.Services;
using SurveyPlatform.Application.Models.DTO.UserDto;
using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Presentation.Http.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public UserController(IUserService userService, IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }

    [HttpPost("add")]
    public ActionResult Add(CreateUserDto userDto)
    {
        User user = _mapper.Map<User>(userDto);
        _userService.AddUser(user);
        return Ok();
    }

    [HttpGet("get")]
    public ActionResult<GetUserDto> Get(int id)
    {
        User user = _userService.GetUser(id);
        if (user == null)
        {
            return NotFound();
        }

        GetUserDto userDto = _mapper.Map<GetUserDto>(user);
        return Ok(userDto);
    }

    [HttpPut("edit")]
    public IActionResult Edit(UpdateUserDto userDto)
    {
        if (_userService.GetUser(userDto.Id) == null)
        {
            return NotFound();
        }

        User user = _mapper.Map<User>(userDto);
        _userService.EditUser(user);

        return Ok();
    }

    [HttpDelete("remove")]
    public IActionResult Remove(int id)
    {
        User user = _userService.GetUser(id);
        if (user == null)
        {
            return NotFound();
        }

        _userService.RemoveUser(id);

        return Ok();
    }
}