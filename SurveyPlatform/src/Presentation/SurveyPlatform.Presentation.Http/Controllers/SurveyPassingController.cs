using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SurveyPlatform.Application.Contracts.Services;
using SurveyPlatform.Application.Models.DTO.ResponseDto;
using SurveyPlatform.Application.Models.Models;

namespace SurveyPlatform.Presentation.Http.Controllers;

[ApiController]
[Route("survey_passing")]
public class SurveyPassingController : ControllerBase
{
    private readonly ISurveyPassingService _surveyPassingService;
    private readonly IMapper _mapper;

    public SurveyPassingController(ISurveyPassingService surveyPassingService, IMapper mapper)
    {
        _surveyPassingService = surveyPassingService;
        _mapper = mapper;
    }

    [HttpPost("add")]
    public ActionResult Add(int surveyId, int userId, string[][] responses)
    {
        _surveyPassingService.AddSurveyPassing(surveyId, userId, responses);

        return Ok();
    }

    [HttpGet("get")]
    public ActionResult<IReadOnlyCollection<IReadOnlyCollection<GetResponseDto>>> Get(int surveyId, int userId)
    {
        IReadOnlyCollection<IReadOnlyCollection<Response>> responses = _surveyPassingService.GetSurveyPassing(surveyId, userId);
        if (responses.Count == 0)
        {
            return NotFound();
        }

        IReadOnlyCollection<IReadOnlyCollection<GetResponseDto>> responseDtos = responses
                    .Select(responses => responses.Select(response => _mapper.Map<GetResponseDto>(response)).ToList())
                    .ToList();
        return Ok(responseDtos);
    }

    [HttpGet("get_last")]
    public ActionResult<IReadOnlyCollection<GetResponseDto>> GetLast(int surveyId, int userId)
    {
        IReadOnlyCollection<IReadOnlyCollection<Response>> responses = _surveyPassingService.GetSurveyPassing(surveyId, userId);

        if (responses.Count == 0)
        {
            return NotFound();
        }

        IReadOnlyCollection<IReadOnlyCollection<GetResponseDto>> responseDtos = responses
                    .Select(responses => responses.Select(response => _mapper.Map<GetResponseDto>(response)).ToList())
                    .ToList();
        return Ok(responseDtos.Last());
    }
}