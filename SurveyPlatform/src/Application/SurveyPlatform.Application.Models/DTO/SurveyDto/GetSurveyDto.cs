namespace SurveyPlatform.Application.Models.DTO.SurveyDto;
public class GetSurveyDto
{
    public string Title { get; set; }

    public string Description { get; set; }

    public int SurveyStatusId { get; set; }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    public GetSurveyDto()
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    { }

    public GetSurveyDto(string title, string description, int surveyStatusId)
    {
        Title = title;
        Description = description;
        SurveyStatusId = surveyStatusId;
    }
}
