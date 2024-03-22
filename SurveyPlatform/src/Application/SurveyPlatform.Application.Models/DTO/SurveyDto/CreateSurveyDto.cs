namespace SurveyPlatform.Application.Models.DTO.SurveyDto;
public class CreateSurveyDto
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public int SurveyStatusId { get; set; }

    public CreateSurveyDto(int id, string title, string description, int surveyStatusId)
    {
        Id = id;
        Title = title;
        Description = description;
        SurveyStatusId = surveyStatusId;
    }
}
