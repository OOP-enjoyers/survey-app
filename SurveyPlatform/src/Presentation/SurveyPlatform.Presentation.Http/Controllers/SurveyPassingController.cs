using Microsoft.AspNetCore.Mvc;
using SurveyPlatform.Application.Contracts.Services;
using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Presentation.Http.Controllers;

[ApiController]
[Route("survey_passing")]
public class SurveyPassingController : ControllerBase
{
    private readonly ISurveyPassingService _surveyPassingService;

    public SurveyPassingController(ISurveyPassingService surveyPassingService)
    {
        _surveyPassingService = surveyPassingService;
    }

    [HttpPost("add")]
    public ActionResult Add(int surveyId, int userId, string[][] responses)
    {
        _surveyPassingService.AddSurveyPassing(surveyId, userId, responses);

        return Ok();
    }

    [HttpGet("get")]
    public ActionResult<IReadOnlyCollection<IReadOnlyCollection<Response>>> Get(int surveyId, int userId)
    {
        IReadOnlyCollection<IReadOnlyCollection<Response>> responses = _surveyPassingService.GetSurveyPassing(surveyId, userId);

        if (responses.Count == 0)
        {
            return NotFound();
        }

        return Ok(responses);
    }

    [HttpGet("get_last")]
    public ActionResult<IReadOnlyCollection<Response>> GetLast(int surveyId, int userId)
    {
        IReadOnlyCollection<IReadOnlyCollection<Response>> responses = _surveyPassingService.GetSurveyPassing(surveyId, userId);

        if (responses.Count == 0)
        {
            return NotFound();
        }

        return Ok(responses.Last());
    }
}