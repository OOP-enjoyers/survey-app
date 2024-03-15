using Microsoft.AspNetCore.Mvc;
using SurveyPlatform.Application.Contracts;
using SurveyPlatform.Application.Models;

namespace SurveyPlatform.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(IUserService userService) : ControllerBase
{
    [HttpGet("{id}")]
    public ActionResult<User> Get(int id)
    {
        User user = userService.GetUser(id);
        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }

    [HttpPost]
    public ActionResult<User> Post(User user)
    {
        userService.AddUser(user);
        return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
    }
}