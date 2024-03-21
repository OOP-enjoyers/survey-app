using Microsoft.AspNetCore.Mvc;
using SurveyPlatform.Application.Contracts.Services;
using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Presentation.Http.Controllers;

[ApiController]
[Route("survey")]
public class SurveyController : ControllerBase
{
    private readonly ISurveyService _surveyService;

    public SurveyController(ISurveyService surveyService)
    {
        _surveyService = surveyService;
    }

    [HttpPost("add")]
    public ActionResult Add(Survey survey)
    {
        _surveyService.AddSurvey(survey);

        return Ok();
    }

    [HttpGet("get")]
    public ActionResult<Survey> Get(int id)
    {
        Survey survey = _surveyService.GetSurvey(id);
        if (survey == null)
        {
            return NotFound();
        }

        return Ok(survey);
    }

    [HttpPut("edit")]
    public IActionResult Edit(Survey survey)
    {
        if (_surveyService.GetSurvey(survey.Id) == null)
        {
            return NotFound();
        }

        _surveyService.EditSurvey(survey);

        return Ok();
    }

    [HttpDelete("remove")]
    public IActionResult Remove(int id)
    {
        Survey survey = _surveyService.GetSurvey(id);
        if (survey == null)
        {
            return NotFound();
        }

        _surveyService.RemoveSurvey(id);

        return Ok();
    }
}