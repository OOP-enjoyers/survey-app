namespace SurveyPlatform.Application.Models.DTO.SurveyDto;
public class UpdateSurveyDto
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public int SurveyStatusId { get; set; }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    public UpdateSurveyDto()
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
    { }

    public UpdateSurveyDto(int id, string title, string description, int surveyStatusId)
    {
        Id = id;
        Title = title;
        Description = description;
        SurveyStatusId = surveyStatusId;
    }
}
