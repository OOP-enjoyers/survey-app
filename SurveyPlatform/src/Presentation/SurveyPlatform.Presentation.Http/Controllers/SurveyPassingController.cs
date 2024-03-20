using Microsoft.AspNetCore.Mvc;
using SurveyPlatform.Application.Contracts.Services;
using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class SurveyPassingController : ControllerBase
{
    private readonly ISurveyPassingService _surveyPassingService;

    public SurveyPassingController(ISurveyPassingService surveyPassingService)
    {
        _surveyPassingService = surveyPassingService;
    }

    [HttpPost("{surveyId}/{userId}")]
    public ActionResult<User> AddSurveyPassing(int surveyId, int userId, string[][] responses)
    {
        _surveyPassingService.AddSurveyPassing(surveyId, userId, responses);

        return Ok();
    }

    [HttpGet("{surveyId}/{userId}")]
    public ActionResult<User> GetSurveyPassing(int surveyId, int userId)
    {
        IReadOnlyCollection<IReadOnlyCollection<Response>> responses = _surveyPassingService.GetSurveyPassing(surveyId, userId);

        return Ok(responses);
    }
}