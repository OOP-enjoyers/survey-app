using Microsoft.AspNetCore.Mvc;
using SurveyPlatform.Application.Contracts.Services;
using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Presentation.Http.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("add")]
    public ActionResult Add(User user)
    {
        _userService.AddUser(user);

        return Ok();
    }

    [HttpGet("get")]
    public ActionResult<User> Get(int id)
    {
        User user = _userService.GetUser(id);
        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }

    [HttpPut("edit")]
    public IActionResult Edit(User user)
    {
        if (_userService.GetUser(user.Id) == null)
        {
            return NotFound();
        }

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