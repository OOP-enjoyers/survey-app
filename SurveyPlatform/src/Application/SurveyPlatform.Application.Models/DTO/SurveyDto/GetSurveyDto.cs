namespace SurveyPlatform.Application.Models.DTO.SurveyDto;
public class GetSurveyDto
{
    public string Title { get; set; }

    public string Description { get; set; }

    public int SurveyStatusId { get; set; }

    public GetSurveyDto(string title, string description, int surveyStatusId)
    {
        Title = title;
        Description = description;
        SurveyStatusId = surveyStatusId;
    }
}
