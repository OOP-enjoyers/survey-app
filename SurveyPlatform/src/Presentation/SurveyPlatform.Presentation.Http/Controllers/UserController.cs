using Microsoft.AspNetCore.Mvc;
using SurveyPlatform.Application.Contracts.Services;
using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public ActionResult<User> Post(User user)
    {
        _userService.AddUser(user);

        return Ok();
    }

    [HttpGet("{id}")]
    public ActionResult<User> Get(int id)
    {
        User user = _userService.GetUser(id);
        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }

    [HttpPut]
    public IActionResult Edit(User user)
    {
        if (_userService.GetUser(user.Id) == null)
        {
            return NotFound();
        }

        _userService.EditUser(user);

        return Ok();
    }

    [HttpDelete("{id}")]
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