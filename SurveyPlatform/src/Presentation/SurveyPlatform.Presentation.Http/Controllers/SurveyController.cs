using Microsoft.AspNetCore.Mvc;
using SurveyPlatform.Application.Contracts.Services;
using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class SurveyController : ControllerBase
{
    private readonly ISurveyService _surveyService;

    public SurveyController(ISurveyService surveyService)
    {
        _surveyService = surveyService;
    }

    [HttpPost]
    public ActionResult<Survey> Post(Survey survey)
    {
        _surveyService.AddSurvey(survey);

        return Ok();
    }

    [HttpGet("{id}")]
    public ActionResult<Survey> Get(int id)
    {
        Survey survey = _surveyService.GetSurvey(id);
        if (survey == null)
        {
            return NotFound();
        }

        return Ok(survey);
    }

    [HttpPut]
    public IActionResult Edit(Survey survey)
    {
        if (_surveyService.GetSurvey(survey.Id) == null)
        {
            return NotFound();
        }

        _surveyService.EditSurvey(survey);

        return Ok();
    }

    [HttpDelete("{id}")]
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