using Microsoft.AspNetCore.Mvc;
using SurveyPlatform.Application.Contracts.Services;
using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
#pragma warning disable IDE0052
    private readonly IUserService _userService;
#pragma warning restore IDE0052

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{id}")]
    public ActionResult<User> Get(int id)
    {
        User user = _userService.GetUser(id);
        return user == null ? NotFound() : Ok(user);
    }

    [HttpPost]
    public ActionResult<User> Post(User user)
    {
        _userService.AddUser(user);
        return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
    }
}