using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SurveyPlatform.Application.Contracts.Services;
using SurveyPlatform.Application.Models.DTO.SurveyDto;
using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Presentation.Http.Controllers;

[ApiController]
[Route("survey")]
public class SurveyController : ControllerBase
{
    private readonly ISurveyService _surveyService;
    private readonly IMapper _mapper;

    public SurveyController(ISurveyService surveyService, IMapper mapper)
    {
        _surveyService = surveyService;
        _mapper = mapper;
    }

    [HttpPost("add")]
    public ActionResult Add(CreateSurveyDto surveyDto)
    {
        Survey survey = _mapper.Map<Survey>(surveyDto);
        _surveyService.AddSurvey(survey);

        return Ok();
    }

    [HttpGet("get")]
    public ActionResult<GetSurveyDto> Get(int id)
    {
        Survey survey = _surveyService.GetSurvey(id);
        if (survey == null)
        {
            return NotFound();
        }

        GetSurveyDto surveyDto = _mapper.Map<GetSurveyDto>(survey);
        return Ok(surveyDto);
    }

    [HttpPut("edit")]
    public IActionResult Edit(UpdateSurveyDto surveyDto)
    {
        if (_surveyService.GetSurvey(surveyDto.Id) == null)
        {
            return NotFound();
        }

        Survey survey = _mapper.Map<Survey>(surveyDto);
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